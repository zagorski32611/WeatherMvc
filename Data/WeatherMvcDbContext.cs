using Microsoft.EntityFrameworkCore;
using weatherMvc.Models;

namespace weatherMvc.Data
{
    public class WeatherMvcDbContext : DbContext
    {
        public WeatherMvcDbContext(DbContextOptions<WeatherMvcDbContext> options)
            : base(options)
        {

        }

        public DbSet<WeatherData> WeatherData { get; set; }

        public DbSet<Currently> Currently { get; set; }

        public DbSet<Minutely> Minutely { get; set; }

        public DbSet<Hourly> Hourly { get; set; }

        public DbSet<Daily> Daily { get; set; }

        public DbSet<Alert> Alerts { get; set; }

        public DbSet<Flags> WeatherFlags { get; set; }

        public DbSet<MinutelyData> MinutelyData { get; set; }

        public DbSet<HourlyData> HourlyData { get; set; }

        public DbSet<DailyData> DailyData { get; set; }

        public DbSet<AlertData> AlertData { get; set; }

        public DbSet<FlagSource> FlagSources { get; set; }

        public DbSet<AlertRegion> AlertRegions { get; set; }

        public DbSet<LocationData> LocationData { get; set; }
        public DbSet<requestAndResponse> requestAndResponse { get; internal set; }
    }
}