#pragma checksum "C:\Users\SShinde\Desktop\ProjectWork\GitDesignPattern\Learning-ASPNET-Core-MVC\ExploreCalifornia\ExploreCalifornia\Views\Blog\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "301e602c0b4e3356a41759b8e0f78b8634a4aaf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Post), @"mvc.1.0.view", @"/Views/Blog/Post.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"301e602c0b4e3356a41759b8e0f78b8634a4aaf6", @"/Views/Blog/Post.cshtml")]
    public class Views_Blog_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\SShinde\Desktop\ProjectWork\GitDesignPattern\Learning-ASPNET-Core-MVC\ExploreCalifornia\ExploreCalifornia\Views\Blog\Post.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Post";

#line default
#line hidden
#nullable disable
            WriteLiteral("<article class=\"blog-post\">\r\n    <h1>");
#nullable restore
#line 7 "C:\Users\SShinde\Desktop\ProjectWork\GitDesignPattern\Learning-ASPNET-Core-MVC\ExploreCalifornia\ExploreCalifornia\Views\Blog\Post.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"details\">\r\n        Posted : <span>");
#nullable restore
#line 9 "C:\Users\SShinde\Desktop\ProjectWork\GitDesignPattern\Learning-ASPNET-Core-MVC\ExploreCalifornia\ExploreCalifornia\Views\Blog\Post.cshtml"
                  Write(ViewBag.Posted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> by \r\n        <span>");
#nullable restore
#line 10 "C:\Users\SShinde\Desktop\ProjectWork\GitDesignPattern\Learning-ASPNET-Core-MVC\ExploreCalifornia\ExploreCalifornia\Views\Blog\Post.cshtml"
         Write(ViewBag.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n    <div class=\"content\">\r\n        ");
#nullable restore
#line 13 "C:\Users\SShinde\Desktop\ProjectWork\GitDesignPattern\Learning-ASPNET-Core-MVC\ExploreCalifornia\ExploreCalifornia\Views\Blog\Post.cshtml"
   Write(ViewBag.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</article>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
