using HotelProject.EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DAL.Concrete;

public class DataContext : IdentityDbContext<AppUser,AppRole,int>
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ProjectHotel;Username=postgres;Password=4216Bb321*");

    public DbSet<Room> Rooms { get; set; }
    public DbSet<Staff> Staves { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Subscribe> Subscribes { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Booking> Bookings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Identity tablolarının şemasını PostgreSQL için belirleyin
        modelBuilder.HasDefaultSchema("public");
        modelBuilder.Entity<AppUser>(entity => entity.ToTable(name: "Users"));
        modelBuilder.Entity<AppRole>(entity => entity.ToTable(name: "Roles"));
        modelBuilder.Entity<IdentityUserRole<int>>(entity => entity.ToTable("UserRoles"));
        modelBuilder.Entity<IdentityUserClaim<int>>(entity => entity.ToTable("UserClaims"));
        modelBuilder.Entity<IdentityUserLogin<int>>(entity => entity.ToTable("UserLogins"));
        modelBuilder.Entity<IdentityRoleClaim<int>>(entity => entity.ToTable("RoleClaims"));
        modelBuilder.Entity<IdentityUserToken<int>>(entity => entity.ToTable("UserTokens"));
    }

}