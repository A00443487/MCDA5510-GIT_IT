#pragma checksum "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Admin\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51464b1958443fdd0ae5a9eaf9e7ef914b6f641a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Profile), @"mvc.1.0.view", @"/Views/Admin/Profile.cshtml")]
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
#line 1 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\_ViewImports.cshtml"
using HRP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\_ViewImports.cshtml"
using HRP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51464b1958443fdd0ae5a9eaf9e7ef914b6f641a", @"/Views/Admin/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d97a09a4067066ac9300b6a10ea6ebc1de3e30", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Admin>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Admin\Profile.cshtml"
  

    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    var title = "Admin Profile";
    ViewData["Title"] = title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <section>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51464b1958443fdd0ae5a9eaf9e7ef914b6f641a4782", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 18 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Admin\Profile.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                <h4>Admin Log In.</h4>\r\n                <hr />\r\n\r\n                ");
#nullable restore
#line 23 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Admin\Profile.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 27 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Admin\Profile.cshtml"
               Write(Html.LabelFor(m => m.sin, new { @class = "col-md-8 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 29 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Admin\Profile.cshtml"
                   Write(Html.TextBoxFor(m => m.sin, new { @class = "form-control", id = "sin", @readonly = "readonly", autofocus = "", value = Model.sin }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 36 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Admin\Profile.cshtml"
               Write(Html.LabelFor(m => m.username, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 38 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Admin\Profile.cshtml"
                   Write(Html.TextBoxFor(m => m.username, new { @class = "form-control", id = "username", @readonly = "readonly", value = Model.username }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 44 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Admin\Profile.cshtml"
               Write(Html.LabelFor(m => m.password, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 46 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Admin\Profile.cshtml"
                   Write(Html.ActionLink("Update Password", "PasswordUpdate", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                    </div>\r\n                </div>\r\n           \r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </section>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Admin> Html { get; private set; }
    }
}
#pragma warning restore 1591
