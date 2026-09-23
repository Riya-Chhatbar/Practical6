using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using program6.Models;

namespace program6.Controllers
{
    public class ProductController : Controller
    {
        static List<product> products = new List<product>
        {
            new product
            {
                Id = 1,
                Name = "Laptop",
                Category = "Electronics",
                Price = 50000,
                Description = "HP Laptop",
                ImageUrl = "laptop.pgn"
            },

            new product
            {
                Id = 2,
                Name = "Mobile",
                Category = "Electronics",
                Price = 25000,
                Description = "Android Mobile",
                ImageUrl = "mobile.webp"
            }
        };

        // GET: Product
        public ActionResult Index()
        {
            return View(products);
        }

    
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            product p = products.FirstOrDefault(x => x.Id == id);

            if (p == null)
            {
                return HttpNotFound();
            }

            return View(p);
        }
    }
}