#pragma checksum "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Forum\DisplayThread.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3656f943f2bf95bac60f85bae24c589acbf9ad87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_DisplayThread), @"mvc.1.0.view", @"/Views/Forum/DisplayThread.cshtml")]
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
#line 1 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\_ViewImports.cshtml"
using VetAppointment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\_ViewImports.cshtml"
using VetAppointment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3656f943f2bf95bac60f85bae24c589acbf9ad87", @"/Views/Forum/DisplayThread.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"780a22457cf630240fc7e2415b721d2005da3b26", @"/Views/_ViewImports.cshtml")]
    public class Views_Forum_DisplayThread : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ForumModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Forum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Forum\DisplayThread.cshtml"
  
    ViewData["Title"] = "Pytanie";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Pytanie</h1>\r\n<div class=\"card mb-3 border border-primary\">\r\n    <div class=\"card-header\">\r\n        <h5 class=\"card-title\"> ");
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Forum\DisplayThread.cshtml"
                           Write(Html.DisplayFor(model => model.Entry.EntryBody));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <div class=\"card-text\">");
#nullable restore
#line 10 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Forum\DisplayThread.cshtml"
                          Write(Html.DisplayFor(model => model.Entry.Author.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Forum\DisplayThread.cshtml"
                                                                             Write(Html.DisplayFor(model => model.Entry.Author.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral(" [");
#nullable restore
#line 10 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Forum\DisplayThread.cshtml"
                                                                                                                                    Write(Html.DisplayFor(model => model.Entry.Author.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("]</div>\r\n        <div class=\"card-text\">");
#nullable restore
#line 11 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Forum\DisplayThread.cshtml"
                          Write(Html.DisplayFor(model => model.Entry.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n        <div>\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<h2>Odpowiedzi</h2>\r\n");
#nullable restore
#line 19 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Forum\DisplayThread.cshtml"
 foreach (var entry in Model.Entries)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card mb-3\">\r\n        <div class=\"card-header\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 23 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Forum\DisplayThread.cshtml"
                              Write(entry.EntryBody);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <div class=\"card-text\">");
#nullable restore
#line 24 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Forum\DisplayThread.cshtml"
                              Write(entry.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Forum\DisplayThread.cshtml"
                                                 Write(entry.Author.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" [");
#nullable restore
#line 24 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Forum\DisplayThread.cshtml"
                                                                        Write(entry.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("]</div>\r\n            <div class=\"card-text\">");
#nullable restore
#line 25 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Forum\DisplayThread.cshtml"
                              Write(entry.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 30 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Forum\DisplayThread.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-group\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3656f943f2bf95bac60f85bae24c589acbf9ad878208", async() => {
                WriteLiteral("Powrót");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForumModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
