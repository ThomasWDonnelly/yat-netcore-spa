using Microsoft.EntityFrameworkCore;
using Yat.NetCore31.Spa.Models;

namespace Yat.NetCore31.Spa.Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
         : base(options)
        {}

        public DbSet<Product> Products { get; set; }
        public DbSet<WeatherForecast> Forecasts { get; set; }
    }
}