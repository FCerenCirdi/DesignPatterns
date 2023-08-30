using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Composite.Practice.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-8G1SNAU\\SQLEXPRESS;initial catalog=DesignPatternPractice7;integrated security=true;");
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }


    }
}
