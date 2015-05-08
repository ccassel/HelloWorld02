using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld02.Models
{
    public class Agent
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}