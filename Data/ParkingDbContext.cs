using Microsoft.EntityFrameworkCore;

namespace ParkingProjectServer.Data
{
    public class ParkingDbContext : DbContext
    {
        public ParkingDbContext(DbContextOptions<ParkingDbContext> options)
            : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ParkingAreas>()
                .HasOne(pa => pa.ParkingAreaType) 
                .WithMany()  
                .HasForeignKey(pa => pa.ParkingAreaTypeID) 
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ParkingPermits>()
                .HasOne(pa => pa.ParkingArea) 
                .WithMany()  
                .HasForeignKey(pa => pa.ParkingAreaID) 
                .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<ParkingAreas> ParkingAreas { get; set; }
        public DbSet<ParkingPermits> ParkingPermits { get; set; }
        public DbSet<ParkingAreaTypes> ParkingAreaTypes { get; set; }

    }
}
