using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            builder.Seed();
        }
    }
}