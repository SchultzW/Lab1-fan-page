#pragma checksum "C:\Users\wills\OneDrive\Desktop\School\Fall 2019\ASP .NET\Lab 1\FanPage\FanPage\Views\Sources\Media.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddc377631f52231a436f1d6b9c1b380be4433725"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sources_Media), @"mvc.1.0.view", @"/Views/Sources/Media.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sources/Media.cshtml", typeof(AspNetCore.Views_Sources_Media))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddc377631f52231a436f1d6b9c1b380be4433725", @"/Views/Sources/Media.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0d8ea382d61d21666e4f120acbe07b52077593", @"/Views/_ViewImports.cshtml")]
    public class Views_Sources_Media : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Media>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\wills\OneDrive\Desktop\School\Fall 2019\ASP .NET\Lab 1\FanPage\FanPage\Views\Sources\Media.cshtml"
  
    Layout = "~/Views/Shared/_Header.cshtml";
    ViewBag.Title = "Books and Media";

#line default
#line hidden
            BeginContext(116, 171, true);
            WriteLiteral("\r\n\r\n<p h3>\r\n    Junebug is a very prolifent writer. She has written over 100 books, most of which have won awards!\r\n    Have a look at her selected work below!\r\n</p>\r\n\r\n\r\n");
            EndContext();
#line 15 "C:\Users\wills\OneDrive\Desktop\School\Fall 2019\ASP .NET\Lab 1\FanPage\FanPage\Views\Sources\Media.cshtml"
 foreach (FanPage.Models.Media m in Model)
{

#line default
#line hidden
            BeginContext(334, 41, true);
            WriteLiteral("<div class=\"text\">\r\n    <p>\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 375, "\"", 393, 1);
#line 19 "C:\Users\wills\OneDrive\Desktop\School\Fall 2019\ASP .NET\Lab 1\FanPage\FanPage\Views\Sources\Media.cshtml"
WriteAttributeValue("", 381, m.ImagePath, 381, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 394, "\"", 408, 1);
#line 19 "C:\Users\wills\OneDrive\Desktop\School\Fall 2019\ASP .NET\Lab 1\FanPage\FanPage\Views\Sources\Media.cshtml"
WriteAttributeValue("", 400, m.Title, 400, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(409, 40, true);
            WriteLiteral(" class=\"book-img\">\r\n        <div>Title: ");
            EndContext();
            BeginContext(450, 7, false);
#line 20 "C:\Users\wills\OneDrive\Desktop\School\Fall 2019\ASP .NET\Lab 1\FanPage\FanPage\Views\Sources\Media.cshtml"
               Write(m.Title);

#line default
#line hidden
            EndContext();
            BeginContext(457, 34, true);
            WriteLiteral(" </div>\r\n        <div>Media Type: ");
            EndContext();
            BeginContext(492, 6, false);
#line 21 "C:\Users\wills\OneDrive\Desktop\School\Fall 2019\ASP .NET\Lab 1\FanPage\FanPage\Views\Sources\Media.cshtml"
                    Write(m.Type);

#line default
#line hidden
            EndContext();
            BeginContext(498, 34, true);
            WriteLiteral("</div>\r\n        <div>Description: ");
            EndContext();
            BeginContext(533, 13, false);
#line 22 "C:\Users\wills\OneDrive\Desktop\School\Fall 2019\ASP .NET\Lab 1\FanPage\FanPage\Views\Sources\Media.cshtml"
                     Write(m.Description);

#line default
#line hidden
            EndContext();
            BeginContext(546, 26, true);
            WriteLiteral("</div>\r\n    </p>\r\n</div>\r\n");
            EndContext();
#line 25 "C:\Users\wills\OneDrive\Desktop\School\Fall 2019\ASP .NET\Lab 1\FanPage\FanPage\Views\Sources\Media.cshtml"
}

#line default
#line hidden
            BeginContext(575, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Media>> Html { get; private set; }
    }
}
#pragma warning restore 1591
