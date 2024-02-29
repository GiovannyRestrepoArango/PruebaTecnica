using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalSoft.Domain.Entities;
using System.Reflection;

namespace PersonalSoft.Infrastructure.Data
{
    public class PersonalSoftDbContext : DbContext
    {
        public PersonalSoftDbContext(DbContextOptions<PersonalSoftDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<LocationXVehicle> LocationXVehicle { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AI");            
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
