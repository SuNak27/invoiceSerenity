#pragma checksum "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc84927c8c287cf63bfcb57ebb7f73eebd162507"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Common_Dashboard_DashboardIndex), @"mvc.1.0.view", @"/Modules/Common/Dashboard/DashboardIndex.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\_ViewImports.cshtml"
using InvoiceKu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc84927c8c287cf63bfcb57ebb7f73eebd162507", @"/Modules/Common/Dashboard/DashboardIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e070595fbfbb7b841ac6fe35f16d2ebecdb6e5c", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Common_Dashboard_DashboardIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InvoiceKu.Common.DashboardPageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sales/SalesOrder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("small-box-footer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Purchase/PurchaseOrder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
  
	ViewData["Title"] = "Dashboard";
	ViewData["PageId"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Head", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
Write(Html.StyleBundle("Pages/Dashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
Write(Html.ScriptBundle("Pages/Dashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
<style>
	.widget-bg-zero {
		background: white;
		color: black;
	}

	.widget-bg-one {
		background: linear-gradient(-135deg, #1de9b6 0%, #1dc4e9 100%);
		color: white;
	}

	.widget-bg-two {
		background: linear-gradient(-135deg, #899FD4 0%, #A389D4 100%);
		color: white;
	}

	.widget-bg-three {
		background: #04a9f5;
		color: white;
	}

	.widget-bg-four {
		background: aqua;
		color: white;
	}
</style>
<script type=""text/javascript"">


	$(function () {

		$("".knob"").knob({
			'format': function (value) {
				return value + '%';
			}
		});

		var purchaseChart = new Morris.Line({
			element: 'purchase-chart',
			resize: true,
			data: ");
#nullable restore
#line 52 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
              Write(Html.Raw(Json.Serialize(Model.PurchaseGraph)));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n\t\t\txkey: \'Month\',\r\n\t\t\tykeys: [\'Amount\'],\r\n\t\t\tlabels: [\'Amount (");
#nullable restore
#line 55 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
                         Write(Model.Currency);

#line default
#line hidden
#nullable disable
                WriteLiteral(@")'],
			lineColors: ['#efefef'],
			lineWidth: 2,
			hideHover: 'auto',
			gridTextColor: ""#fff"",
			gridStrokeWidth: 0.4,
			pointSize: 4,
			pointStrokeColors: [""#efefef""],
			gridLineColor: ""#efefef"",
			gridTextFamily: ""Open Sans"",
			gridTextSize: 10
		});

		var salesChart = new Morris.Line({
			element: 'sales-chart',
			resize: true,
			data: ");
#nullable restore
#line 71 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
              Write(Html.Raw(Json.Serialize(Model.SalesGraph)));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n\t\t\txkey: \'Month\',\r\n\t\t\tykeys: [\'Amount\'],\r\n\t\t\tlabels: [\'Amount (");
#nullable restore
#line 74 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
                         Write(Model.Currency);

#line default
#line hidden
#nullable disable
                WriteLiteral(@")'],
			lineColors: ['#efefef'],
			lineWidth: 2,
			hideHover: 'auto',
			gridTextColor: ""#fff"",
			gridStrokeWidth: 0.4,
			pointSize: 4,
			pointStrokeColors: [""#efefef""],
			gridLineColor: ""#efefef"",
			gridTextFamily: ""Open Sans"",
			gridTextSize: 10
		});

	});

</script>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("ContentHeader", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"row\">\r\n\t<div class=\"col-lg-4\">\r\n\t\t<div class=\"small-box widget-bg-one\">\r\n\t\t\t<div class=\"inner\">\r\n\t\t\t\t<h3>");
#nullable restore
#line 100 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
               Write(Model.CurrentMonthSales.Amount.ToString("##,##.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t\t\t<p>Sales Orders (");
#nullable restore
#line 101 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
                            Write(Model.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"icon\">\r\n\t\t\t\t<i class=\"ion ion-bag\"></i>\r\n\t\t\t</div>\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc84927c8c287cf63bfcb57ebb7f73eebd1625079917", async() => {
                WriteLiteral("More info <i class=\"fa fa-arrow-circle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"col-lg-4\">\r\n\t\t<div class=\"small-box widget-bg-two\">\r\n\t\t\t<div class=\"inner\">\r\n\t\t\t\t<h3>");
#nullable restore
#line 112 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
               Write(Model.CurrentMonthPurchase.Amount.ToString("##,##.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t\t\t<p>Purchase Orders (");
#nullable restore
#line 113 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
                               Write(Model.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"icon\">\r\n\t\t\t\t<i class=\"ion ion-stats-bars\"></i>\r\n\t\t\t</div>\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc84927c8c287cf63bfcb57ebb7f73eebd16250712047", async() => {
                WriteLiteral("More info <i class=\"fa fa-arrow-circle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"col-lg-4\">\r\n\t\t<div class=\"small-box widget-bg-three\">\r\n\t\t\t<div class=\"inner\">\r\n\t\t\t\t<h3>");
#nullable restore
#line 124 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
               Write(Model.CurrentMonthMargin.Amount.ToString("##,##.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t\t\t<p>Margin (");
#nullable restore
#line 125 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
                      Write(Model.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</p>
			</div>
			<div class=""icon"">
				<i class=""ion ion-stats-bars""></i>
			</div>
			<a href=""#"" class=""small-box-footer"">#</a>
		</div>
	</div>
</div>
<div class=""row"">
	<div class=""col-lg-6"">
		<div class=""small-box text-center widget-bg-one"">
			<div class=""inner"">
				<input type=""text"" class=""knob"" data-readonly=""true""");
            BeginWriteAttribute("value", " value=\"", 3293, "\"", 3336, 1);
#nullable restore
#line 138 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
WriteAttributeValue("", 3301, Model.CurrentMonthSalesTransaction, 3301, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n\t\t\t\t\tdata-width=\"200\" data-height=\"200\" data-fgColor=\"#005fa9\">\r\n\t\t\t</div>\r\n\t\t\t<div class=\"icon\">\r\n\t\t\t\t<i class=\"ion ion-person-add\"></i>\r\n\t\t\t</div>\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc84927c8c287cf63bfcb57ebb7f73eebd16250715037", async() => {
                WriteLiteral("Sales Transaction <i\r\n\t\t\t\t\tclass=\"fa fa-arrow-circle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"col-lg-6\">\r\n\t\t<div class=\"small-box text-center widget-bg-two\">\r\n\t\t\t<div class=\"inner\">\r\n\t\t\t\t<input type=\"text\" class=\"knob\" data-readonly=\"true\"");
            BeginWriteAttribute("value", " value=\"", 3793, "\"", 3839, 1);
#nullable restore
#line 151 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
WriteAttributeValue("", 3801, Model.CurrentMonthPurchaseTransaction, 3801, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n\t\t\t\t\tdata-width=\"200\" data-height=\"200\" data-fgColor=\"#005fa9\">\r\n\t\t\t</div>\r\n\t\t\t<div class=\"icon\">\r\n\t\t\t\t<i class=\"ion ion-person-add\"></i>\r\n\t\t\t</div>\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc84927c8c287cf63bfcb57ebb7f73eebd16250717114", async() => {
                WriteLiteral("Purchase Transaction <i\r\n\t\t\t\t\tclass=\"fa fa-arrow-circle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n<div class=\"row\">\r\n\t<section class=\"col-lg-6 connectedSortable\">\r\n\t\t<div class=\"box box-solid widget-bg-two\">\r\n\t\t\t<div class=\"box-header\">\r\n\t\t\t\t<i class=\"fa fa-th\"></i>\r\n\t\t\t\t<h3 class=\"box-title\">Purchase Graph (");
#nullable restore
#line 167 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
                                                 Write(Model.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</h3>
			</div>
			<div class=""box-body border-radius-none"">
				<div class=""chart"" id=""purchase-chart"" style=""height: 250px;""></div>
			</div>
			<div class=""box-footer no-border"">
				<div class=""row"">
					<div class=""col-xs-4 text-center"" style=""border-right: 1px solid #f4f4f4"">
						<input type=""text"" class=""knob"" data-readonly=""true""");
            BeginWriteAttribute("value", " value=\"", 4733, "\"", 4766, 1);
#nullable restore
#line 175 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
WriteAttributeValue("", 4741, Model.PurchaseKPI1.Value, 4741, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-width=\"60\"\r\n\t\t\t\t\t\t\tdata-height=\"60\" data-fgColor=\"#899FD4\">\r\n\t\t\t\t\t\t<div class=\"knob-label\">");
#nullable restore
#line 177 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
                                           Write(Model.PurchaseKPI1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-xs-4 text-center\" style=\"border-right: 1px solid #f4f4f4\">\r\n\t\t\t\t\t\t<input type=\"text\" class=\"knob\" data-readonly=\"true\"");
            BeginWriteAttribute("value", " value=\"", 5048, "\"", 5081, 1);
#nullable restore
#line 180 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
WriteAttributeValue("", 5056, Model.PurchaseKPI2.Value, 5056, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-width=\"60\"\r\n\t\t\t\t\t\t\tdata-height=\"60\" data-fgColor=\"#899FD4\">\r\n\t\t\t\t\t\t<div class=\"knob-label\">");
#nullable restore
#line 182 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
                                           Write(Model.PurchaseKPI2.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-xs-4 text-center\">\r\n\t\t\t\t\t\t<input type=\"text\" class=\"knob\" data-readonly=\"true\"");
            BeginWriteAttribute("value", " value=\"", 5323, "\"", 5356, 1);
#nullable restore
#line 185 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
WriteAttributeValue("", 5331, Model.PurchaseKPI3.Value, 5331, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-width=\"60\"\r\n\t\t\t\t\t\t\tdata-height=\"60\" data-fgColor=\"#899FD4\">\r\n\t\t\t\t\t\t<div class=\"knob-label\">");
#nullable restore
#line 187 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
                                           Write(Model.PurchaseKPI3.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
					</div>
				</div>
			</div>
		</div>
	</section>
	<section class=""col-lg-6 connectedSortable"">
		<div class=""box box-solid widget-bg-one"">
			<div class=""box-header"">
				<i class=""fa fa-th""></i>
				<h3 class=""box-title"">Sales Graph (");
#nullable restore
#line 197 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
                                              Write(Model.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</h3>
			</div>
			<div class=""box-body border-radius-none"">
				<div class=""chart"" id=""sales-chart"" style=""height: 250px;""></div>
			</div>
			<div class=""box-footer no-border"">
				<div class=""row"">
					<div class=""col-xs-4 text-center"" style=""border-right: 1px solid #f4f4f4"">
						<input type=""text"" class=""knob"" data-readonly=""true""");
            BeginWriteAttribute("value", " value=\"", 6098, "\"", 6128, 1);
#nullable restore
#line 205 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
WriteAttributeValue("", 6106, Model.SalesKPI1.Value, 6106, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-width=\"60\"\r\n\t\t\t\t\t\t\tdata-height=\"60\" data-fgColor=\"#39CCCC\">\r\n\t\t\t\t\t\t<div class=\"knob-label\">");
#nullable restore
#line 207 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
                                           Write(Model.SalesKPI1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-xs-4 text-center\" style=\"border-right: 1px solid #f4f4f4\">\r\n\t\t\t\t\t\t<input type=\"text\" class=\"knob\" data-readonly=\"true\"");
            BeginWriteAttribute("value", " value=\"", 6407, "\"", 6437, 1);
#nullable restore
#line 210 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
WriteAttributeValue("", 6415, Model.SalesKPI2.Value, 6415, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-width=\"60\"\r\n\t\t\t\t\t\t\tdata-height=\"60\" data-fgColor=\"#39CCCC\">\r\n\t\t\t\t\t\t<div class=\"knob-label\">");
#nullable restore
#line 212 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
                                           Write(Model.SalesKPI2.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-xs-4 text-center\">\r\n\t\t\t\t\t\t<input type=\"text\" class=\"knob\" data-readonly=\"true\"");
            BeginWriteAttribute("value", " value=\"", 6676, "\"", 6706, 1);
#nullable restore
#line 215 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
WriteAttributeValue("", 6684, Model.SalesKPI3.Value, 6684, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-width=\"60\"\r\n\t\t\t\t\t\t\tdata-height=\"60\" data-fgColor=\"#39CCCC\">\r\n\t\t\t\t\t\t<div class=\"knob-label\">");
#nullable restore
#line 217 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Common\Dashboard\DashboardIndex.cshtml"
                                           Write(Model.SalesKPI3.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</section>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.ITextLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InvoiceKu.Common.DashboardPageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
