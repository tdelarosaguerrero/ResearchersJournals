#pragma checksum "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Document\_DocumentViewer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72a4d8070ae6ee5b6ae5f7dfbb6d6e7a2fc853fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Document__DocumentViewer), @"mvc.1.0.view", @"/Views/Document/_DocumentViewer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72a4d8070ae6ee5b6ae5f7dfbb6d6e7a2fc853fa", @"/Views/Document/_DocumentViewer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acfd557ad63d2541d18f07748ae3ca397f1e98bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Document__DocumentViewer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("  <embed");
            BeginWriteAttribute("src", " src=\"", 23, "\"", 63, 2);
            WriteAttributeValue("", 29, "data:application/pdf;base64,", 29, 28, true);
#nullable restore
#line 2 "C:\Users\tdela\source\repos\ResearchersJournals.Web\ResearchersJournals.Web\Views\Document\_DocumentViewer.cshtml"
WriteAttributeValue("", 57, Model, 57, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" frameborder=\"0\" width=\"100%\" height=\"400px\">");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
