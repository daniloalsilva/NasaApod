#pragma checksum "C:\Users\danil\Projects\dotnetcore\RazorProject\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e44f98e91b80b5627e310358e6cf9e883e3bfefd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorProject.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace RazorProject.Pages
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
#line 1 "C:\Users\danil\Projects\dotnetcore\RazorProject\Pages\_ViewImports.cshtml"
using RazorProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e44f98e91b80b5627e310358e6cf9e883e3bfefd", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8382567afa559de7405382da0d3c3fef412971a2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danil\Projects\dotnetcore\RazorProject\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";
    string url = ((dynamic)TempData["NasaData"])["url"];
    var date = (DateTime)(((dynamic)TempData["NasaData"])["date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">This was Nasa Picture of the day, of date ");
#nullable restore
#line 10 "C:\Users\danil\Projects\dotnetcore\RazorProject\Pages\Index.cshtml"
                                                               Write(date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 11 "C:\Users\danil\Projects\dotnetcore\RazorProject\Pages\Index.cshtml"
     foreach (dynamic item in (dynamic)TempData["NasaData"])
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p><b>");
#nullable restore
#line 13 "C:\Users\danil\Projects\dotnetcore\RazorProject\Pages\Index.cshtml"
         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> : ");
#nullable restore
#line 13 "C:\Users\danil\Projects\dotnetcore\RazorProject\Pages\Index.cshtml"
                          Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>   \r\n");
#nullable restore
#line 14 "C:\Users\danil\Projects\dotnetcore\RazorProject\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <img");
            BeginWriteAttribute("src", " src=\"", 462, "\"", 472, 1);
#nullable restore
#line 15 "C:\Users\danil\Projects\dotnetcore\RazorProject\Pages\Index.cshtml"
WriteAttributeValue("", 468, url, 468, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
