#pragma checksum "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Home\GetAllwithCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c757e934148a7d8b6dd187ab5bf2a835b9112030"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetAllwithCars), @"mvc.1.0.view", @"/Views/Home/GetAllwithCars.cshtml")]
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
#line 1 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\_ViewImports.cshtml"
using Arabitey;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\_ViewImports.cshtml"
using Arabitey.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c757e934148a7d8b6dd187ab5bf2a835b9112030", @"/Views/Home/GetAllwithCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f592bf515ca5d7385b5f50cbdefb05fa40b55aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetAllwithCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CarBrand>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section class=\"ftco-section bg-light\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 6 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Home\GetAllwithCars.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    <div class=\"car-wrap rounded ftco-animate\">\r\n\r\n                        <div class=\"text\">\r\n                            <h2 class=\"mb-0\"><a");
            BeginWriteAttribute("href", " href=\"", 377, "\"", 417, 2);
            WriteAttributeValue("", 384, "/Car/GetAllCarsbyBrandId/", 384, 25, true);
#nullable restore
#line 12 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Home\GetAllwithCars.cshtml"
WriteAttributeValue("", 409, item.ID, 409, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Home\GetAllwithCars.cshtml"
                                                                                    Write(item.BrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Home\GetAllwithCars.cshtml"
                             if (User.IsInRole("ADMIN"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"d-flex mb-0 d-block\"><a");
            BeginWriteAttribute("href", " href=\"", 601, "\"", 633, 2);
            WriteAttributeValue("", 608, "/Brand/EditBrand/", 608, 17, true);
#nullable restore
#line 16 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Home\GetAllwithCars.cshtml"
WriteAttributeValue("", 625, item.ID, 625, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary py-2 ml-2\">Edit</a><a");
            BeginWriteAttribute("href", " href=\"", 681, "\"", 715, 2);
            WriteAttributeValue("", 688, "/Brand/DeleteBrand/", 688, 19, true);
#nullable restore
#line 16 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Home\GetAllwithCars.cshtml"
WriteAttributeValue("", 707, item.ID, 707, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary ml-2 py-2 mr-1\">Remove</a></p>\r\n                                <br />\r\n                                <p class=\"d-flex mb-0 d-block\"><a");
            BeginWriteAttribute("href", " href=\"", 877, "\"", 922, 2);
            WriteAttributeValue("", 884, "/CarModelName/GetAllinBrandid/", 884, 30, true);
#nullable restore
#line 18 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Home\GetAllwithCars.cshtml"
WriteAttributeValue("", 914, item.ID, 914, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary pl-2 py-2  ml-2\">View ModelsName</a><a");
            BeginWriteAttribute("href", " href=\"", 987, "\"", 1027, 2);
            WriteAttributeValue("", 994, "/Car/GetAllCarsbyBrandId/", 994, 25, true);
#nullable restore
#line 18 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Home\GetAllwithCars.cshtml"
WriteAttributeValue("", 1019, item.ID, 1019, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary ml-2 py-2 mr-2\">View Cars</a></p>\r\n");
#nullable restore
#line 19 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Home\GetAllwithCars.cshtml"
                            }
                            else
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"d-flex mb-0 d-block\"><a");
            BeginWriteAttribute("href", " href=\"", 1250, "\"", 1290, 2);
            WriteAttributeValue("", 1257, "/Car/GetAllCarsbyBrandId/", 1257, 25, true);
#nullable restore
#line 23 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Home\GetAllwithCars.cshtml"
WriteAttributeValue("", 1282, item.ID, 1282, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary py-2 mr-1\">View Cars</a></p>\r\n");
#nullable restore
#line 24 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Home\GetAllwithCars.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 29 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Home\GetAllwithCars.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Home\GetAllwithCars.cshtml"
 if (User.IsInRole("ADMIN"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <a href=\"/Brand/NewBrand\">Add Brand </a>\r\n</div>\r\n");
#nullable restore
#line 40 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Home\GetAllwithCars.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CarBrand>> Html { get; private set; }
    }
}
#pragma warning restore 1591