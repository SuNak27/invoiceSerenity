using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceKu.Sales.Pages
{

    [PageAuthorize(typeof(CustumerContactRow))]
    public class CustumerContactController : Controller
    {
        [Route("Sales/CustumerContact")]
        public ActionResult Index()
        {
            return View("~/Modules/Sales/CustumerContact/CustumerContactIndex.cshtml");
        }
    }
}