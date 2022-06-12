using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceKu.Sales.Pages
{

    [PageAuthorize(typeof(SalesOrderDetailRow))]
    public class SalesOrderDetailController : Controller
    {
        [Route("Sales/SalesOrderDetail")]
        public ActionResult Index()
        {
            return View("~/Modules/Sales/SalesOrderDetail/SalesOrderDetailIndex.cshtml");
        }
    }
}