#pragma checksum "C:\Users\Birgi\GitHub\SDpraktijk3\Competitiemanager\Views\Game\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "854be8710755df76970d5b91d1864c46ba571541"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Details), @"mvc.1.0.view", @"/Views/Game/Details.cshtml")]
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
#line 1 "C:\Users\Birgi\GitHub\SDpraktijk3\Competitiemanager\Views\_ViewImports.cshtml"
using competitiemanager.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Birgi\GitHub\SDpraktijk3\Competitiemanager\Views\_ViewImports.cshtml"
using competitiemanager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"854be8710755df76970d5b91d1864c46ba571541", @"/Views/Game/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6701d0da5c8b8210c3e89824b9dac22dba9edc02", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Game>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Game", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "inputScore", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Birgi\GitHub\SDpraktijk3\Competitiemanager\Views\Game\Details.cshtml"
 if (Model.Status < 3)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "854be8710755df76970d5b91d1864c46ba5715413915", async() => {
                WriteLiteral("Score invoeren");
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
#line 5 "C:\Users\Birgi\GitHub\SDpraktijk3\Competitiemanager\Views\Game\Details.cshtml"
                                                       WriteLiteral(Model.GameId);

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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Birgi\GitHub\SDpraktijk3\Competitiemanager\Views\Game\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "C:\Users\Birgi\GitHub\SDpraktijk3\Competitiemanager\Views\Game\Details.cshtml"
Write(Model.HomeTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" vs. ");
#nullable restore
#line 8 "C:\Users\Birgi\GitHub\SDpraktijk3\Competitiemanager\Views\Game\Details.cshtml"
                             Write(Model.AwayTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n<h3>");
#nullable restore
#line 9 "C:\Users\Birgi\GitHub\SDpraktijk3\Competitiemanager\Views\Game\Details.cshtml"
Write(Model.HomeTeam.Team.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>");
#nullable restore
#line 10 "C:\Users\Birgi\GitHub\SDpraktijk3\Competitiemanager\Views\Game\Details.cshtml"
Write(Model.StartDateAndTime.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</ </h3>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Birgi\GitHub\SDpraktijk3\Competitiemanager\Views\Game\Details.cshtml"
 switch (Model.Status)
{
    case 0:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Nog niet gespeeld</p>\r\n");
#nullable restore
#line 16 "C:\Users\Birgi\GitHub\SDpraktijk3\Competitiemanager\Views\Game\Details.cshtml"
        break;
    case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Bezig</p>\r\n        <p>");
#nullable restore
#line 19 "C:\Users\Birgi\GitHub\SDpraktijk3\Competitiemanager\Views\Game\Details.cshtml"
      Write(Model.GoalsHome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 19 "C:\Users\Birgi\GitHub\SDpraktijk3\Competitiemanager\Views\Game\Details.cshtml"
                         Write(Model.GoalsAway);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 20 "C:\Users\Birgi\GitHub\SDpraktijk3\Competitiemanager\Views\Game\Details.cshtml"
        break;
    case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>afgelopen</p>\r\n        <p>");
#nullable restore
#line 23 "C:\Users\Birgi\GitHub\SDpraktijk3\Competitiemanager\Views\Game\Details.cshtml"
      Write(Model.GoalsHome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 23 "C:\Users\Birgi\GitHub\SDpraktijk3\Competitiemanager\Views\Game\Details.cshtml"
                         Write(Model.GoalsAway);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 24 "C:\Users\Birgi\GitHub\SDpraktijk3\Competitiemanager\Views\Game\Details.cshtml"
        break;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Game> Html { get; private set; }
    }
}
#pragma warning restore 1591
