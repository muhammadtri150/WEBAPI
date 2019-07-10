using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BelanjaDulu.Controllers
{
    public class LayoutController : Controller
    {
        // GET: Layout
        [Route("layout")]
        public ActionResult Index()
        {
            return View("TampilLayout");
        }
    }
}