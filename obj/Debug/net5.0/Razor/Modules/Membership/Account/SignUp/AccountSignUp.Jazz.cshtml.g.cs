#pragma checksum "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Membership\Account\SignUp\AccountSignUp.Jazz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8578bd4bb943ab158f3ac6b53333e070ab2c8897"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_SignUp_AccountSignUp_Jazz), @"mvc.1.0.view", @"/Modules/Membership/Account/SignUp/AccountSignUp.Jazz.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8578bd4bb943ab158f3ac6b53333e070ab2c8897", @"/Modules/Membership/Account/SignUp/AccountSignUp.Jazz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e070595fbfbb7b841ac6fe35f16d2ebecdb6e5c", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_SignUp_AccountSignUp_Jazz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Serenity.Assets/Content/toastr.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Membership\Account\SignUp\AccountSignUp.Jazz.cshtml"
  
	ViewData["Title"] = Texts.Forms.Membership.Login.FormTitle.ToString(Localizer);
	ViewData["PageId"] = "SignUp";
	ViewData["BodyClass"] = "register-page";
	Layout = MVC.Views.Shared._LayoutNoNavigation;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Head", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8578bd4bb943ab158f3ac6b53333e070ab2c88975635", async() => {
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
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8578bd4bb943ab158f3ac6b53333e070ab2c88976809", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"



<script id=""Template_Membership_JazzSignUpPanel"" type=""text/template"">
	<div>
		<form id=""~_Form"" action="""">
			<div class=""s-Form"">
				<div class=""fieldset"">
					<div id=""~_PropertyGrid""></div>
					<div class=""clear""></div>
				</div>
				<div class=""buttons"">
					<button id=""~_SubmitButton"" type=""submit"" class=""btn btn-primary"">
	");
#nullable restore
#line 28 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Membership\Account\SignUp\AccountSignUp.Jazz.cshtml"
Write(Texts.Forms.Membership.SignUp.SubmitButton.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
					</button>
				</div>
			</div>
		</form>
	</div>
</script>

<div class=""auth-wrapper aut-bg-img-side cotainer-fiuid align-items-stretch"">
	<div class=""row align-items-center w-100 align-items-stretch bg-white"">
		<div class=""d-none d-lg-flex col-lg-8 aut-bg-img align-items-center d-flex justify-content-center"">
			<div class=""col-md-8"">
				<h1 class=""mb-5"">");
#nullable restore
#line 40 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Membership\Account\SignUp\AccountSignUp.Jazz.cshtml"
                            Write(Texts.Forms.Membership.SignUp.FormTitle.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\t\t\t\t<h3>");
#nullable restore
#line 41 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Membership\Account\SignUp\AccountSignUp.Jazz.cshtml"
               Write(Texts.Forms.Membership.SignUp.FormInfo.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
			</div>
		</div>
		<div class=""col-lg-4 align-items-stret h-100 align-items-center d-flex justify-content-center"">
			<div class="" auth-content text-center"">
				<div class=""mb-4"">
					<i class=""feather icon-user-plus auth-icon""></i>
				</div>
				<h3 class=""mb-4"">");
#nullable restore
#line 49 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Membership\Account\SignUp\AccountSignUp.Jazz.cshtml"
                            Write(Texts.Forms.Membership.SignUp.FormTitle.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t\t\t<div id=\"SignUpPanel\">\r\n\t\t\t\t</div>\r\n\t\t\t\t<p class=\"mb-0 text-muted\"><a");
            BeginWriteAttribute("href", " href=\"", 1763, "\"", 1801, 1);
#nullable restore
#line 52 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Membership\Account\SignUp\AccountSignUp.Jazz.cshtml"
WriteAttributeValue("", 1770, Url.Content("~/Account/Login"), 1770, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t");
#nullable restore
#line 53 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Modules\Membership\Account\SignUp\AccountSignUp.Jazz.cshtml"
                   Write(Texts.Forms.Membership.SignUp.BackToLogin.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n\r\n\r\n<script type=\"text/javascript\">\r\n\t$(function () {\r\n\t\tnew InvoiceKu.Membership.JazzSignUpPanel($(\'#SignUpPanel\')).init();\r\n\t});\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
