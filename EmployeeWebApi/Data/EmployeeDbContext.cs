using EmployeeWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebApi.Data
{
    public class EmployeeDbContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected EmployeeDbContext()
        {
        }

        public EmployeeDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-QQUJ36KT\MSSQLSERVER01;Database=ConsumingApi;Trusted_Connection=True");


        }
    }
}
