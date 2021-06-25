using Microsoft.EntityFrameworkCore;
using ProjeYonetim.Entities;

namespace ProjeYonetim.Data
{
    public class ProjeYonetimDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=ProjeYonetimDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EmployeeProject>()
                .HasKey(x => new { x.EmployeeId, x.ProjectId });

            modelBuilder.Entity<Employee>()
                .Property(x => x.LastUpdateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

        }
    }
}
