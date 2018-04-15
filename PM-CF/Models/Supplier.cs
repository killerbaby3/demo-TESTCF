using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PM_CF.Models
{
    public class Supplier
    {
        [Key]
        public int supId { get; set; }
        public string supName { get; set; }

        public string address { get; set; }

        public string email { get; set; }

        public ICollection<Product> products { get; set; }

    }
}