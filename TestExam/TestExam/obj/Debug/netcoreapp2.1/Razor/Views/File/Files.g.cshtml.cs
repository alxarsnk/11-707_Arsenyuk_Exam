#pragma checksum "\\Mac\Home\Desktop\GitHubProject\11-707_Arsenyuk_Exam\TestExam\TestExam\Views\File\Files.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa738faaaf185d3264982d729c34834edd85ffb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_File_Files), @"mvc.1.0.view", @"/Views/File/Files.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/File/Files.cshtml", typeof(AspNetCore.Views_File_Files))]
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
#line 1 "\\Mac\Home\Desktop\GitHubProject\11-707_Arsenyuk_Exam\TestExam\TestExam\Views\_ViewImports.cshtml"
using TestExam;

#line default
#line hidden
#line 2 "\\Mac\Home\Desktop\GitHubProject\11-707_Arsenyuk_Exam\TestExam\TestExam\Views\_ViewImports.cshtml"
using TestExam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa738faaaf185d3264982d729c34834edd85ffb6", @"/Views/File/Files.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9ddf3ddd12c80944bd99c9bb6b35e925ec2bed2", @"/Views/_ViewImports.cshtml")]
    public class Views_File_Files : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestExam.Models.File>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/File/AddFile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "\\Mac\Home\Desktop\GitHubProject\11-707_Arsenyuk_Exam\TestExam\TestExam\Views\File\Files.cshtml"
  
    ViewData["Title"] = "Files";

#line default
#line hidden
            BeginContext(83, 20, true);
            WriteLiteral("\r\n<h2>Files</h2>\r\n\r\n");
            EndContext();
            BeginContext(103, 496, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cc6078a5b9042e1a9fa805b73fe7aca", async() => {
                BeginContext(109, 37, true);
                WriteLiteral("\r\n    \r\n    <h3>Ваши файлы</h3>\r\n    ");
                EndContext();
                BeginContext(146, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a230bc0157b04dbc809dc391030a5dee", async() => {
                    BeginContext(171, 13, true);
                    WriteLiteral("Добавить файл");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(188, 127, true);
                WriteLiteral("\r\n    <table>\r\n        <tr>\r\n            <td>Имя </td>\r\n            <td>Описание</td>\r\n\r\n            <td></td>\r\n        </tr>\r\n");
                EndContext();
#line 19 "\\Mac\Home\Desktop\GitHubProject\11-707_Arsenyuk_Exam\TestExam\TestExam\Views\File\Files.cshtml"
         foreach (var file in Model)
        {

#line default
#line hidden
                BeginContext(364, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(403, 9, false);
#line 22 "\\Mac\Home\Desktop\GitHubProject\11-707_Arsenyuk_Exam\TestExam\TestExam\Views\File\Files.cshtml"
               Write(file.Name);

#line default
#line hidden
                EndContext();
                BeginContext(412, 29, true);
                WriteLiteral(" +</td>\r\n                <td>");
                EndContext();
                BeginContext(442, 21, false);
#line 23 "\\Mac\Home\Desktop\GitHubProject\11-707_Arsenyuk_Exam\TestExam\TestExam\Views\File\Files.cshtml"
               Write(file.ShortDescription);

#line default
#line hidden
                EndContext();
                BeginContext(463, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(490, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8342843982c14aba9184d7b11ce4add3", async() => {
                    BeginContext(529, 7, true);
                    WriteLiteral("Скачать");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 499, "~/File/Download/?id=", 499, 20, true);
#line 24 "\\Mac\Home\Desktop\GitHubProject\11-707_Arsenyuk_Exam\TestExam\TestExam\Views\File\Files.cshtml"
AddHtmlAttributeValue("", 519, file.Id, 519, 8, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(540, 26, true);
                WriteLiteral("</td>\r\n            </tr>\r\n");
                EndContext();
#line 26 "\\Mac\Home\Desktop\GitHubProject\11-707_Arsenyuk_Exam\TestExam\TestExam\Views\File\Files.cshtml"
        }

#line default
#line hidden
                BeginContext(577, 15, true);
                WriteLiteral("    </table>\r\n ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestExam.Models.File>> Html { get; private set; }
    }
}
#pragma warning restore 1591
