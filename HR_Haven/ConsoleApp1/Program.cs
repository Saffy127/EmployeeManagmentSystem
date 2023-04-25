using System;
using HR_Haven.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace HR_Haven.Database
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HR_Haven Database Management");
        }
    }

    public class HR_HavenDbContextFactory : IDesignTimeDbContextFactory<HR_HavenDbContext>
    {
        public HR_HavenDbContext CreateDbContext(string[] args)
        {
            var services = new ServiceCollection();
            services.AddDbContext<HR_HavenDbContext>(options =>
                options.UseSqlite("Data Source=HR_Haven.db"));
            var provider = services.BuildServiceProvider();

            return provider.GetService<HR_HavenDbContext>();
        }
    }
}
