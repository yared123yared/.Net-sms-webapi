using Microsoft.EntityFrameworkCore;
using smsapi.Model;

namespace smsapi.Data

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Grade> Grade { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>().HasKey(x => new
            {
                x.CoNo,
                x.SemesterId,
                x.StudentId
            });
            modelBuilder.Entity<Student>().HasKey(x => x.StudentId);
            modelBuilder.Entity<Faculty>().HasKey(x => x.FacultyId);
            modelBuilder.Entity<Department>().HasKey(x => x.DepartmentId);
            modelBuilder.Entity<Course>().HasKey(x => x.CoNo);
        }
    }

}