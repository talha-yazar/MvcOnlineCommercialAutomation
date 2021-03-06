using System.Linq;
using System.Web.Mvc;
using MvcOnlineCommercialAutomation.Models.Classes;

namespace MvcOnlineCommercialAutomation.Controllers
{
    public class ProductDetailController : Controller
    {
        // GET: ProductDetail
        private readonly Context con = new Context();

        public ActionResult Index()
        {
            var cs = new Class1();
            cs.Val1 = con.Products.Where(x => x.ProductID == 1).ToList();
            cs.Val2 = con.Details.Where(x => x.DetailID == 1).ToList();

            //var vals1 = con.Products.Where(x => x.ProductID == 1).ToList();
            return View(cs);
        }
    }
}