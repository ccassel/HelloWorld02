using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HelloWorld02.Models;

namespace HelloWorld02.DAL
{
    public class HelloWorld02Initializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<HelloWorld02Context>
    {

        protected override void Seed(HelloWorld02Context context)
        {
            var agents = new List<Agent>
            {
            new Agent{FirstName="Carson",LastName="Alexander"}, //EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Agent{FirstName="Meredith",LastName="Alonso"},
            new Agent{FirstName="Arturo",LastName="Anand"},
            new Agent{FirstName="Gytis",LastName="Barzdukas"},
            new Agent{FirstName="Yan",LastName="Li"},
            new Agent{FirstName="Peggy",LastName="Justice"},
            new Agent{FirstName="Laura",LastName="Norman"},
            new Agent{FirstName="Nino",LastName="Olivetto"}
            };

            agents.ForEach(s => context.Agents.Add(s));
            context.SaveChanges();
            var products = new List<Product>
            {
            new Product{ProductName="Critical Illness",ProductCategory="Health"},
            new Product{ProductName="Universal Life",ProductCategory="Life"},
            new Product{ProductName="Term Life",ProductCategory="Life"},
            new Product{ProductName="Accident Expense",ProductCategory="Health"},
            new Product{ProductName="Disability Income",ProductCategory="Health"}
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

        }
    }
}