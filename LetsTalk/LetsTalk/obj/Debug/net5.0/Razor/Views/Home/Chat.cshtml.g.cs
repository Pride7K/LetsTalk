#pragma checksum "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "809be746d596ca37a8c1e6d49dae342a32ba59db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LetsTalk.Views.Home.Views_Home_Chat), @"mvc.1.0.view", @"/Views/Home/Chat.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"809be746d596ca37a8c1e6d49dae342a32ba59db", @"/Views/Home/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3896dc6e57a6ead9328b4069e3cfc1f5a0b0acd8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chat>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("chat-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("sendMessage(event)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/messageBuilder.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"chat-body\">\r\n");
#nullable restore
#line 4 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Chat.cshtml"
     foreach (var message in Model.Messages)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"message\">\r\n            <header >\r\n                ");
#nullable restore
#line 8 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Chat.cshtml"
           Write(message.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </header>\r\n            <p >\r\n                ");
#nullable restore
#line 11 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Chat.cshtml"
           Write(message.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <footer >\r\n                ");
#nullable restore
#line 14 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Chat.cshtml"
           Write(message.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </footer>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Chat.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "809be746d596ca37a8c1e6d49dae342a32ba59db7310", async() => {
                WriteLiteral("\r\n    <input type=\"text\" name=\"messageBody\" id=\"message-input\"/>\r\n    <input type=\"hidden\"  name=\"roomId\"");
                BeginWriteAttribute("value", " value=\"", 592, "\"", 609, 1);
#nullable restore
#line 22 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Chat.cshtml"
WriteAttributeValue("", 600, Model.Id, 600, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    <button type=\"submit\">Send</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "809be746d596ca37a8c1e6d49dae342a32ba59db9773", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "809be746d596ca37a8c1e6d49dae342a32ba59db10872", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        var connection = new signalR.HubConnectionBuilder()
        .withUrl(""/chatHub"").build();
        
        var _connectionId = """";
        
        
        connection.on(""RecieveMessage"", function(data) {
           var message =   messageBuilder()
           .createMessage()
           .withHeader(data.name)
           .withParagraph(data.text)
           .withFooter(data.createdAt)
           .build()
            
            
            var body = document.querySelector("".chat-body"")
        
            body.append(message);
        })
       
        
        connection.start().then(function() {
          connection.invoke(""joinRoom"",""");
#nullable restore
#line 53 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Chat.cshtml"
                                   Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\")\r\n        }).catch(function(err) {\r\n          console.log(err)\r\n        });\r\n        \r\n        $(window).on(\'beforeunload\', function() {\r\n          \r\n           connection.invoke(\'leaveRoom\', \'");
#nullable restore
#line 60 "C:\Users\gsantos\OneDrive - VIA Consulting\Desktop\doneByMyself\LetsTalk\LetsTalk\Views\Home\Chat.cshtml"
                                      Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"');
        });
        
        
               
        var sendMessage = function(event) {
          event.preventDefault();
         

          var data = new FormData(event.target);
          
          var messageInput = document.getElementById(""message-input"")
          
          messageInput.value = """";
          
          axios.post(""/Chat/SendMessage"",data).then(function() {
              
          }).catch(function() {
            
          })
        }
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chat> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
