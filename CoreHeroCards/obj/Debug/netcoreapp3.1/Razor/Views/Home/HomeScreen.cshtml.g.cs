#pragma checksum "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Home\HomeScreen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98cc699c7bff6858a9154a3000be66904f0c4512"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HomeScreen), @"mvc.1.0.view", @"/Views/Home/HomeScreen.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98cc699c7bff6858a9154a3000be66904f0c4512", @"/Views/Home/HomeScreen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6c3e9c6d9169f1b19cf5b04bf8743be0e0894b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HomeScreen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Player>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Shop/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Player/Collection"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Home\HomeScreen.cshtml"
  
    ViewData["Title"] = "HomeScreen";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>HomeScreen</h1>\r\n\r\n<p>Welcome ");
#nullable restore
#line 8 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Home\HomeScreen.cshtml"
      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n<p>Dolls = ");
#nullable restore
#line 10 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Home\HomeScreen.cshtml"
      Write(Model.Dolls.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n<p>Decks = ");
#nullable restore
#line 12 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Home\HomeScreen.cshtml"
      Write(Model.Decks.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n<p>Cards in Collection = ");
#nullable restore
#line 14 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Home\HomeScreen.cshtml"
                    Write(Model.Collection.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98cc699c7bff6858a9154a3000be66904f0c45125196", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"playerID\"");
                BeginWriteAttribute("value", " value=\"", 335, "\"", 358, 1);
#nullable restore
#line 18 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Home\HomeScreen.cshtml"
WriteAttributeValue("", 343, Model.PlayerID, 343, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
                WriteLiteral("    <input type=\"submit\" value=\"Hero Store\" />\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98cc699c7bff6858a9154a3000be66904f0c45127028", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"playerID\"");
                BeginWriteAttribute("value", " value=\"", 607, "\"", 630, 1);
#nullable restore
#line 24 "C:\DevBuild4\WebApps\CoreHeroCards\CoreHeroCards\Views\Home\HomeScreen.cshtml"
WriteAttributeValue("", 615, Model.PlayerID, 615, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"submit\" value=\"View Collection\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
