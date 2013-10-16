using System.Web.Mvc;

namespace MvcSiteMapTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Home/A

        public ActionResult A(int? id)
        {
            return View();
        }

        //
        // GET: /Home/B

        public ActionResult B(int? id)
        {
            return View();
        }

        //
        // GET: /Home/C

        public ActionResult C(int? id)
        {
            return View();
        }

    }
}
