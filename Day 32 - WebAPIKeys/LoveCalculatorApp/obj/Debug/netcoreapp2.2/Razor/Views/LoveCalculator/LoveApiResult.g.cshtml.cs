#pragma checksum "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 32 - WebAPIKeys\LoveCalculatorApp\Views\LoveCalculator\LoveApiResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58b1dabac9cdcc5896ae835c61b658f8b7b7ab18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoveCalculator_LoveApiResult), @"mvc.1.0.view", @"/Views/LoveCalculator/LoveApiResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LoveCalculator/LoveApiResult.cshtml", typeof(AspNetCore.Views_LoveCalculator_LoveApiResult))]
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
#line 1 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 32 - WebAPIKeys\LoveCalculatorApp\Views\_ViewImports.cshtml"
using LoveCalculatorApp;

#line default
#line hidden
#line 2 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 32 - WebAPIKeys\LoveCalculatorApp\Views\_ViewImports.cshtml"
using LoveCalculatorApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58b1dabac9cdcc5896ae835c61b658f8b7b7ab18", @"/Views/LoveCalculator/LoveApiResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90983d476ba9ae826bd25103f7991a78fb508f97", @"/Views/_ViewImports.cshtml")]
    public class Views_LoveCalculator_LoveApiResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoveCalculatorApp.Models.LoveCalculator>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 32 - WebAPIKeys\LoveCalculatorApp\Views\LoveCalculator\LoveApiResult.cshtml"
  
    ViewData["Title"] = "LoveApiResult";

#line default
#line hidden
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(101, 30, true);
            WriteLiteral("\r\n<h1>Love Api Result</h1>\r\n\r\n");
            EndContext();
            BeginContext(132, 11, false);
#line 10 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 32 - WebAPIKeys\LoveCalculatorApp\Views\LoveCalculator\LoveApiResult.cshtml"
Write(Model.Fname);

#line default
#line hidden
            EndContext();
            BeginContext(143, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(149, 11, false);
#line 10 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 32 - WebAPIKeys\LoveCalculatorApp\Views\LoveCalculator\LoveApiResult.cshtml"
            Write(Model.Sname);

#line default
#line hidden
            EndContext();
            BeginContext(160, 5, true);
            WriteLiteral(" are ");
            EndContext();
            BeginContext(166, 16, false);
#line 10 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 32 - WebAPIKeys\LoveCalculatorApp\Views\LoveCalculator\LoveApiResult.cshtml"
                             Write(Model.Percentage);

#line default
#line hidden
            EndContext();
            BeginContext(182, 16, true);
            WriteLiteral(" Compatible.\r\n\r\n");
            EndContext();
            BeginContext(199, 12, false);
#line 12 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 32 - WebAPIKeys\LoveCalculatorApp\Views\LoveCalculator\LoveApiResult.cshtml"
Write(Model.Result);

#line default
#line hidden
            EndContext();
            BeginContext(211, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoveCalculatorApp.Models.LoveCalculator> Html { get; private set; }
    }
}
#pragma warning restore 1591