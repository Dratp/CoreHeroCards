#pragma checksum "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Player\Collection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad610ecfa9256083865c824c10f019a8da0e60c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Player_Collection), @"mvc.1.0.view", @"/Views/Player/Collection.cshtml")]
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
#line 1 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\_ViewImports.cshtml"
using CoreHeroCards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\_ViewImports.cshtml"
using CoreHeroCards.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad610ecfa9256083865c824c10f019a8da0e60c4", @"/Views/Player/Collection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6c3e9c6d9169f1b19cf5b04bf8743be0e0894b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Player_Collection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Player>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Player\Collection.cshtml"
  
    ViewData["Title"] = "Collection";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Collection</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Player\Collection.cshtml"
 foreach(HeroActionCard card in Model.Collection)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 10 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Player\Collection.cshtml"
  Write(card.CardName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\r\n    <p>player ");
#nullable restore
#line 11 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Player\Collection.cshtml"
         Write(card.ActionText);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Player\Collection.cshtml"
                          Write(card.Target);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Player\Collection.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Player> Html { get; private set; }
    }
}
#pragma warning restore 1591
