using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceKu.Purchase.Pages
{

    [PageAuthorize(typeof(PurchaseOrderRow))]
    public class PurchaseOrderController : Controller
    {
        [Route("Purchase/PurchaseOrder")]
        public ActionResult Index()
        {
            return View("~/Modules/Purchase/PurchaseOrder/PurchaseOrderIndex.cshtml");
        }
    }
}