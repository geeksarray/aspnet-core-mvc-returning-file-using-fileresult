#pragma checksum "L:\Laxmikant\applications\GeeksApps\getting-started-with-aspnet-mvc-core-and-dotnet5-main\Areas\GeeksEmployee\Views\GeeksEmployee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da7635f9016eb17f3bf8881425e9a4ffb2ce503b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_GeeksEmployee_Views_GeeksEmployee_Index), @"mvc.1.0.view", @"/Areas/GeeksEmployee/Views/GeeksEmployee/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da7635f9016eb17f3bf8881425e9a4ffb2ce503b", @"/Areas/GeeksEmployee/Views/GeeksEmployee/Index.cshtml")]
    public class Areas_GeeksEmployee_Views_GeeksEmployee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC5Tutorial.Areas.GeeksEmployee.Models.EmployeeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "L:\Laxmikant\applications\GeeksApps\getting-started-with-aspnet-mvc-core-and-dotnet5-main\Areas\GeeksEmployee\Views\GeeksEmployee\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Employee Details</h1>\n\n<div>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 15 "L:\Laxmikant\applications\GeeksApps\getting-started-with-aspnet-mvc-core-and-dotnet5-main\Areas\GeeksEmployee\Views\GeeksEmployee\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 18 "L:\Laxmikant\applications\GeeksApps\getting-started-with-aspnet-mvc-core-and-dotnet5-main\Areas\GeeksEmployee\Views\GeeksEmployee\Index.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 21 "L:\Laxmikant\applications\GeeksApps\getting-started-with-aspnet-mvc-core-and-dotnet5-main\Areas\GeeksEmployee\Views\GeeksEmployee\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 24 "L:\Laxmikant\applications\GeeksApps\getting-started-with-aspnet-mvc-core-and-dotnet5-main\Areas\GeeksEmployee\Views\GeeksEmployee\Index.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 27 "L:\Laxmikant\applications\GeeksApps\getting-started-with-aspnet-mvc-core-and-dotnet5-main\Areas\GeeksEmployee\Views\GeeksEmployee\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 30 "L:\Laxmikant\applications\GeeksApps\getting-started-with-aspnet-mvc-core-and-dotnet5-main\Areas\GeeksEmployee\Views\GeeksEmployee\Index.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 33 "L:\Laxmikant\applications\GeeksApps\getting-started-with-aspnet-mvc-core-and-dotnet5-main\Areas\GeeksEmployee\Views\GeeksEmployee\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 36 "L:\Laxmikant\applications\GeeksApps\getting-started-with-aspnet-mvc-core-and-dotnet5-main\Areas\GeeksEmployee\Views\GeeksEmployee\Index.cshtml"
       Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 39 "L:\Laxmikant\applications\GeeksApps\getting-started-with-aspnet-mvc-core-and-dotnet5-main\Areas\GeeksEmployee\Views\GeeksEmployee\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 42 "L:\Laxmikant\applications\GeeksApps\getting-started-with-aspnet-mvc-core-and-dotnet5-main\Areas\GeeksEmployee\Views\GeeksEmployee\Index.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n\n\n<div>\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1267, "\"", 1299, 1);
#nullable restore
#line 49 "L:\Laxmikant\applications\GeeksApps\getting-started-with-aspnet-mvc-core-and-dotnet5-main\Areas\GeeksEmployee\Views\GeeksEmployee\Index.cshtml"
WriteAttributeValue("", 1282, Model.EmployeeID, 1282, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\n    <a asp-action=\"Index\">Back to List</a>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC5Tutorial.Areas.GeeksEmployee.Models.EmployeeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
