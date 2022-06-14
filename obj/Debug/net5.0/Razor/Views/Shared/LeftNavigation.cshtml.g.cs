#pragma checksum "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\Shared\LeftNavigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55fd41616a36078764d215ed5702aa21a583329d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_LeftNavigation), @"mvc.1.0.view", @"/Views/Shared/LeftNavigation.cshtml")]
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
#line 1 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\_ViewImports.cshtml"
using InvoiceKu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55fd41616a36078764d215ed5702aa21a583329d", @"/Views/Shared/LeftNavigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc171bdc1e720eb898b9f86ce94c1dde67bcbc76", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_LeftNavigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InvoiceKu.Navigation.NavigationModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\Shared\LeftNavigation.cshtml"
  var path = new int[10]; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\Shared\LeftNavigation.cshtml"
 foreach (var item in Model.Items)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\Shared\LeftNavigation.cshtml"
Write(renderItem(item, 0, path));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\Shared\LeftNavigation.cshtml"
                              ;
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    function openWindow(url, width, height) {
        height = height || (screen.availHeight - 60);
        width = width || (screen.availWidth - 10);
        var x = (screen.availWidth - width) / 2 - 5; if (x < 0) x = 0;
        var y = (screen.availHeight - height) / 2 - 25; if (y < 0) y = 0;
        var winPopup = window.open(url, """", ""status=0, toolbar=0, width="" + width + "", height="" + height + 
            "", scrollbars=1, resizable=yes, left="" + x + "", top="" + y);
    }
</script>");
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\Shared\LeftNavigation.cshtml"
            
    public HtmlString renderItem(Serenity.Navigation.NavigationItem item, int depth, int[] path) {

        var isactive = true;
        for (var i = 0; i <= depth; i++)
        {
            if (path[i] != Model.ActivePath[i])
            {
                isactive = false;
                break;
            }
        }

        var klass = (isactive ? "active" : "") + (item.Children.IsEmptyOrNull() ? "" : " treeview");
        if (!string.IsNullOrEmpty(item.ItemClass))
        {
            klass = (klass + " " + item.ItemClass).Trim();
        }
        var icon = (item.IconClass ?? (item.Children.Count > 0 ? "icon-layers" : (depth == 0 ? "icon-link" : "fa-circle-o")));
        var title = (Localizer.TryGet("Navigation." + item.FullPath) ?? item.Title);
        var sectionUrl = (item.Url ?? "javascript:;");
        var target = item.Target; if (target != null) { target += " target=" + target; }

        var sb = new System.Text.StringBuilder();
        sb.Append("<li class='" + klass + "'><a href='" + HtmlEncoder.Encode(sectionUrl) + "' " + target + ">" +
        "<i class='nav-icon fa " + icon + "'></i><span>" + HtmlEncoder.Encode(title) + "</span>" + (!item.Children.IsEmptyOrNull() ? "<i class='fa fa-angle-left pull-right'></i>" : "") + "</a>");

        if (item.Children.Count > 0) {
            sb.Append("<ul class='treeview-menu'>");
            path[depth + 1] = 0;
            foreach (var child in item.Children)
            {
                sb.Append(renderItem(child, depth + 1, path).ToString());

            }
            sb.Append("</ul>");
        }
        sb.Append("</li>");
        path[depth]++;
        return new HtmlString(sb.ToString());
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InvoiceKu.Navigation.NavigationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
