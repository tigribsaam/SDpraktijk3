#pragma checksum "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2675ff4c1631165b82e6b1a9e5ae307b2d0a87eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\_ViewImports.cshtml"
using competitiemanager.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\_ViewImports.cshtml"
using competitiemanager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2675ff4c1631165b82e6b1a9e5ae307b2d0a87eb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6701d0da5c8b8210c3e89824b9dac22dba9edc02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("gameCardTitle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Game", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1>Home</h1>\r\n\r\n<p>De NOVI-competitiemanager! Alle NOVI-medewerkers kunnen zich makkelijk registreren om een competitie aan te maken of een weddenschap te plaatsen.</p>\r\n\r\n\r\n<div class=\"divinline\">\r\n    <h3>Wedstrijden deze week</h3>\r\n");
#nullable restore
#line 10 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
     foreach (var game in Model.Games)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"gameCard\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2675ff4c1631165b82e6b1a9e5ae307b2d0a87eb4609", async() => {
#nullable restore
#line 14 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
                                                                                                       Write(game.HomeTeam.Team.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" vs. ");
#nullable restore
#line 14 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
                                                                                                                                    Write(game.AwayTeam.Team.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
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
            WriteLiteral("\r\n            <table class=\"gameCardTable\">\r\n                <tr>\r\n                    <td class=\"gameCardText\"> ");
#nullable restore
#line 17 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
                                         Write(game.HomeTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><p class=\"gameCardText\">");
#nullable restore
#line 18 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
                                           Write(game.StartDateAndTime.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                    <td class=\"gameCardText\"> ");
#nullable restore
#line 19 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
                                         Write(game.AwayTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"gameCardScore\" rowspan=\"2\" style=\"padding-left: 60px\">");
#nullable restore
#line 22 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
                                                                                Write(game.GoalsHome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><p class=\"gameCardText\">");
#nullable restore
#line 23 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
                                           Write(game.StartDateAndTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                    <td class=\"gameCardScore\" rowspan=\"2\" style=\"padding-right: 60px\">");
#nullable restore
#line 24 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
                                                                                 Write(game.GoalsAway);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n                <tr>\r\n");
            WriteLiteral("                    <td class=\"gameCardText\"> ");
#nullable restore
#line 29 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
                                         Write(game.HomeTeam.Team.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n                <tr>\r\n                    <td></td>\r\n                    <td>\r\n");
#nullable restore
#line 35 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
                         switch (game.Status)
                        {
                            case 0:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"gameCardText\">Nog niet gespeeld</p>\r\n");
#nullable restore
#line 39 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
                                break;
                            case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"gameCardText\">Bezig</p>\r\n");
#nullable restore
#line 42 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
                                break;
                            case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"gameCardText\"><b>Afgelopen</b></p>\r\n");
#nullable restore
#line 45 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
                                break;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td></td>\r\n                </tr>\r\n            </table>\r\n        </div>\r\n");
#nullable restore
#line 52 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"divinline\">\r\n    <h3>Huidige stand toto</h3>\r\n");
#nullable restore
#line 57 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
      int i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div >
        <table class=""rankingTable"">
            <tr class=""rankingTableHeaderRow"">
                <th class=""rankingTableHeader""></th>
                <th class=""rankingTableHeader"">Gebruikersnaam</th>
                <th class=""rankingTableHeader"">Score</th>
            </tr>
");
#nullable restore
#line 66 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
             foreach (var u in Model.Users)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"rankingTableRow\">\r\n                    <td class=\"rankingTableItem\">");
#nullable restore
#line 69 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"rankingTableItem\">");
#nullable restore
#line 70 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
                                            Write(u.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"rankingTableItem\">");
#nullable restore
#line 71 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
                                            Write(u.TotoScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 74 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager - Copy\Views\Home\Index.cshtml"
                i++;

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
