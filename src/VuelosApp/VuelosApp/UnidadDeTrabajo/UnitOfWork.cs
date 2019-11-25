using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using VuelosApp.Entidades;

namespace VuelosApp.DAL.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private IConfiguration configuration { get; }
        private Contexto context;
        public UnitOfWork(IConfiguration configuration)
        {
            this.configuration = configuration;
            context = new Contexto(configuration);
        }
         
        private bool disposed = false;
        private Repositorio<AvionesEnt> avionesEntRepository;
        private Repositorio<VueloEnt> vueloEntRepository;
        private Repositorio<PasajerosEnt> pasajerosEntRepository;
        private Repositorio<SillasEnt> sillasEntRepository;
        private Repositorio<VuelosPorPasajeroEnt> vuelosPorPasajeroRepository;
        private Repositorio<VueloEnt> vueloRepository;

        public Repositorio<AvionesEnt> AvionesEntRepository
        {
            get
            {
                if (this.avionesEntRepository == null)
                {
                    this.avionesEntRepository = new Repositorio<AvionesEnt>(context);
                }
                return avionesEntRepository;
            }
        }
        public Repositorio<VueloEnt> VueloEntRepository
        {
            get
            {
                if (this.vueloEntRepository == null)
                {
                    this.vueloEntRepository = new Repositorio<VueloEnt>(context);
                }
                return vueloEntRepository;
            }
        }
        public Repositorio<PasajerosEnt> PasajerosEntRepository
        {
            get
            {
                if (this.pasajerosEntRepository == null)
                {
                    this.pasajerosEntRepository = new Repositorio<PasajerosEnt>(context);
                }
                return pasajerosEntRepository;
            }
        }
        public Repositorio<SillasEnt> SillasEntRepository
        {
            get
            {
                if (this.sillasEntRepository == null)
                {
                    this.sillasEntRepository = new Repositorio<SillasEnt>(context);
                }
                return sillasEntRepository;
            }
        }
        public Repositorio<VuelosPorPasajeroEnt> VuelosPorPasajeroRepository
        {
            get
            {
                if (this.vuelosPorPasajeroRepository == null)
                {
                    this.vuelosPorPasajeroRepository = new Repositorio<VuelosPorPasajeroEnt>(context);
                }
                return vuelosPorPasajeroRepository;
            }
        }
        public Repositorio<VueloEnt> VueloRepository
        {
            get
            {
                if (this.vueloRepository == null)
                {
                    this.vueloRepository = new Repositorio<VueloEnt>(context);
                }
                return vueloRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
