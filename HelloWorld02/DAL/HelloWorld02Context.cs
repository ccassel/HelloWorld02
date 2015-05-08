using HelloWorld02.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HelloWorld02.DAL
{
    public class HelloWorld02Context : DbContext
    {

        public HelloWorld02Context()
            : base("HelloWorld02Context")
        {
        }

        public DbSet<Agent> Agents { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}