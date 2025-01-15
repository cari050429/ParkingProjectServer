using Microsoft.EntityFrameworkCore;

namespace ParkingProjectServer.Data
{
    public class ParkingDbContext : DbContext
    {
        public ParkingDbContext(DbContextOptions<ParkingDbContext> options)
            : base(options)
        { }

        public DbSet<ParkingAreas> ParkingAreas { get; set; }
        public DbSet<ParkingPermits> ParkingPermits { get; set; }
        public DbSet<ParkingAreaTypes> ParkingAreaTypes { get; set; }

    }
}
