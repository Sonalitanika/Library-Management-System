#pragma checksum "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\Books\Confim.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26e53f2663af56213981b60fdff10c513802ddc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Confim), @"mvc.1.0.view", @"/Views/Books/Confim.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Books/Confim.cshtml", typeof(AspNetCore.Views_Books_Confim))]
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
#line 1 "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\_ViewImports.cshtml"
using LibrarySystem;

#line default
#line hidden
#line 2 "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\_ViewImports.cshtml"
using LibrarySystem.Models;

#line default
#line hidden
#line 4 "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26e53f2663af56213981b60fdff10c513802ddc1", @"/Views/Books/Confim.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95690a022d89d5e72175b948d3331a5bff59623d", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Confim : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LibrarySystem.Models.CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\Books\Confim.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(93, 28, true);
            WriteLiteral("\r\n<h1>View</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(121, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26e53f2663af56213981b60fdff10c513802ddc14279", async() => {
                BeginContext(144, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(158, 94, true);
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(253, 42, false);
#line 17 "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\Books\Confim.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemId));

#line default
#line hidden
            EndContext();
            BeginContext(295, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(351, 42, false);
#line 20 "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\Books\Confim.cshtml"
           Write(Html.DisplayNameFor(model => model.CartId));

#line default
#line hidden
            EndContext();
            BeginContext(393, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(449, 43, false);
#line 23 "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\Books\Confim.cshtml"
           Write(Html.DisplayNameFor(model => model.Quatity));

#line default
#line hidden
            EndContext();
            BeginContext(492, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(548, 47, false);
#line 26 "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\Books\Confim.cshtml"
           Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(595, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(651, 43, false);
#line 29 "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\Books\Confim.cshtml"
           Write(Html.DisplayNameFor(model => model.BooksID));

#line default
#line hidden
            EndContext();
            BeginContext(694, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\Books\Confim.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(829, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(890, 41, false);
#line 39 "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\Books\Confim.cshtml"
               Write(Html.DisplayFor(modelItem => item.ItemId));

#line default
#line hidden
            EndContext();
            BeginContext(931, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(999, 41, false);
#line 42 "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\Books\Confim.cshtml"
               Write(Html.DisplayFor(modelItem => item.CartId));

#line default
#line hidden
            EndContext();
            BeginContext(1040, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1108, 42, false);
#line 45 "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\Books\Confim.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quatity));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1218, 46, false);
#line 48 "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\Books\Confim.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(1264, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1332, 42, false);
#line 51 "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\Books\Confim.cshtml"
               Write(Html.DisplayFor(modelItem => item.BooksID));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(1550, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 58 "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\Books\Confim.cshtml"
        }

#line default
#line hidden
            BeginContext(1580, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
#line 62 "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\Books\Confim.cshtml"
  
    string ids = null;
    foreach (var item in Model)
    {
        ids += item.ItemId.ToString() + ";";
    }

#line default
#line hidden
            BeginContext(1730, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26e53f2663af56213981b60fdff10c513802ddc111042", async() => {
                BeginContext(1736, 27, true);
                WriteLiteral(" \r\n    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1763, "\"", 1775, 1);
#line 70 "E:\Visual Studio 2017 Project\LibrarySystem\LibrarySystem\Views\Books\Confim.cshtml"
WriteAttributeValue("", 1771, ids, 1771, 4, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1776, 61, true);
                WriteLiteral(" />\r\n    <button type=\"submit\" class=\"btn\">Confirm</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LibrarySystem.Models.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
