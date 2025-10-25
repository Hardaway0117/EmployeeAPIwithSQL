using Microsoft.EntityFrameworkCore;
using EmployeeAPIwithSQL.Models;//串table

namespace EmployeeAPIwithSQL.Data
{
    //pipe
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        //create table(Employees)
        public DbSet<Employee> Employees { get; set; }
    }
}
