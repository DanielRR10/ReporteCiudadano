using Microsoft.EntityFrameworkCore;
namespace sistema_reporte_ciudadano.Models
{
    public class citizenReportContext: DbContext
    {
        public citizenReportContext(DbContextOptions<citizenReportContext> options): base(options)
        {
        }

        public DbSet<User> Users{get; set;}
        public DbSet<Incident> Incidents{get; set;}
    }
}