#pragma checksum "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f545d199876481b0957eb44246a3f5082ac78eb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ViewUser), @"mvc.1.0.view", @"/Views/Admin/ViewUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ViewUser.cshtml", typeof(AspNetCore.Views_Admin_ViewUser))]
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
#line 1 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\_ViewImports.cshtml"
using Global_Intern;

#line default
#line hidden
#line 2 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\_ViewImports.cshtml"
using Global_Intern.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f545d199876481b0957eb44246a3f5082ac78eb1", @"/Views/Admin/ViewUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2e87f1828dfa7ff15070e030324da20917124c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ViewUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Global_Intern.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
  
    ViewData["Title"] = "View User";

#line default
#line hidden
            BeginContext(81, 129, true);
            WriteLiteral("\r\n<h1>View User</h1>\r\n\r\n<div>\r\n    <h4>User</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(211, 42, false);
#line 14 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(253, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(317, 38, false);
#line 17 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(355, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(418, 49, false);
#line 20 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(467, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(531, 45, false);
#line 23 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayFor(model => model.UserFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(576, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(639, 48, false);
#line 26 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserLastName));

#line default
#line hidden
            EndContext();
            BeginContext(687, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(751, 44, false);
#line 29 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayFor(model => model.UserLastName));

#line default
#line hidden
            EndContext();
            BeginContext(795, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(858, 45, false);
#line 32 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserEmail));

#line default
#line hidden
            EndContext();
            BeginContext(903, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(967, 41, false);
#line 35 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayFor(model => model.UserEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1008, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1071, 53, false);
#line 38 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserEmailVerified));

#line default
#line hidden
            EndContext();
            BeginContext(1124, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1188, 49, false);
#line 41 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayFor(model => model.UserEmailVerified));

#line default
#line hidden
            EndContext();
            BeginContext(1237, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1300, 51, false);
#line 44 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserHomeCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1351, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1415, 47, false);
#line 47 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayFor(model => model.UserHomeCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1462, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1525, 54, false);
#line 50 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserCurrentCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1579, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1643, 50, false);
#line 53 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayFor(model => model.UserCurrentCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1693, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1756, 48, false);
#line 56 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserPassword));

#line default
#line hidden
            EndContext();
            BeginContext(1804, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1868, 44, false);
#line 59 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayFor(model => model.UserPassword));

#line default
#line hidden
            EndContext();
            BeginContext(1912, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1975, 45, false);
#line 62 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2020, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2084, 41, false);
#line 65 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayFor(model => model.UserPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2125, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2188, 45, false);
#line 68 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserLinks));

#line default
#line hidden
            EndContext();
            BeginContext(2233, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2297, 41, false);
#line 71 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayFor(model => model.UserLinks));

#line default
#line hidden
            EndContext();
            BeginContext(2338, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2401, 46, false);
#line 74 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayNameFor(model => model.UserGender));

#line default
#line hidden
            EndContext();
            BeginContext(2447, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2511, 42, false);
#line 77 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
       Write(Html.DisplayFor(model => model.UserGender));

#line default
#line hidden
            EndContext();
            BeginContext(2553, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2601, 51, false);
#line 82 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
Write(Html.ActionLink("Edit", "EditUser", new { id = 1 }));

#line default
#line hidden
            EndContext();
            BeginContext(2652, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2661, 43, false);
#line 83 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\ViewUser.cshtml"
Write(Html.ActionLink("Back To List", "UserList"));

#line default
#line hidden
            EndContext();
            BeginContext(2704, 12, true);
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Global_Intern.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
