#pragma checksum "C:\Users\natthaphonk\Desktop\ProjectMaster_26\WebApplication\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c46b969fc9904c6f8b477d1f6daa5bc69de7032"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "C:\Users\natthaphonk\Desktop\ProjectMaster_26\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natthaphonk\Desktop\ProjectMaster_26\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c46b969fc9904c6f8b477d1f6daa5bc69de7032", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.Models.DepartmentModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/apps/HomeController.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\natthaphonk\Desktop\ProjectMaster_26\WebApplication\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";
    var h = "Test Javasript at Privacy :" + " ";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\natthaphonk\Desktop\ProjectMaster_26\WebApplication\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Use this page to detail your site\'s privacy policy.</p>\r\n\r\n\r\n\r\n\r\n<div ng-controller=\"HomeController\">\r\n    <p>\r\n        Department Name: ");
#nullable restore
#line 15 "C:\Users\natthaphonk\Desktop\ProjectMaster_26\WebApplication\Views\Home\Privacy.cshtml"
                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 15 "C:\Users\natthaphonk\Desktop\ProjectMaster_26\WebApplication\Views\Home\Privacy.cshtml"
                                 Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(")<br />\r\n        Total Age: ");
#nullable restore
#line 16 "C:\Users\natthaphonk\Desktop\ProjectMaster_26\WebApplication\Views\Home\Privacy.cshtml"
              Write(Model.SumAge);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\natthaphonk\Desktop\ProjectMaster_26\WebApplication\Views\Home\Privacy.cshtml"
         foreach (var emp in Model.Employees)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <hr />\r\n            <h>");
#nullable restore
#line 20 "C:\Users\natthaphonk\Desktop\ProjectMaster_26\WebApplication\Views\Home\Privacy.cshtml"
          Write(h);

#line default
#line hidden
#nullable disable
            WriteLiteral(" {{text}}</h>\r\n            <hr/>\r\n            <div>\r\n                En: ");
#nullable restore
#line 23 "C:\Users\natthaphonk\Desktop\ProjectMaster_26\WebApplication\Views\Home\Privacy.cshtml"
               Write(emp.En);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                Name: ");
#nullable restore
#line 24 "C:\Users\natthaphonk\Desktop\ProjectMaster_26\WebApplication\Views\Home\Privacy.cshtml"
                 Write(emp.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                Department: ");
#nullable restore
#line 25 "C:\Users\natthaphonk\Desktop\ProjectMaster_26\WebApplication\Views\Home\Privacy.cshtml"
                       Write(emp.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                Age: ");
#nullable restore
#line 26 "C:\Users\natthaphonk\Desktop\ProjectMaster_26\WebApplication\Views\Home\Privacy.cshtml"
                Write(emp.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 28 "C:\Users\natthaphonk\Desktop\ProjectMaster_26\WebApplication\Views\Home\Privacy.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </p>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c46b969fc9904c6f8b477d1f6daa5bc69de70326943", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.Models.DepartmentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
