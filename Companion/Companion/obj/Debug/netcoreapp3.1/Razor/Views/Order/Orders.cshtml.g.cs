#pragma checksum "C:\Users\Dimon\OneDrive\Документы\GitHub\Companion\Companion\Companion\Views\Order\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20542eea8613a2290b29d04604772ee387472cde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Orders), @"mvc.1.0.view", @"/Views/Order/Orders.cshtml")]
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
#line 1 "C:\Users\Dimon\OneDrive\Документы\GitHub\Companion\Companion\Companion\Views\_ViewImports.cshtml"
using Companion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dimon\OneDrive\Документы\GitHub\Companion\Companion\Companion\Views\_ViewImports.cshtml"
using Companion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20542eea8613a2290b29d04604772ee387472cde", @"/Views/Order/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9408285777ca7b1e4cb21f23468c308c8a1dc9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Companion.Models.Entities.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""text-center"">
    <h2>Заказы</h2>
</div>
<div>
    <div class=""textblock"">
        <table>
            <tr>
                <td class=""tdboldtext""><p class=""tditem"">Название</p></td>
                <td class=""tdboldtext""><p class=""tditem"">Адрес</p></td>
                <td class=""tdboldtext""><p class=""tditem"">Время</p></td>
            </tr>
");
#nullable restore
#line 14 "C:\Users\Dimon\OneDrive\Документы\GitHub\Companion\Companion\Companion\Views\Order\Orders.cshtml"
             foreach (var order in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"td\">");
#nullable restore
#line 17 "C:\Users\Dimon\OneDrive\Документы\GitHub\Companion\Companion\Companion\Views\Order\Orders.cshtml"
                              Write(order.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"td\"><p class=\"tditem\">");
#nullable restore
#line 18 "C:\Users\Dimon\OneDrive\Документы\GitHub\Companion\Companion\Companion\Views\Order\Orders.cshtml"
                                                Write(order.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                    <td class=\"td\">");
#nullable restore
#line 19 "C:\Users\Dimon\OneDrive\Документы\GitHub\Companion\Companion\Companion\Views\Order\Orders.cshtml"
                              Write(order.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 21 "C:\Users\Dimon\OneDrive\Документы\GitHub\Companion\Companion\Companion\Views\Order\Orders.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Companion.Models.Entities.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
