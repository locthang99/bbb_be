using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Persistence.Contexts
{
    public class BigBlueBirdsDbContextFactory : IDesignTimeDbContextFactory<BigBlueBirdsDbContext>
    {
        public BigBlueBirdsDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var connectionString = configuration.GetConnectionString("BigBlueBirdsDb");
            var optionsBuilder = new DbContextOptionsBuilder<BigBlueBirdsDbContext>();
            optionsBuilder.UseNpgsql(connectionString);
            return new BigBlueBirdsDbContext(optionsBuilder.Options);
        }
    }
}
