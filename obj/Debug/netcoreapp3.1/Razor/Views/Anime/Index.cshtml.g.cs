#pragma checksum "E:\An\project\sendmail\Views\Anime\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c2b9a0e5f7672fa21498cc175cd69fc0178d075"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anime_Index), @"mvc.1.0.view", @"/Views/Anime/Index.cshtml")]
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
#line 1 "E:\An\project\sendmail\Views\_ViewImports.cshtml"
using sendMail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\An\project\sendmail\Views\_ViewImports.cshtml"
using sendMail.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c2b9a0e5f7672fa21498cc175cd69fc0178d075", @"/Views/Anime/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f14f576f6ce4dc4d437ad4491089c05a03497107", @"/Views/_ViewImports.cshtml")]
    public class Views_Anime_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sendMail.Models.ListAnime>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul>\r\n");
#nullable restore
#line 9 "E:\An\project\sendmail\Views\Anime\Index.cshtml"
     foreach (var list in Model.Anime)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            ");
#nullable restore
#line 12 "E:\An\project\sendmail\Views\Anime\Index.cshtml"
       Write(list.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 14 "E:\An\project\sendmail\Views\Anime\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sendMail.Models.ListAnime> Html { get; private set; }
    }
}
#pragma warning restore 1591
