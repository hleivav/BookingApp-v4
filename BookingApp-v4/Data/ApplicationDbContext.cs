using BookingApp_v4.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookingApp_v4.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public DbSet<GymClass> GymClasses => Set<GymClass>();  
        public DbSet<ApplicationUserGymClass> ApplicationUserGymClasses => Set<ApplicationUserGymClass>();
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUserGymClass>()
                .HasKey(a => new { a.ApplicationUserId, a.GymClassId }); 
        }
        public DbSet<BookingApp_v4.Entities.ApplicationUserGymClass>? ApplicationUserGymClass { get; set; }
    }
}