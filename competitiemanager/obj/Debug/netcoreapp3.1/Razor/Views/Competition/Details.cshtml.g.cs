#pragma checksum "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cbe1178323459ee1638b6647584d9e0e8de9b83"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cbe1178323459ee1638b6647584d9e0e8de9b83", @"/Views/Competition/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6701d0da5c8b8210c3e89824b9dac22dba9edc02", @"/Views/_ViewImports.cshtml")]
    public class Views_Competition_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Competition>
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
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 3 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div>\r\n");
#nullable restore
#line 5 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
      int i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    <h3>Stand</h3>
    <table class=""rankingTable"">
        <tr class=""rankingTableHeaderRow"">
            <th class=""rankingTableHeader""></th>
            <th class=""rankingTableHeader"">Team</th>
            <th class=""rankingTableHeader"">GS</th>
            <th class=""rankingTableHeader"">W</th>
            <th class=""rankingTableHeader"">V</th>
            <th class=""rankingTableHeader"">G</th>
            <th class=""rankingTableHeader"">DV - DT</th>
            <th class=""rankingTableHeader"">DS</th>
            <th class=""rankingTableHeader"">P</th>
        </tr>
");
#nullable restore
#line 22 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
         foreach (var team in Model.Teams)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"rankingTableRow\">\r\n                <td class=\"rankingTableItem\">");
#nullable restore
#line 25 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"rankingTableItem\">");
#nullable restore
#line 26 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                        Write(team.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"rankingTableItem\">");
#nullable restore
#line 27 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                        Write(team.GamesPlayed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"rankingTableItem\">");
#nullable restore
#line 28 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                        Write(team.GamesWon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"rankingTableItem\">");
#nullable restore
#line 29 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                        Write(team.GamesLost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"rankingTableItem\">");
#nullable restore
#line 30 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                        Write(team.GamesTied);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"rankingTableItem\">");
#nullable restore
#line 31 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                        Write(team.Goals);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 31 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                                      Write(team.CounterGoals);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"rankingTableItem\">");
#nullable restore
#line 32 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                        Write(team.DoelSaldo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"rankingTableItem\">");
#nullable restore
#line 33 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                        Write(team.Points);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
            i++;

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n\r\n    <h3>Wedstrijden</h3>\r\n\r\n\r\n\r\n");
#nullable restore
#line 46 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
     foreach (var game in Model.Games)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"gameCard\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cbe1178323459ee1638b6647584d9e0e8de9b839174", async() => {
#nullable restore
#line 50 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                                                                                       Write(game.HomeTeam.Team.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" vs. ");
#nullable restore
#line 50 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
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
#line 50 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
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
#line 53 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                         Write(game.HomeTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><p class=\"gameCardText\" >");
#nullable restore
#line 54 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                            Write(game.StartDateAndTime.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                    <td class=\"gameCardText\"> ");
#nullable restore
#line 55 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                         Write(game.AwayTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"gameCardScore\" rowspan=\"2\" style=\"padding-left: 60px\">");
#nullable restore
#line 58 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                                                                Write(game.GoalsHome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><p class=\"gameCardText\">");
#nullable restore
#line 59 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                           Write(game.StartDateAndTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                    <td class=\"gameCardScore\" rowspan=\"2\"  style=\"padding-right: 60px\">");
#nullable restore
#line 60 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                                                                  Write(game.GoalsAway);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    \r\n                </tr>\r\n                <tr>\r\n");
            WriteLiteral("                    <td class=\"gameCardText\"> ");
#nullable restore
#line 65 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                         Write(game.HomeTeam.Team.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    \r\n                </tr>\r\n                <tr>\r\n                    <td></td>\r\n                    <td>\r\n");
#nullable restore
#line 71 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                         switch (game.Status)
                        {
                            case 0:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"gameCardText\">Nog niet gespeeld</p>\r\n");
#nullable restore
#line 75 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                break;
                            case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"gameCardText\">Bezig</p>\r\n");
#nullable restore
#line 78 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                break;
                            case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"gameCardText\"><b>Afgelopen</b></p>\r\n");
#nullable restore
#line 81 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
                                break;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td></td>\r\n                </tr>\r\n            </table>\r\n        </div>\r\n");
#nullable restore
#line 88 "C:\Users\Birgi\GitHub\SDpraktijk3\competitiemanager\Views\Competition\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
