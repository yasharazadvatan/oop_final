#pragma checksum "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6380b339a827f202892372114e6add38c1322fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_MyConselors), @"mvc.1.0.view", @"/Views/Students/MyConselors.cshtml")]
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
#line 1 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\_ViewImports.cshtml"
using gis_final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\_ViewImports.cshtml"
using gis_final.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6380b339a827f202892372114e6add38c1322fb", @"/Views/Students/MyConselors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e52aa07f67b8aeecf4d0e15efb533e891e5bb93f", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_MyConselors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<gis_final.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
  
    ViewData["Title"] = "MyConselors";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>My Conselors</h1>\r\n \r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
           Write(Html.DisplayNameFor(model => model.UserNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
           Write(Html.DisplayNameFor(model => model.IdentityNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
           Write(Html.DisplayNameFor(model => model.UserStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdentityNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
           Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td> \r\n        </tr>\r\n");
#nullable restore
#line 67 "D:\ders\homeworks\OOP\Final\general_information_system\gis_final\gis_final\Views\Students\MyConselors.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<gis_final.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
