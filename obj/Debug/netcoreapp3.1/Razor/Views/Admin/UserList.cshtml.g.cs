#pragma checksum "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "203b16e71e2f812e3774a5f252f4a34b830f0e0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserList), @"mvc.1.0.view", @"/Views/Admin/UserList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/UserList.cshtml", typeof(AspNetCore.Views_Admin_UserList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"203b16e71e2f812e3774a5f252f4a34b830f0e0f", @"/Views/Admin/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2e87f1828dfa7ff15070e030324da20917124c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Global_Intern.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
  
    ViewData["Title"] = "UserList";

#line default
#line hidden
            BeginContext(93, 32, true);
            WriteLiteral("\r\n<h1>UserList</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(125, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "203b16e71e2f812e3774a5f252f4a34b830f0e0f3865", async() => {
                BeginContext(148, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(162, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(255, 42, false);
#line 16 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(297, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(353, 49, false);
#line 19 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.DisplayNameFor(model => model.UserFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(402, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(458, 48, false);
#line 22 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.DisplayNameFor(model => model.UserLastName));

#line default
#line hidden
            EndContext();
            BeginContext(506, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(562, 45, false);
#line 25 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.DisplayNameFor(model => model.UserEmail));

#line default
#line hidden
            EndContext();
            BeginContext(607, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(663, 53, false);
#line 28 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.DisplayNameFor(model => model.UserEmailVerified));

#line default
#line hidden
            EndContext();
            BeginContext(716, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(772, 51, false);
#line 31 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.DisplayNameFor(model => model.UserHomeCountry));

#line default
#line hidden
            EndContext();
            BeginContext(823, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(879, 54, false);
#line 34 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.DisplayNameFor(model => model.UserCurrentCountry));

#line default
#line hidden
            EndContext();
            BeginContext(933, 67, true);
            WriteLiteral("\r\n            </th>\r\n          \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1001, 45, false);
#line 38 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.DisplayNameFor(model => model.UserPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1046, 68, true);
            WriteLiteral("\r\n            </th>\r\n           \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1115, 46, false);
#line 42 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.DisplayNameFor(model => model.UserGender));

#line default
#line hidden
            EndContext();
            BeginContext(1161, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 48 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1279, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1328, 41, false);
#line 51 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(1369, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1425, 48, false);
#line 54 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1473, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1529, 47, false);
#line 57 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserLastName));

#line default
#line hidden
            EndContext();
            BeginContext(1576, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1632, 44, false);
#line 60 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1676, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1732, 52, false);
#line 63 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserEmailVerified));

#line default
#line hidden
            EndContext();
            BeginContext(1784, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1840, 50, false);
#line 66 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserHomeCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1890, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1946, 53, false);
#line 69 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserCurrentCountry));

#line default
#line hidden
            EndContext();
            BeginContext(1999, 67, true);
            WriteLiteral("\r\n            </td>\r\n          \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2067, 44, false);
#line 73 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2111, 65, true);
            WriteLiteral("\r\n            </td>\r\n        \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2177, 45, false);
#line 77 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserGender));

#line default
#line hidden
            EndContext();
            BeginContext(2222, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2278, 65, false);
#line 80 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2343, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2364, 50, false);
#line 81 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.ActionLink("Details", "ViewUser", new {id=1}));

#line default
#line hidden
            EndContext();
            BeginContext(2414, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2435, 69, false);
#line 82 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2504, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 85 "C:\Users\ashly\Source\Repos\Techexpozed-Global\Global_Intern\Views\Admin\UserList.cshtml"
}

#line default
#line hidden
            BeginContext(2543, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Global_Intern.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
