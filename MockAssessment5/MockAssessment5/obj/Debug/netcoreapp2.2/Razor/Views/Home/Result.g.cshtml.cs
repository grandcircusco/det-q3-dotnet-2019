#pragma checksum "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\MockAssessment5\MockAssessment5\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5ba93b11a4ffb4c1cc92c514cd5152544152569"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Result.cshtml", typeof(AspNetCore.Views_Home_Result))]
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
#line 1 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\MockAssessment5\MockAssessment5\Views\_ViewImports.cshtml"
using MockAssessment5;

#line default
#line hidden
#line 2 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\MockAssessment5\MockAssessment5\Views\_ViewImports.cshtml"
using MockAssessment5.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5ba93b11a4ffb4c1cc92c514cd5152544152569", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45b0228d9ae1e5569378f934e548f383daa9cbd7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\MockAssessment5\MockAssessment5\Views\Home\Result.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
            BeginContext(44, 21, true);
            WriteLiteral("\r\n<h1>Result</h1>\r\n\r\n");
            EndContext();
            BeginContext(66, 14, false);
#line 8 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\MockAssessment5\MockAssessment5\Views\Home\Result.cshtml"
Write(ViewBag.Result);

#line default
#line hidden
            EndContext();
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(83, 17, false);
#line 9 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\MockAssessment5\MockAssessment5\Views\Home\Result.cshtml"
Write(ViewBag.Operation);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591