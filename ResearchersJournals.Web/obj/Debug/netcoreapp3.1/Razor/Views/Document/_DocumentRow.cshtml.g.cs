#pragma checksum "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Document\_DocumentRow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f8b0a1073f606923ddff96449254b0840604413"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Document__DocumentRow), @"mvc.1.0.view", @"/Views/Document/_DocumentRow.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f8b0a1073f606923ddff96449254b0840604413", @"/Views/Document/_DocumentRow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acfd557ad63d2541d18f07748ae3ca397f1e98bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Document__DocumentRow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResearchersJournals.Web.Models.DocumentModels.ResearchersDocumentsDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<td>\r\n    ");
#nullable restore
#line 4 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Document\_DocumentRow.cshtml"
Write(Html.DisplayFor(modelItem => Model.ResearcherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n<td>\r\n    ");
#nullable restore
#line 7 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Document\_DocumentRow.cshtml"
Write(Html.DisplayFor(modelItem => Model.FileName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n\r\n<td>\r\n   ");
#nullable restore
#line 11 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Document\_DocumentRow.cshtml"
Write(Model.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</td>\r\n<td>\r\n");
#nullable restore
#line 15 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Document\_DocumentRow.cshtml"
     if (Model.IsOwner)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 322, "\"", 411, 1);
#nullable restore
#line 17 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Document\_DocumentRow.cshtml"
WriteAttributeValue("", 329, Url.Action("DownloadDocument","Document" , new  {documentId = Model.DocumentId }), 329, 82, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i class=\"fas fa-file-download\"></i>\r\n        </a>\r\n");
#nullable restore
#line 20 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Document\_DocumentRow.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a style=\"cursor:pointer\"");
            BeginWriteAttribute("onclick", " onclick=\"", 515, "\"", 553, 3);
            WriteAttributeValue("", 525, "openPDF(\'", 525, 9, true);
#nullable restore
#line 21 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Document\_DocumentRow.cshtml"
WriteAttributeValue("", 534, Model.DocumentId, 534, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 551, "\')", 551, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-eye\"></i></a> \r\n</td>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResearchersJournals.Web.Models.DocumentModels.ResearchersDocumentsDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
