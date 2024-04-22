using FakeBookApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FakeBookApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .Property(b => b.Name)
                .IsRequired();
        }
    }
}