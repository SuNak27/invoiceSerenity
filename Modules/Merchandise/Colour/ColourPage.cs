using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceKu.Merchandise.Pages
{

    [PageAuthorize(typeof(ColourRow))]
    public class ColourController : Controller
    {
        [Route("Merchandise/Colour")]
        public ActionResult Index()
        {
            return View("~/Modules/Merchandise/Colour/ColourIndex.cshtml");
        }
    }
}