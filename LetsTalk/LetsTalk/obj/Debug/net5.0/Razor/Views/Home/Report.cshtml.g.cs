#pragma checksum "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8f65345e1f57bfe81faee44e8d2af731c245451"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LetsTalk.Views.Home.Views_Home_Report), @"mvc.1.0.view", @"/Views/Home/Report.cshtml")]
namespace LetsTalk.Views.Home
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
#line 1 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\_ViewImports.cshtml"
using LetsTalk;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\_ViewImports.cshtml"
using LetsTalk.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\_ViewImports.cshtml"
using LetsTalk.Extension.Methods;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Report.cshtml"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8f65345e1f57bfe81faee44e8d2af731c245451", @"/Views/Home/Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3896dc6e57a6ead9328b4069e3cfc1f5a0b0acd8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LetsTalk.Dtos.HomeControllerDto.ReportResponseDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("chat-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Report", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8f65345e1f57bfe81faee44e8d2af731c2454514810", async() => {
                WriteLiteral("\r\n    <input type=\"date\" placeholder=\"Data Inicio da busca\" name=\"startDateTimeCut\"/>\r\n    <input type=\"date\" placeholder=\"Data Final da busca\" name=\"endDateTimeCut\"/>\r\n    <button type=\"submit\">Send</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<style>
table {
  font-family: arial, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

td, th {
  border: 1px solid #dddddd;
  text-align: left;
  padding: 8px;
}

tr:nth-child(even) {
  background-color: #dddddd;
}
</style>

");
#nullable restore
#line 28 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Report.cshtml"
 if (Model.totalMessages != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Users Reports</h2>\r\n");
            WriteLiteral(@"    <table>
        <tr>
            <th>Total Messages</th>
            <th>Total Users</th>
            <th>Average Content Length</th>
            <th>Shortest Message Length</th>
            <th>Longest Message Length</th>
            <th>Most Active User Based by Number of Messages</th>
        </tr>
        <tr>
            <td>");
#nullable restore
#line 42 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Report.cshtml"
           Write(Model.totalMessages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Report.cshtml"
           Write(Model.totalUsers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Report.cshtml"
           Write(Model.averageContentLength);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Report.cshtml"
           Write(Model.shotestMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Report.cshtml"
           Write(Model.longestMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 47 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Report.cshtml"
           Write(Model.MostActiveUserByNumberOfMessages.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 50 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Report.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LetsTalk.Dtos.HomeControllerDto.ReportResponseDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
