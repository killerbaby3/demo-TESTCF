using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PM_CF.Models
{
    public class PMContext : DbContext 
    {

        public PMContext() : base("name=PMContext") { }
        public DbSet<Product> products { get; set; }
        public DbSet<Supplier> suppliers { get; set; }
    }
}