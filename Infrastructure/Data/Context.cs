using Microsoft.EntityFrameworkCore;
using WeatherApp.AppCore.Models;

namespace WeatherApp.Infrastructure.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }
        public DbSet<ClimateDayInfo> ClimateDayInfo { get; set; }
        public DbSet<Region> Region { get; set; }
        //public DbSet<CharacteristicType> CharacteristicType { get; set; }
        //public DbSet<CharacteristicsValue> CharacteristicValue { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("TestClimate");
            //modelBuilder.Entity<ClimateDayInfo>().ToTable("ClimateDayInfo", "TestClimate");
            //modelBuilder.Entity<Region>().ToTable("Region", "TestClimate");
        }
    }
}

