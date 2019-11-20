using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Audit.EntityFramework;
using VuelosApp.Contexto.DAL.Migrations;
using Microsoft.Extensions.Configuration;
using Audit.Core;

namespace VuelosApp.Contexto
{
    public sealed class Contexto : AuditDbContext
    {
        private IConfiguration configuration { get; set; }
        public Contexto(DbContextOptions<Contexto> options, IConfiguration configuration) : base(options)
        {
            DbInicializar.Initialize(this);
            this.configuration = configuration;
            AuditEventType = "{database}_{context}";
            Mode = AuditOptionMode.OptOut;
            IncludeEntityObjects = false;
            Audit.Core.Configuration.DataProvider = new AuditProvider(configuration);
        }

        public Contexto(IConfiguration configuration)
        {
            this.configuration = configuration;
            DbInicializar.Initialize(this);
            AuditEventType = "{database}_{context}";
            Mode = AuditOptionMode.OptOut;
            IncludeEntityObjects = false;
            Audit.Core.Configuration.DataProvider = new AuditProvider(configuration);
        }



        //public DbSet<Person> Person { get; set; }
        //public DbSet<Country> Country { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder
           .UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override void OnScopeSaving(AuditScope auditScope)
        {
            if (!Singleton.Instance.Audit) auditScope.Discard();
            auditScope.SetCustomField("Ip", Singleton.Instance.Ip);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken()) => base.SaveChangesAsync(cancellationToken);
    }
}
