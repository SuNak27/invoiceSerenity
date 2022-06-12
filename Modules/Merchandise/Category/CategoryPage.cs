using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceKu.Merchandise.Pages
{

    [PageAuthorize(typeof(CategoryRow))]
    public class CategoryController : Controller
    {
        [Route("Merchandise/Category")]
        public ActionResult Index()
        {
            return View("~/Modules/Merchandise/Category/CategoryIndex.cshtml");
        }
    }
}