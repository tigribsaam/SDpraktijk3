#pragma checksum "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac350a240607491f3d1664b4dfe0ae1048d5264f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Competition_Details), @"mvc.1.0.view", @"/Views/Competition/Details.cshtml")]
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
#line 1 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\_ViewImports.cshtml"
using competitiemanager.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\_ViewImports.cshtml"
using competitiemanager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac350a240607491f3d1664b4dfe0ae1048d5264f", @"/Views/Competition/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6701d0da5c8b8210c3e89824b9dac22dba9edc02", @"/Views/_ViewImports.cshtml")]
    public class Views_Competition_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Competition>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Game", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 3 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div>\r\n\r\n    <h3>Teams:</h3>\r\n");
#nullable restore
#line 7 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
     foreach (var team in Model.Teams)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 9 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
      Write(team.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 10 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h3>Wedstrijden:</h3>\r\n");
#nullable restore
#line 13 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
     foreach (var game in Model.Games)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac350a240607491f3d1664b4dfe0ae1048d5264f4976", async() => {
#nullable restore
#line 15 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                                                             Write(game.HomeTeam.Team.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" vs. ");
#nullable restore
#line 15 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                                                                                          Write(game.AwayTeam.Team.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                                        WriteLiteral(game.GameId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <p>");
#nullable restore
#line 16 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
      Write(game.StartDateAndTime.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 17 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
         switch (game.Status)
        {
            case 0:

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Nog niet gespeeld</p>\r\n");
#nullable restore
#line 21 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                break;
            case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Bezig</p>\r\n                <p>");
#nullable restore
#line 24 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
              Write(game.GoalsHome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 24 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                Write(game.GoalsAway);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 25 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                break;
            case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>afgelopen</p>\r\n                <p>");
#nullable restore
#line 28 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
              Write(game.GoalsHome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 28 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                Write(game.GoalsAway);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 29 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                break;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Competition> Html { get; private set; }
    }
}
#pragma warning restore 1591
