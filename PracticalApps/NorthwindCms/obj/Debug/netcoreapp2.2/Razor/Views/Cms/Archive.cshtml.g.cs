#pragma checksum "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccf524f3b6923fabe7fe738c66afa9125e131ca7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_Archive), @"mvc.1.0.view", @"/Views/Cms/Archive.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cms/Archive.cshtml", typeof(AspNetCore.Views_Cms_Archive))]
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
#line 2 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf524f3b6923fabe7fe738c66afa9125e131ca7", @"/Views/Cms/Archive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5b93007b6e082af5cc813bafde1a14cdc102f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_Archive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NorthwindCms.Models.BlogArchive>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
  
    ViewBag.Title = Model.Title;

    Func<string> BlogLink = () => {
        return Model.Permalink
            + (Model.Archive.Category != null ? $"/category/{Model.Archive.Category.Slug}"  : "")
            + (Model.Archive.Year.HasValue ? $"/{Model.Archive.Year}" : "" )
            + (Model.Archive.Month.HasValue ? $"/{Model.Archive.Month}" : "");
    };

    Func<string> MonthName = () => {
        if (Model.Archive.Month.HasValue) {
            return new DateTime(2018, Model.Archive.Month.Value, 1) .ToString("MMMM", CultureInfo.InvariantCulture);
        }
        return "";
    };

#line default
#line hidden
            BeginContext(694, 33, true);
            WriteLiteral("\n<div class=\"container archive\">\n");
            EndContext();
#line 23 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
     if (Model.Archive.Category != null) {

#line default
#line hidden
            BeginContext(770, 105, true);
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col blog-filter-header\">\n                <h1>Category: ");
            EndContext();
            BeginContext(876, 28, false);
#line 26 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
                         Write(Model.Archive.Category.Title);

#line default
#line hidden
            EndContext();
            BeginContext(904, 40, true);
            WriteLiteral("</h1>\n            </div>\n        </div>\n");
            EndContext();
#line 29 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
    } else if (Model.Archive.Tag != null) {

#line default
#line hidden
            BeginContext(988, 100, true);
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col blog-filter-header\">\n                <h1>Tag: ");
            EndContext();
            BeginContext(1089, 23, false);
#line 32 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
                    Write(Model.Archive.Tag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1112, 40, true);
            WriteLiteral("</h1>\n            </div>\n        </div>\n");
            EndContext();
#line 35 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
    } else if (Model.Archive.Year.HasValue) {

#line default
#line hidden
            BeginContext(1198, 106, true);
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col blog-filter-header\">\n                <h1>Posts from ");
            EndContext();
            BeginContext(1305, 11, false);
#line 38 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
                          Write(MonthName());

#line default
#line hidden
            EndContext();
            BeginContext(1316, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1318, 18, false);
#line 38 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
                                       Write(Model.Archive.Year);

#line default
#line hidden
            EndContext();
            BeginContext(1336, 40, true);
            WriteLiteral("</h1>\n            </div>\n        </div>\n");
            EndContext();
#line 41 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
    } else {

#line default
#line hidden
            BeginContext(1389, 147, true);
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col blog-filter-header\">\n                <h1>Latest posts</h1>\n            </div>\n        </div>\n");
            EndContext();
#line 47 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
    }

