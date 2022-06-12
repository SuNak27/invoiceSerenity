using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceKu.Merchandise.Pages
{

    [PageAuthorize(typeof(FlavourRow))]
    public class FlavourController : Controller
    {
        [Route("Merchandise/Flavour")]
        public ActionResult Index()
        {
            return View("~/Modules/Merchandise/Flavour/FlavourIndex.cshtml");
        }
    }
}