#pragma checksum "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13a959283fbf8f2dcea88f702084207b62331ce3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ShowSchedule), @"mvc.1.0.view", @"/Views/Manage/ShowSchedule.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13a959283fbf8f2dcea88f702084207b62331ce3", @"/Views/Manage/ShowSchedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a997fe1f4e5d51f1d8c695a34101ebb580a2e851", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_ShowSchedule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusTickets.Models.Schedule>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
  
    ViewBag.Title = "Schedule";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Schedule</h2>\n\n<p>\n    ");
#nullable restore
#line 9 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
Write(Html.ActionLink("Create New", "AddSchedule"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</p>
<h1>                 </h1>
<h1>                 </h1>
<h2>Working days</h2>

<table class=""table"">
    <tr>
        <th>
            ScheduleId
        </th>
        <th>
            CityId
        </th>
        <th>
            Hour
        </th>
        <th>
            DayId
        </th>
        <th></th>
    </tr>

");
#nullable restore
#line 32 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
     foreach (var item in Model)
    {
        if (item.DayId == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 38 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 41 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
               Write(Html.DisplayFor(modelItem => item.CityId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 44 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
               Write(Html.DisplayFor(modelItem => item.Hour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 47 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
               Write(Html.DisplayFor(modelItem => item.DayId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 50 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
               Write(Html.ActionLink("Edit", "EditSchedule", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                    ");
#nullable restore
#line 51 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
               Write(Html.ActionLink("Delete", "DeleteSchedule", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 54 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</table>

<h1>                 </h1>
<h1>                 </h1>
<h2>Saturdays</h2>

<table class=""table"">
    <tr>
        <th>
            ScheduleId
        </th>
        <th>
            CityId
        </th>
        <th>
            Hour
        </th>
        <th>
            DayId
        </th>
        <th></th>
    </tr>

");
#nullable restore
#line 80 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
     foreach (var item in Model)
    {
        if (item.DayId == 2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 86 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 89 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
               Write(Html.DisplayFor(modelItem => item.CityId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 92 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
               Write(Html.DisplayFor(modelItem => item.Hour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 95 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
               Write(Html.DisplayFor(modelItem => item.DayId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 98 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
               Write(Html.ActionLink("Edit", "EditSchedule", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                    ");
#nullable restore
#line 99 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
               Write(Html.ActionLink("Delete", "DeleteSchedule", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 102 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table>

<h1>                 </h1>
<h1>                 </h1>
<h2>Sundays</h2>

<table class=""table"">
    <tr>
        <th>
            ScheduleId
        </th>
        <th>
            City
        </th>
        <th>
            Hour
        </th>
        <th>
            Day
        </th>
        <th></th>
    </tr>

");
#nullable restore
#line 127 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
     foreach (var item in Model)
    {
        if (item.DayId == 3)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 133 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 136 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
               Write(Html.DisplayFor(modelItem => item.CityId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 139 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
               Write(Html.DisplayFor(modelItem => item.Hour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 142 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
               Write(Html.DisplayFor(modelItem => item.DayId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 145 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
               Write(Html.ActionLink("Edit", "EditSchedule", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                    ");
#nullable restore
#line 146 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 149 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n<div>\n    ");
#nullable restore
#line 154 "C:\Users\Lenovo\Desktop\BusTickets\BusTickets\Views\Manage\ShowSchedule.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusTickets.Models.Schedule>> Html { get; private set; }
    }
}
#pragma warning restore 1591
