using CodeFirst.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace CodeFirst
{
    public class MyDbContext : DbContext
    {
        /// <summary>
        /// Represents the People table
        /// </summary>
        public DbSet<Person> People { get; set; }

        /// <summary>
        /// Represents the Addresses table
        /// </summary>
        public DbSet<Address> Addresses { get; set; }

        /// <summary>
        /// Configures the connection to the Sql Server database instance
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                   .SetBasePath(AppContext.BaseDirectory)
                   .AddJsonFile("appsettings.json", false)
                   .Build();

            var connectionString = configuration["ConnectionStrings:DefaultConnection"];
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
