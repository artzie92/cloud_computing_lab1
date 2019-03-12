using Lab1_aziemianski.Rest.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab1_aziemianski.Rest.Context
{
    public class AzureDbEntities : DbContext
    {
        public AzureDbEntities(DbContextOptions<AzureDbEntities> options)
            : base(options)
        {
        }

        protected AzureDbEntities()
        {
        }

        public DbSet<Person> People { get; set; }
    }
}