using jQueryDataTablev2.Models;
using System.Linq;
using System.Web.Mvc;

namespace jQueryDataTablev2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult loadData()
        {

            using (DatabaseDataTableEntities entities = new DatabaseDataTableEntities())
            {
                var data = entities.Customers.OrderBy(a => a.CompanyName).ToList();
                return Json(new { data = data }, JsonRequestBehavior.AllowGet);
            }
        }


    }
}