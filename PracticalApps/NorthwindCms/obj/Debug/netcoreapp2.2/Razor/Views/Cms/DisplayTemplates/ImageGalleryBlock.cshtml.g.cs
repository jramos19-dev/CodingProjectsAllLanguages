#pragma checksum "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb308d45c6e141e0aa06271af7ebf97f850e5351"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_DisplayTemplates_ImageGalleryBlock), @"mvc.1.0.view", @"/Views/Cms/DisplayTemplates/ImageGalleryBlock.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cms/DisplayTemplates/ImageGalleryBlock.cshtml", typeof(AspNetCore.Views_Cms_DisplayTemplates_ImageGalleryBlock))]
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
#line 2 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
using Piranha.Extend.Blocks;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb308d45c6e141e0aa06271af7ebf97f850e5351", @"/Views/Cms/DisplayTemplates/ImageGalleryBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5b93007b6e082af5cc813bafde1a14cdc102f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_DisplayTemplates_ImageGalleryBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Piranha.Extend.Blocks.ImageGalleryBlock>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
  
    var unique = "gallery-" + Guid.NewGuid().ToString();

#line default
#line hidden
            BeginContext(138, 5, true);
            WriteLiteral("\n<div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 143, "\"", 155, 1);
#line 7 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
WriteAttributeValue("", 148, unique, 148, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(156, 97, true);
            WriteLiteral(" class=\"carousel slide gallery-block\" data-ride=\"carousel\">\n    <ol class=\"carousel-indicators\">\n");
            EndContext();
#line 9 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
         for (var n = 0; n < Model.Items.Count; n++)
        {

#line default
#line hidden
            BeginContext(316, 30, true);
            WriteLiteral("            <li data-target=\"#");
            EndContext();
            BeginContext(347, 6, false);
#line 11 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
                         Write(unique);

#line default
#line hidden
            EndContext();
            BeginContext(353, 17, true);
            WriteLiteral("\" data-slide-to=\"");
            EndContext();
            BeginContext(371, 1, false);
#line 11 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
                                                 Write(n);

#line default
#line hidden
            EndContext();
            BeginContext(372, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 373, "\"", 406, 1);
#line 11 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
WriteAttributeValue("", 381, n == 0 ? "active" : "", 381, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(407, 7, true);
            WriteLiteral("></li>\n");
            EndContext();
#line 12 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
        }

#line default
#line hidden
            BeginContext(424, 43, true);
            WriteLiteral("    </ol>\n    <div class=\"carousel-inner\">\n");
            EndContext();
#line 15 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
         foreach (var item in Model.Items)
        {

#line default
#line hidden
            BeginContext(520, 16, true);
            WriteLiteral("            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 536, "\"", 604, 2);
            WriteAttributeValue("", 544, "carousel-item", 544, 13, true);
#line 17 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
WriteAttributeValue(" ", 557, item == Model.Items.First() ? "active" : "", 558, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(605, 22, true);
            WriteLiteral(">\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 627, "\"", 712, 1);
#line 18 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
WriteAttributeValue("", 633, Url.Content(WebApp.Media.ResizeImage(((ImageBlock)item).Body.Media, 890, 482)), 633, 79, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(713, 43, true);
            WriteLiteral(" class=\"d-block w-100\">\n            </div>\n");
            EndContext();
#line 20 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
        }

#line default
#line hidden
            BeginContext(766, 47, true);
            WriteLiteral("    </div>\n    <a class=\"carousel-control-prev\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 813, "\"", 828, 2);
            WriteAttributeValue("", 820, "#", 820, 1, true);
#line 22 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
WriteAttributeValue("", 821, unique, 821, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(829, 201, true);
            WriteLiteral(" role=\"button\" data-slide=\"prev\">\n        <span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\n        <span class=\"sr-only\">Previous</span>\n    </a>\n    <a class=\"carousel-control-next\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1030, "\"", 1045, 2);
            WriteAttributeValue("", 1037, "#", 1037, 1, true);
#line 26 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
WriteAttributeValue("", 1038, unique, 1038, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1046, 168, true);
            WriteLiteral(" role=\"button\" data-slide=\"next\">\n        <span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\n        <span class=\"sr-only\">Next</span>\n    </a>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Piranha.Extend.Blocks.ImageGalleryBlock> Html { get; private set; }
    }
}
#pragma warning restore 1591