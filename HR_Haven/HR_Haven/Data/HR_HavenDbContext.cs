using HR_Haven.Models;
using Microsoft.EntityFrameworkCore;

namespace HR_Haven.Data
{
    public class HR_HavenDbContext : DbContext
    {
        public HR_HavenDbContext(DbContextOptions<HR_HavenDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
