using HelloWorld02.Models;
using System.Data.Entity;


namespace HelloWorld02.DAL
{
    public class HelloWorld02Context : System.Data.Entity.DbContext
    {

        public HelloWorld02Context()
            : base("HelloWorld02Context")
        {
        }

        public System.Data.Entity.DbSet<Agent> Agents { get; set; }
        public System.Data.Entity.DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }
    }
}