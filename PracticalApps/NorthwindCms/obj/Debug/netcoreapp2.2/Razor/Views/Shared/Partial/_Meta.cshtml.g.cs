#pragma checksum "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Shared\Partial\_Meta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "235468e6b620978f790c27387df30029cd001be7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial__Meta), @"mvc.1.0.view", @"/Views/Shared/Partial/_Meta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partial/_Meta.cshtml", typeof(AspNetCore.Views_Shared_Partial__Meta))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"235468e6b620978f790c27387df30029cd001be7", @"/Views/Shared/Partial/_Meta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5b93007b6e082af5cc813bafde1a14cdc102f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial__Meta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Piranha.Models.IMeta>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 22, true);
            WriteLiteral("\n<meta name=\"keywords\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 50, "\"", 79, 1);
#line 3 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Shared\Partial\_Meta.cshtml"
WriteAttributeValue("", 60, Model.MetaKeywords, 60, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(80, 26, true);
            WriteLiteral(">\n<meta name=\"description\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 106, "\"", 138, 1);
#line 4 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Shared\Partial\_Meta.cshtml"
WriteAttributeValue("", 116, Model.MetaDescription, 116, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(139, 64, true);
            WriteLiteral(">\n\n<meta name=\"og:type\" content=\"article\">\n<meta name=\"og:title\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 203, "\"", 225, 1);
#line 7 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Shared\Partial\_Meta.cshtml"
WriteAttributeValue("", 213, Model.Title, 213, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(226, 29, true);
            WriteLiteral(">\n<meta name=\"og:description\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 255, "\"", 287, 1);
#line 8 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Shared\Partial\_Meta.cshtml"
WriteAttributeValue("", 265, Model.MetaDescription, 265, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(288, 2, true);
            WriteLiteral(">\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.AspNetCore.Services.IApplicationService WebApp { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Piranha.Models.IMeta> Html { get; private set; }
    }
}
#pragma warning restore 1591
