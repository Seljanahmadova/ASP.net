#pragma checksum "D:\Asp.net\FronttoBack\Views\Shared\_ProductPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "896ccceb29efc7d8d6f4cc05e93caa2e6902a813"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductPartialView), @"mvc.1.0.view", @"/Views/Shared/_ProductPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ProductPartialView.cshtml", typeof(AspNetCore.Views_Shared__ProductPartialView))]
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
#line 1 "D:\Asp.net\FronttoBack\Views\_ViewImports.cshtml"
using FronttoBack.Models;

#line default
#line hidden
#line 2 "D:\Asp.net\FronttoBack\Views\_ViewImports.cshtml"
using FronttoBack.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"896ccceb29efc7d8d6f4cc05e93caa2e6902a813", @"/Views/Shared/_ProductPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68852c0f95d4ed7acf27ec0d495487b873e9e8e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Asp.net\FronttoBack\Views\Shared\_ProductPartialView.cshtml"
 foreach (ProductVM product in Model)
{

#line default
#line hidden
            BeginContext(75, 106, true);
            WriteLiteral("    <div class=\"col-sm-6 col-md-4 col-lg-3 mt-3\">\r\n        <div class=\"product-item text-center\" data-id=\"");
            EndContext();
            BeginContext(182, 31, false);
#line 6 "D:\Asp.net\FronttoBack\Views\Shared\_ProductPartialView.cshtml"
                                                  Write(product.Category.Name.ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(213, 84, true);
            WriteLiteral("\">\r\n            <div class=\"img\">\r\n                <a href=\"\">\r\n                    ");
            EndContext();
            BeginContext(297, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a0921d5eb6fc43f69f3558f3be934c92", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 307, "~/img/", 307, 6, true);
#line 9 "D:\Asp.net\FronttoBack\Views\Shared\_ProductPartialView.cshtml"
AddHtmlAttributeValue("", 313, product.Image, 313, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(354, 102, true);
            WriteLiteral("\r\n                </a>\r\n            </div>\r\n            <div class=\"title mt-3\">\r\n                <h6>");
            EndContext();
            BeginContext(457, 13, false);
#line 13 "D:\Asp.net\FronttoBack\Views\Shared\_ProductPartialView.cshtml"
               Write(product.Title);

#line default
#line hidden
            EndContext();
            BeginContext(470, 170, true);
            WriteLiteral("</h6>\r\n            </div>\r\n            <div class=\"price\">\r\n                <span class=\"text-black-50\">Add to cart</span>\r\n                <span class=\"text-black-50\">$ ");
            EndContext();
            BeginContext(641, 13, false);
#line 17 "D:\Asp.net\FronttoBack\Views\Shared\_ProductPartialView.cshtml"
                                         Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(654, 57, true);
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 21 "D:\Asp.net\FronttoBack\Views\Shared\_ProductPartialView.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
