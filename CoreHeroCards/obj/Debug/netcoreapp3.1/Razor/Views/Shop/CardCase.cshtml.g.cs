#pragma checksum "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Shop\CardCase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a9892d05de439f690b9fc48dbcf9500175d75bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_CardCase), @"mvc.1.0.view", @"/Views/Shop/CardCase.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a9892d05de439f690b9fc48dbcf9500175d75bb", @"/Views/Shop/CardCase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6c3e9c6d9169f1b19cf5b04bf8743be0e0894b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_CardCase : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HeroActionCard>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Shop/BuyCards"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Shop\CardCase.cshtml"
  
    ViewData["Title"] = "CardCase";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CardCase</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a9892d05de439f690b9fc48dbcf9500175d75bb3807", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"playerID\"");
                BeginWriteAttribute("value", " value=\"", 168, "\"", 193, 1);
#nullable restore
#line 9 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Shop\CardCase.cshtml"
WriteAttributeValue("", 176, ViewBag.PlayerID, 176, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 10 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Shop\CardCase.cshtml"
     for(int i = 0; i< Model.Count; i++)
    {
        

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"checkbox\" name=\"X\"");
                BeginWriteAttribute("value", " value=\"", 388, "\"", 416, 1);
#nullable restore
#line 13 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Shop\CardCase.cshtml"
WriteAttributeValue("", 396, Model[i].ShopCardID, 396, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        <p>Card name: ");
#nullable restore
#line 14 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Shop\CardCase.cshtml"
                 Write(Model[i].CardName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : User ");
#nullable restore
#line 14 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Shop\CardCase.cshtml"
                                           Write(Model[i].ActionText);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 14 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Shop\CardCase.cshtml"
                                                                Write(Model[i].Target);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <br />\r\n");
#nullable restore
#line 16 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Shop\CardCase.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <input type=\"submit\" value=\"Buy Cards!\"/>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HeroActionCard>> Html { get; private set; }
    }
}
#pragma warning restore 1591
