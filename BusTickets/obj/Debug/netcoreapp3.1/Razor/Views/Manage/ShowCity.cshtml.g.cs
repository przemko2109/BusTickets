#pragma checksum "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowCity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c25018e52bf9057a5654c8977bc7cbcd78451fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ShowCity), @"mvc.1.0.view", @"/Views/Manage/ShowCity.cshtml")]
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
#line 1 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\_ViewImports.cshtml"
using BusTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\_ViewImports.cshtml"
using BusTickets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c25018e52bf9057a5654c8977bc7cbcd78451fd", @"/Views/Manage/ShowCity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a997fe1f4e5d51f1d8c695a34101ebb580a2e851", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_ShowCity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusTickets.Models.City>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowCity.cshtml"
   
    ViewBag.Title = "City"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>City</h2>\n\n<p>\n    ");
#nullable restore
#line 9 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowCity.cshtml"
Write(Html.ActionLink("Create New", "AddCity"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>\n\n<table class=\"table\">\n    <tr>\n        <th>\n            CityName\n        </th>\n        <th>\n            CityId\n        </th>\n        <th></th>\n    </tr>\n\n");
#nullable restore
#line 23 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowCity.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        <p>");
#nullable restore
#line 28 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowCity.cshtml"
      Write(item.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </td>\n    <td>\n        <p>");
#nullable restore
#line 31 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowCity.cshtml"
      Write(item.CityId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </td>\n    <td>\n        ");
#nullable restore
#line 34 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowCity.cshtml"
   Write(Html.ActionLink("Edit", "EditCity", new { id = item.CityId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n        ");
#nullable restore
#line 35 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowCity.cshtml"
   Write(Html.ActionLink("Delete", "DeleteCity", new { id = item.CityId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n</tr>");
#nullable restore
#line 37 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowCity.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>\n\n<div>\n    ");
#nullable restore
#line 42 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowCity.cshtml"
Write(Html.ActionLink("Back to the list", "AdminIndex"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusTickets.Models.City>> Html { get; private set; }
    }
}
#pragma warning restore 1591
