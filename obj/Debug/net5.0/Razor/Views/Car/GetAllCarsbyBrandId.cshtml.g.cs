#pragma checksum "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Car\GetAllCarsbyBrandId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13bfde6cc2aae32b7b202ba5e0063eab66f4054e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_GetAllCarsbyBrandId), @"mvc.1.0.view", @"/Views/Car/GetAllCarsbyBrandId.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13bfde6cc2aae32b7b202ba5e0063eab66f4054e", @"/Views/Car/GetAllCarsbyBrandId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f592bf515ca5d7385b5f50cbdefb05fa40b55aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_GetAllCarsbyBrandId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Car>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Car\GetAllCarsbyBrandId.cshtml"
  
    // Layout=null;
    // ViewData["Title"] = "GetAllCarsbyBrandId";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"ftco-section bg-light\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 11 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Car\GetAllCarsbyBrandId.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    <div class=\"car-wrap rounded ftco-animate\">\r\n                        <div class=\"img rounded d-flex align-items-end\"");
            BeginWriteAttribute("style", " style=\"", 433, "\"", 490, 4);
            WriteAttributeValue("", 441, "background-image:", 441, 17, true);
            WriteAttributeValue(" ", 458, "url(/images/", 459, 13, true);
#nullable restore
#line 16 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Car\GetAllCarsbyBrandId.cshtml"
WriteAttributeValue("", 471, item.image.Image, 471, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 488, ");", 488, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"text\">\r\n                            <h2 class=\"mb-0\"><a");
            BeginWriteAttribute("href", " href=\"", 617, "\"", 648, 2);
            WriteAttributeValue("", 624, "/Car/GetDetails/", 624, 16, true);
#nullable restore
#line 19 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Car\GetAllCarsbyBrandId.cshtml"
WriteAttributeValue("", 640, item.ID, 640, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Car\GetAllCarsbyBrandId.cshtml"
                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                            <div class=\"d-flex mb-3\">\r\n                                <span class=\"cat\">");
#nullable restore
#line 21 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Car\GetAllCarsbyBrandId.cshtml"
                                             Write(item.Car_Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <p class=\"price ml-auto\">");
#nullable restore
#line 22 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Car\GetAllCarsbyBrandId.cshtml"
                                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 24 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Car\GetAllCarsbyBrandId.cshtml"
                             if (User.IsInRole("Admin"))
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"d-flex mb-0 d-block\"><a");
            BeginWriteAttribute("href", " href=\"", 1065, "\"", 1090, 2);
            WriteAttributeValue("", 1072, "/Car/Edit/", 1072, 10, true);
#nullable restore
#line 27 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Car\GetAllCarsbyBrandId.cshtml"
WriteAttributeValue("", 1082, item.ID, 1082, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary py-2 ml-3\">Edit</a><a");
            BeginWriteAttribute("href", " href=\"", 1138, "\"", 1165, 2);
            WriteAttributeValue("", 1145, "/Car/Remove/", 1145, 12, true);
#nullable restore
#line 27 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Car\GetAllCarsbyBrandId.cshtml"
WriteAttributeValue("", 1157, item.ID, 1157, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary py-2 mr-1\">Remove</a><a");
            BeginWriteAttribute("href", " href=\"", 1213, "\"", 1244, 2);
            WriteAttributeValue("", 1220, "/Car/GetDetails/", 1220, 16, true);
#nullable restore
#line 27 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Car\GetAllCarsbyBrandId.cshtml"
WriteAttributeValue("", 1236, item.ID, 1236, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary py-2 mr-1\">Details</a></p>\r\n");
#nullable restore
#line 28 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Car\GetAllCarsbyBrandId.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"d-flex mb-0 d-block\"><a");
            BeginWriteAttribute("href", " href=\"", 1458, "\"", 1489, 2);
            WriteAttributeValue("", 1465, "/Car/GetDetails/", 1465, 16, true);
#nullable restore
#line 31 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Car\GetAllCarsbyBrandId.cshtml"
WriteAttributeValue("", 1481, item.ID, 1481, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary py-2 mr-1\">Details</a></p>\r\n");
#nullable restore
#line 32 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Car\GetAllCarsbyBrandId.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 36 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Car\GetAllCarsbyBrandId.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n");
#nullable restore
#line 41 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Car\GetAllCarsbyBrandId.cshtml"
 if (User.IsInRole("ADMIN"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"d-flex mb-0 d-block\"><a href=\"/Car/New\" class=\"btn btn-primary py-2 mr-1\">Add</a></p>\r\n");
#nullable restore
#line 44 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\Car\GetAllCarsbyBrandId.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591
