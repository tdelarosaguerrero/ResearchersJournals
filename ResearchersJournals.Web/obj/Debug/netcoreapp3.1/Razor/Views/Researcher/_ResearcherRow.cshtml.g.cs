#pragma checksum "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Researcher\_ResearcherRow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7401723536e206c820943e32aadecd106bca0b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Researcher__ResearcherRow), @"mvc.1.0.view", @"/Views/Researcher/_ResearcherRow.cshtml")]
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
#line 1 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\_ViewImports.cshtml"
using ResearchersJournals.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\_ViewImports.cshtml"
using ResearchersJournals.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7401723536e206c820943e32aadecd106bca0b2", @"/Views/Researcher/_ResearcherRow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acfd557ad63d2541d18f07748ae3ca397f1e98bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Researcher__ResearcherRow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResearchersJournals.Web.Models.ResearcherModels.ResearcherDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Researcher\_ResearcherRow.cshtml"
Write(Html.HiddenFor(modelItem => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <td>\r\n        ");
#nullable restore
#line 5 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Researcher\_ResearcherRow.cshtml"
   Write(Html.DisplayFor(modelItem => Model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 8 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Researcher\_ResearcherRow.cshtml"
   Write(Html.DisplayFor(modelItem => Model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n\r\n    <td>\r\n");
#nullable restore
#line 12 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Researcher\_ResearcherRow.cshtml"
         if (Model.IsSubscribe)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <label class=\"label label-primary\">Subscribe</label>\r\n");
#nullable restore
#line 15 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Researcher\_ResearcherRow.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <label>Not Subscribe</label>\r\n");
#nullable restore
#line 19 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Researcher\_ResearcherRow.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n");
#nullable restore
#line 23 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Researcher\_ResearcherRow.cshtml"
         if (Model.IsSubscribe)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 568, "\"", 612, 5);
            WriteAttributeValue("", 578, "subscribe(\'", 578, 11, true);
#nullable restore
#line 25 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Researcher\_ResearcherRow.cshtml"
WriteAttributeValue("", 589, Model.Id, 589, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 598, "\',", 598, 2, true);
            WriteAttributeValue(" ", 600, "true,", 601, 6, true);
            WriteAttributeValue(" ", 606, "this)", 607, 6, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">UnSubscribe</button>\r\n");
#nullable restore
#line 26 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Researcher\_ResearcherRow.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 728, "\"", 773, 5);
            WriteAttributeValue("", 738, "subscribe(\'", 738, 11, true);
#nullable restore
#line 29 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Researcher\_ResearcherRow.cshtml"
WriteAttributeValue("", 749, Model.Id, 749, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 758, "\',", 758, 2, true);
            WriteAttributeValue(" ", 760, "false,", 761, 7, true);
            WriteAttributeValue(" ", 767, "this)", 768, 6, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Subscribe</button>\r\n");
#nullable restore
#line 30 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Researcher\_ResearcherRow.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </td>\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResearchersJournals.Web.Models.ResearcherModels.ResearcherDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591