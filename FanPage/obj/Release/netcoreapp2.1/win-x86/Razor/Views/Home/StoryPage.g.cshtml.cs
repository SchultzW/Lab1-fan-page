#pragma checksum "C:\Users\wills\OneDrive\Desktop\School\Fall 2019\ASP .NET\Lab 1\FanPage\FanPage\Views\Home\StoryPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "604e156977f12e837dac695935c15261307968ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StoryPage), @"mvc.1.0.view", @"/Views/Home/StoryPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/StoryPage.cshtml", typeof(AspNetCore.Views_Home_StoryPage))]
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
#line 1 "C:\Users\wills\OneDrive\Desktop\School\Fall 2019\ASP .NET\Lab 1\FanPage\FanPage\Views\_ViewImports.cshtml"
using FanPage;

#line default
#line hidden
#line 2 "C:\Users\wills\OneDrive\Desktop\School\Fall 2019\ASP .NET\Lab 1\FanPage\FanPage\Views\_ViewImports.cshtml"
using FanPage.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"604e156977f12e837dac695935c15261307968ba", @"/Views/Home/StoryPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0d8ea382d61d21666e4f120acbe07b52077593", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StoryPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<String>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("story-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\wills\OneDrive\Desktop\School\Fall 2019\ASP .NET\Lab 1\FanPage\FanPage\Views\Home\StoryPage.cshtml"
  
    ViewBag.Title = "Read a Story";
    Layout = "~/Views/Shared/_Header.cshtml";
    Story s = StoryRepo.GetStoryByTitle(Model);

#line default
#line hidden
            BeginContext(157, 56, true);
            WriteLiteral("\r\n\r\n\r\n\r\n    <div class=\"story-form\">\r\n        <p> Title:");
            EndContext();
            BeginContext(214, 7, false);
#line 13 "C:\Users\wills\OneDrive\Desktop\School\Fall 2019\ASP .NET\Lab 1\FanPage\FanPage\Views\Home\StoryPage.cshtml"
             Write(s.Title);

#line default
#line hidden
            EndContext();
            BeginContext(221, 25, true);
            WriteLiteral("</p>\r\n        <p>Author: ");
            EndContext();
            BeginContext(247, 8, false);
#line 14 "C:\Users\wills\OneDrive\Desktop\School\Fall 2019\ASP .NET\Lab 1\FanPage\FanPage\Views\Home\StoryPage.cshtml"
              Write(s.Writer);

#line default
#line hidden
            EndContext();
            BeginContext(255, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(273, 11, false);
#line 15 "C:\Users\wills\OneDrive\Desktop\School\Fall 2019\ASP .NET\Lab 1\FanPage\FanPage\Views\Home\StoryPage.cshtml"
      Write(s.StoryText);

#line default
#line hidden
            EndContext();
            BeginContext(284, 22, true);
            WriteLiteral("</p>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(306, 630, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09d953d0b0ae40c7b463aee063c48372", async() => {
                BeginContext(345, 584, true);
                WriteLiteral(@"
        <div class=""form-control"">
            <label for=""commentText"">Write a comment: </label>
            <textarea name=""commentText"" rows=""6"" cols=""50""></textarea>
        </div>
        <div class=""form-control"">
            <label for=""User"" name=""user"">Name: </label>
            <input for=""User"" name=""user"" />
        </div>
        <div class=""form-control"">
            <label for=""rating"">Rate the story: </label>
            <input for=""rating"" name=""rating"" /> out of 5
         </div>
            <button class=""btn"" type=""submit"">Submit</button>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(936, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<String> Html { get; private set; }
    }
}
#pragma warning restore 1591
