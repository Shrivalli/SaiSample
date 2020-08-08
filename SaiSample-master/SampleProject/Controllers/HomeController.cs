using SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleProject.Controllers
{
   public class HomeController : Controller
    {
        public static ProductSample obj = new ProductSample();
        NorthwindEntities db = new NorthwindEntities();
        List<ProductSample> ps = (List<ProductSample>)obj.getAllProducts();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //New method Sample
        public ActionResult Sample()
        {
            return View();
        }

        //New method Sample
        public ActionResult Sample2()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult getBySup(string s)
        {
            List<ProductSample> ps = (List<ProductSample>)obj.getAllProducts();
            /* var result = (from i in ps
                           where i.Supplier == s
                           select i).ToList();*/
            var result = ps.Where(x => x.Supplier == s).Select(x => x);
            return View(result);
        }

        public ActionResult getPricebelowThousand(int val)
        {
            //var result = (from i in ps
            //              where i.Price < val
            //              select i).ToList();
            var result = ps.Where(j => j.Price < val).Select(j => j).OrderBy(j => j.Qty);
            //var result = ps.Select(x => x).OrderBy(x => x.Qty);
            //var result = (from i in ps
            //              orderby i.Qty descending
            //              select i).ToList();

            return View(result);
        }

        public ActionResult GetOrderDetails()
        {
            var result = (from i in db.Orders
                          where i.Customer.Phone == "0621-08460"
                          select i).ToList();
            return View(result);
        }

    }
}