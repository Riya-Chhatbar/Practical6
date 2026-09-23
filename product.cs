using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace program6.Models
{
    public class product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}

   
