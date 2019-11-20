
using Audit.SqlServer.Providers;
using Microsoft.Extensions.Configuration;

namespace VuelosApp.Contexto
{
    public class AuditProvider : SqlDataProvider
    {
        public AuditProvider(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("DefaultConnection");
            Schema = "dbo";
            TableName = "Event";
            IdColumnName = "EventId";
            JsonColumnName = "Data";
            LastUpdatedDateColumnName = "LastUpdatedDate";
        }
    }
}
