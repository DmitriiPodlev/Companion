#pragma checksum "C:\Users\Dimon\OneDrive\Документы\GitHub\Companion\Companion\Companion\Views\Order\Information.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ca92284a15ae6390751f870ec579ce76099f136"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Information), @"mvc.1.0.view", @"/Views/Order/Information.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca92284a15ae6390751f870ec579ce76099f136", @"/Views/Order/Information.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9408285777ca7b1e4cb21f23468c308c8a1dc9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Information : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Companion.Models.Entities.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-center\">\r\n    <h2>Заказ</h2>\r\n</div>\r\n<div>\r\n    <p>Название:</p><br>\r\n");
            WriteLiteral("    <p>Парикмахерская</p><br>\r\n    <p>Адрес:</p><br>\r\n");
            WriteLiteral("    <p>ул. Лепсе, д. 22</p><br>\r\n    <p>Время:</p><br>\r\n    <p>14:00</p><br>\r\n    <p>Qr-код:</p><br>\r\n    <p>qr-code</p><br>\r\n");
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Companion.Models.Entities.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
