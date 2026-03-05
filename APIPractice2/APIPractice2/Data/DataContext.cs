using APIPractice2.Models;
using Microsoft.EntityFrameworkCore;

namespace APIPractice2.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithOne(d => d.Employee)
                .HasForeignKey<Department>(d => d.EmpID);

            modelBuilder.Entity<Department>()
                .HasKey(d => d.DeptID);
            modelBuilder.Entity<Employee>()
                .HasKey(e => e.EmpID);
        }

    }
}
