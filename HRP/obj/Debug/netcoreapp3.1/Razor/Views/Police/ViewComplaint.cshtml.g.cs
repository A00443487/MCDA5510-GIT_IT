#pragma checksum "E:\SMU\Github\InfoTech-Software\HRP\Views\Police\ViewComplaint.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c4d6619d07dbd12a70b55a0b1a23e960e734615"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Police_ViewComplaint), @"mvc.1.0.view", @"/Views/Police/ViewComplaint.cshtml")]
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
#nullable restore
#line 1 "E:\SMU\Github\InfoTech-Software\HRP\Views\_ViewImports.cshtml"
using HRP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SMU\Github\InfoTech-Software\HRP\Views\_ViewImports.cshtml"
using HRP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c4d6619d07dbd12a70b55a0b1a23e960e734615", @"/Views/Police/ViewComplaint.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d97a09a4067066ac9300b6a10ea6ebc1de3e30", @"/Views/_ViewImports.cshtml")]
    public class Views_Police_ViewComplaint : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Complaints>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "E:\SMU\Github\InfoTech-Software\HRP\Views\Police\ViewComplaint.cshtml"
   

    Layout = "~/views/shared/_PoliceLayout.cshtml";
    var title = "View Complaints";
    ViewData["Title"] = title;


#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n<h2>");
#nullable restore
#line 13 "E:\SMU\Github\InfoTech-Software\HRP\Views\Police\ViewComplaint.cshtml"
Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2>

              <table class=""table table-bordered table-sm table-striped"">

                  <thead>
                      <tr>
                          <th>
                              Complaint Id
                          </th>
                          <th>
                              Complaint Description
                          </th>
                          <th>
                              Status Id
                          </th>
                      </tr>
                  </thead>

");
#nullable restore
#line 31 "E:\SMU\Github\InfoTech-Software\HRP\Views\Police\ViewComplaint.cshtml"
                   if (Model == null)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                      <tr>
                          <td>
                              Complaint Id
                          </td>
                          <td>
                              Complaint Description
                          </td>
                          <td>
                              Status Id
                          </td>
                      </tr>
");
#nullable restore
#line 44 "E:\SMU\Github\InfoTech-Software\HRP\Views\Police\ViewComplaint.cshtml"

                  }
                  else
                  {
                      

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "E:\SMU\Github\InfoTech-Software\HRP\Views\Police\ViewComplaint.cshtml"
                       foreach (var p in Model)
                      {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                          <tr>
                              <td>
                                  p.id
                              </td>
                              <td>
                                  p.description
                              </td>
                              <td>
                                  p.status_id
                              </td>
                          </tr>
");
#nullable restore
#line 61 "E:\SMU\Github\InfoTech-Software\HRP\Views\Police\ViewComplaint.cshtml"

                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "E:\SMU\Github\InfoTech-Software\HRP\Views\Police\ViewComplaint.cshtml"
                       
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Complaints>> Html { get; private set; }
    }
}
#pragma warning restore 1591
