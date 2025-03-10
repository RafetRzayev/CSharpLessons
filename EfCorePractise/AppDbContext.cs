using Microsoft.EntityFrameworkCore;

namespace EfCorePractise
{
    class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Pb304EfLesson;Trusted_Connection=True;TrustServerCertificate=true");
        }
    }

}
