#pragma checksum "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 26 - ModelValidation\Day 26 - ModelValidation\Views\Movie\DisplayMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84f672b35c6384029900a4da2e36df04864c1b58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_DisplayMovie), @"mvc.1.0.view", @"/Views/Movie/DisplayMovie.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/DisplayMovie.cshtml", typeof(AspNetCore.Views_Movie_DisplayMovie))]
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
#line 1 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 26 - ModelValidation\Day 26 - ModelValidation\Views\_ViewImports.cshtml"
using Day_26___ModelValidation;

#line default
#line hidden
#line 2 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 26 - ModelValidation\Day 26 - ModelValidation\Views\_ViewImports.cshtml"
using Day_26___ModelValidation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84f672b35c6384029900a4da2e36df04864c1b58", @"/Views/Movie/DisplayMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"259239bd356b3cab9ab6a82c70c625789caaaac7", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_DisplayMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Day_26___ModelValidation.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 26 - ModelValidation\Day 26 - ModelValidation\Views\Movie\DisplayMovie.cshtml"
  
    ViewData["Title"] = "DisplayMovie";

#line default
#line hidden
            BeginContext(50, 26, true);
            WriteLiteral("\r\n<h1>Display Movie</h1>\r\n");
            EndContext();
            BeginContext(122, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(128, 11, false);
#line 9 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 26 - ModelValidation\Day 26 - ModelValidation\Views\Movie\DisplayMovie.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(139, 8, true);
            WriteLiteral("</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Day_26___ModelValidation.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591