using BDTestTask.Models;
using Microsoft.EntityFrameworkCore;

namespace BDTestTask.Contexts
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }

        public string DbPath { get; }

        public EmployeeContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "BDTestTask/Employee.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
