using Microsoft.EntityFrameworkCore;
using NLogLibrary.Models;

namespace NLogLibrary.Database
{
    public sealed  class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;initial catalog=NLogDb;integrated security=true;TrustServerCertificate=True");
        }
        public DbSet<Log> Logs { get; set; }
    }
}
