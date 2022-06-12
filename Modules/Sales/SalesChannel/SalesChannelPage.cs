using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceKu.Sales.Pages
{

    [PageAuthorize(typeof(SalesChannelRow))]
    public class SalesChannelController : Controller
    {
        [Route("Sales/SalesChannel")]
        public ActionResult Index()
        {
            return View("~/Modules/Sales/SalesChannel/SalesChannelIndex.cshtml");
        }
    }
}