#line default
#line hidden
            BeginContext(1542, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 49 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
     foreach (var post in Model.Archive.Posts)
    {

#line default
#line hidden
            BeginContext(1596, 39, true);
            WriteLiteral("        <article>\n            <header>\n");
            EndContext();
#line 53 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
                 if (post.Regions.Hero.PrimaryImage.HasValue)
                {

#line default
#line hidden
            BeginContext(1715, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1737, "\"", 1759, 1);
#line 55 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1744, post.Permalink, 1744, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1760, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1765, "\"", 1837, 1);
#line 55 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1771, Url.Content(post.Regions.Hero.PrimaryImage.Resize(Api, 930, 360)), 1771, 66, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1838, 6, true);
            WriteLiteral("></a>\n");
            EndContext();
#line 56 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
                }

#line default
#line hidden
            BeginContext(1862, 22, true);
            WriteLiteral("                <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1884, "\"", 1906, 1);
#line 57 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1891, post.Permalink, 1891, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1907, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1909, 10, false);
#line 57 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
                                         Write(post.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1919, 90, true);
            WriteLiteral("</a></h2>\n                <p class=\"post-meta\">\n                    <strong>In</strong> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2009, "\"", 2061, 3);
#line 59 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2016, Model.Permalink, 2016, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 2032, "/category/", 2032, 10, true);
#line 59 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2042, post.Category.Slug, 2042, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2062, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2064, 19, false);
#line 59 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
                                                                                           Write(post.Category.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2083, 100, true);
            WriteLiteral("</a>\n                    <span class=\"sep\">&#9670;</span>\n                    <strong>Tags</strong>\n");
            EndContext();
#line 62 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
                     foreach (var tag in post.Tags)
                    {

#line default
#line hidden
            BeginContext(2257, 44, true);
            WriteLiteral("                        <span class=\"tag\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2301, "\"", 2338, 3);
#line 64 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2308, Model.Permalink, 2308, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 2324, "/tag/", 2324, 5, true);
#line 64 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2329, tag.Slug, 2329, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2339, 2, true);
            WriteLiteral(">#");
            EndContext();
            BeginContext(2342, 9, false);
#line 64 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
                                                                               Write(tag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2351, 12, true);
            WriteLiteral("</a></span>\n");
            EndContext();
#line 65 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
                    }

#line default
#line hidden
            BeginContext(2385, 120, true);
            WriteLiteral("                    <span class=\"sep\">&#9670;</span>\n                    <strong>Published</strong>\n                    ");
            EndContext();
            BeginContext(2506, 43, false);
#line 68 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
               Write(post.Published.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(2549, 94, true);
            WriteLiteral("\n                </p>\n            </header>\n            <div class=\"ingress\">\n                ");
            EndContext();
            BeginContext(2644, 35, false);
#line 72 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
           Write(Html.Raw(post.Regions.Hero.Ingress));

#line default
#line hidden
            EndContext();
            BeginContext(2679, 58, true);
            WriteLiteral("\n            </div>\n            <p><a class=\"btn btn-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2737, "\"", 2759, 1);
#line 74 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2744, post.Permalink, 2744, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2760, 38, true);
            WriteLiteral(">Read more</a></p>\n        </article>\n");
            EndContext();
#line 76 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
    }

#line default
#line hidden
#line 77 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
     if (Model.Archive.TotalPages > 1) {

#line default
#line hidden
            BeginContext(2845, 265, true);
            WriteLiteral(@"        <div class=""row"">
            <div class=""col"">
                <nav aria-label=""Page navigation example"">
                <ul class=""pagination justify-content-center"">
                    <li class=""page-item"">
                        <a class=""page-link""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3110, "\"", 3135, 2);
#line 83 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3117, BlogLink(), 3117, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 3128, "/page/1", 3128, 7, true);
            EndWriteAttribute();
            BeginContext(3136, 278, true);
            WriteLiteral(@">
                            <span aria-hidden=""true"">&laquo;</span>
                            <span class=""sr-only"">Previous</span>
                        </a>
                    </li>
                    <li class=""page-item"">
                        <a class=""page-link""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3414, "\"", 3481, 3);
#line 89 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3421, BlogLink(), 3421, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 3432, "/page/", 3432, 6, true);
#line 89 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3438, Math.Max(1, Model.Archive.CurrentPage - 1), 3438, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3482, 192, true);
            WriteLiteral(">\n                            <span aria-hidden=\"true\">&lsaquo;</span>\n                            <span class=\"sr-only\">Previous</span>\n                        </a>\n                    </li>\n");
            EndContext();
#line 94 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
                     for (var n = 1; n <= Model.Archive.TotalPages; n++) {

#line default
#line hidden
            BeginContext(3749, 27, true);
            WriteLiteral("                        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3776, "\"", 3843, 2);
            WriteAttributeValue("", 3784, "page-item", 3784, 9, true);
#line 95 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue(" ", 3793, Model.Archive.CurrentPage == n ? "active" : "", 3794, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3844, 21, true);
            WriteLiteral("><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3865, "\"", 3891, 3);
#line 95 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3872, BlogLink(), 3872, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 3883, "/page/", 3883, 6, true);
#line 95 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3889, n, 3889, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3892, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3894, 1, false);
#line 95 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
                                                                                                                                           Write(n);

#line default
#line hidden
            EndContext();
            BeginContext(3895, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 96 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
                    }

#line default
#line hidden
            BeginContext(3927, 87, true);
            WriteLiteral("                    <li class=\"page-item\">\n                        <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4014, "\"", 4104, 3);
#line 98 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 4021, BlogLink(), 4021, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 4032, "/page/", 4032, 6, true);
#line 98 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 4038, Math.Min(Model.Archive.TotalPages, Model.Archive.CurrentPage + 1), 4038, 66, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4105, 275, true);
            WriteLiteral(@">
                            <span aria-hidden=""true"">&rsaquo;</span>
                            <span class=""sr-only"">Next</span>
                        </a>
                    </li>
                    <li class=""page-item"">
                        <a class=""page-link""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4380, "\"", 4429, 3);
#line 104 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 4387, BlogLink(), 4387, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 4398, "/page/", 4398, 6, true);
#line 104 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 4404, Model.Archive.TotalPages, 4404, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4430, 266, true);
            WriteLiteral(@">
                            <span aria-hidden=""true"">&raquo;</span>
                            <span class=""sr-only"">Next</span>
                        </a>
                    </li>
                </ul>
                </nav>
            </div>
        </div>
");
            EndContext();
#line 113 "C:\Users\jlram\OneDrive\Desktop\CodingProjectsAllLanguages\PracticalApps\NorthwindCms\Views\Cms\Archive.cshtml"
    }

#line default
#line hidden
            BeginContext(4702, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.IApi Api { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NorthwindCms.Models.BlogArchive> Html { get; private set; }
    }
}
#pragma warning restore 1591
