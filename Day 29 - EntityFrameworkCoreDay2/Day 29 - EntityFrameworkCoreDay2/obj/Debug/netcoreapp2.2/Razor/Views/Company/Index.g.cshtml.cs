#pragma checksum "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 29 - EntityFrameworkCoreDay2\Day 29 - EntityFrameworkCoreDay2\Views\Company\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6e865bcb4b165e019dc8f89f778c32246d0e6be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Index), @"mvc.1.0.view", @"/Views/Company/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Company/Index.cshtml", typeof(AspNetCore.Views_Company_Index))]
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
#line 1 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 29 - EntityFrameworkCoreDay2\Day 29 - EntityFrameworkCoreDay2\Views\_ViewImports.cshtml"
using Day_29___EntityFrameworkCoreDay2;

#line default
#line hidden
#line 2 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 29 - EntityFrameworkCoreDay2\Day 29 - EntityFrameworkCoreDay2\Views\_ViewImports.cshtml"
using Day_29___EntityFrameworkCoreDay2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6e865bcb4b165e019dc8f89f778c32246d0e6be", @"/Views/Company/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d3955d81ffd4c0efb96fd5015bed851061c3961", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Day_29___EntityFrameworkCoreDay2.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 29 - EntityFrameworkCoreDay2\Day 29 - EntityFrameworkCoreDay2\Views\Company\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(113, 206, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>First Name</th>\r\n        <th>Last Name</th>\r\n        <th>Start Date</th>\r\n        <th>End Date</th>\r\n        <th>Department</th>\r\n    </tr>\r\n");
            EndContext();
#line 17 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 29 - EntityFrameworkCoreDay2\Day 29 - EntityFrameworkCoreDay2\Views\Company\Index.cshtml"
     foreach (var employee in Model)
    {

#line default
#line hidden
            BeginContext(364, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(395, 18, false);
#line 20 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 29 - EntityFrameworkCoreDay2\Day 29 - EntityFrameworkCoreDay2\Views\Company\Index.cshtml"
           Write(employee.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(413, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(437, 17, false);
#line 21 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 29 - EntityFrameworkCoreDay2\Day 29 - EntityFrameworkCoreDay2\Views\Company\Index.cshtml"
           Write(employee.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(454, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(478, 38, false);
#line 22 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 29 - EntityFrameworkCoreDay2\Day 29 - EntityFrameworkCoreDay2\Views\Company\Index.cshtml"
           Write(employee.StartDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(516, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(540, 16, false);
#line 23 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 29 - EntityFrameworkCoreDay2\Day 29 - EntityFrameworkCoreDay2\Views\Company\Index.cshtml"
           Write(employee.EndDate);

#line default
#line hidden
            EndContext();
            BeginContext(556, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(580, 21, false);
#line 24 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 29 - EntityFrameworkCoreDay2\Day 29 - EntityFrameworkCoreDay2\Views\Company\Index.cshtml"
           Write(employee.DepartmentId);

#line default
#line hidden
            EndContext();
            BeginContext(601, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(684, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 27 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 29 - EntityFrameworkCoreDay2\Day 29 - EntityFrameworkCoreDay2\Views\Company\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(706, 12, true);
            WriteLiteral("</table>\r\n\r\n");
            EndContext();
            BeginContext(719, 52, false);
#line 30 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 29 - EntityFrameworkCoreDay2\Day 29 - EntityFrameworkCoreDay2\Views\Company\Index.cshtml"
Write(Html.ActionLink("Hire a new guy!", "AddNewEmployee"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Day_29___EntityFrameworkCoreDay2.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
