using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tugass.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        [Route("TampilProduk")]
        public ActionResult TampilProduk()
        {
            return View();
        }
    }
}