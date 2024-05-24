using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CookBook
{
    public class AppDbContext : DbContext
    {
        public DbSet<Recept> recepts {  get; set; }
        public DbSet<ReceptItem> receptItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                IConfigurationRoot configuration = builder.Build();

                // Get connection string
                string? connectionString = configuration.GetConnectionString("DefaultConnection");

                // Configure DbContext with connection string
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
