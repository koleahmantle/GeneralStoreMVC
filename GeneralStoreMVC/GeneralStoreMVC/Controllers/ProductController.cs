using GeneralStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeneralStoreMVC.Controllers
{
    public class ProductController : Controller
    {
        //Add the application DB context (link to the Database)
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Product
        public ActionResult Index()
        {
            // See Below (modifying ApplicattionDbContext class)
            return View(_db.Products.ToList());
        }
    }
}