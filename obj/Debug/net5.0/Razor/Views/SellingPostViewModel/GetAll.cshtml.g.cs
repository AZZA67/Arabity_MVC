#pragma checksum "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\SellingPostViewModel\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06e59c8342c7b7a716cb177dfb2340e0e4adf8fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SellingPostViewModel_GetAll), @"mvc.1.0.view", @"/Views/SellingPostViewModel/GetAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06e59c8342c7b7a716cb177dfb2340e0e4adf8fe", @"/Views/SellingPostViewModel/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f592bf515ca5d7385b5f50cbdefb05fa40b55aa", @"/Views/_ViewImports.cshtml")]
    public class Views_SellingPostViewModel_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06e59c8342c7b7a716cb177dfb2340e0e4adf8fe3511", async() => {
                WriteLiteral(@"
    <title>Carbook - Free Bootstrap 4 Template by Colorlib</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <link href=""https://fonts.googleapis.com/css?family=Poppins:200,300,400,500,600,700,800&display=swap"" rel=""stylesheet"">


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06e59c8342c7b7a716cb177dfb2340e0e4adf8fe4805", async() => {
                WriteLiteral(@"
    <section class=""ftco-section ftco-cart"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12 ftco-animate"">
                    <div class=""car-list"">
                        <table class=""table"">
                            <thead class=""thead-primary"">
                                <tr class=""text-center"">
                                    <th>&nbsp;</th>
                                    <th>&nbsp;</th>
                                    <th class=""bg-primary heading"">Post Name</th>
                                    <th class=""bg-primary heading"">Post Date</th>
                                    <th class=""bg-primary heading"">Post Type</th>
                                    <th class=""bg-primary heading"">Edit</th>
                                    <th class=""bg-primary heading"">Details</th>
                                   
                                    <th class=""bg-primary heading"">Add New</th>
                  ");
                WriteLiteral("              </tr>\r\n                            </thead>\r\n                            <tbody>\r\n\r\n");
#nullable restore
#line 38 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\SellingPostViewModel\GetAll.cshtml"
                                 foreach (var item in Model)
                                {
                                    if (item.adv_type == "selling")
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr");
                BeginWriteAttribute("class", " class=\"", 1772, "\"", 1780, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            <td class=""car-image""><div class=""img"" style=""background-image:url();""></div></td>

                                            <td class=""product-name"">
                                                <h3 style=""display:none"">");
#nullable restore
#line 46 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\SellingPostViewModel\GetAll.cshtml"
                                                                    Write(item.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n\r\n                                            </td>\r\n                                            <td class=\"price\">\r\n\r\n                                                <div class=\"price-rate\">\r\n                                                    ");
#nullable restore
#line 52 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\SellingPostViewModel\GetAll.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </td>

                                            <td class=""price"">
                                                <div class=""price-rate"">
                                                    ");
#nullable restore
#line 58 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\SellingPostViewModel\GetAll.cshtml"
                                               Write(item.post_date);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </td>
                                            <td class=""price"">
                                                <div class=""price-rate"">
                                                    Selling Post
                                                </div>
                                            </td>


                                            <td class=""price""> <a class=""btn btn-primary""");
                BeginWriteAttribute("href", " href=\"", 3157, "\"", 3199, 2);
                WriteAttributeValue("", 3164, "/SellingPostViewModel/Edit/", 3164, 27, true);
#nullable restore
#line 68 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\SellingPostViewModel\GetAll.cshtml"
WriteAttributeValue("", 3191, item.ID, 3191, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Edit</a></td>\r\n                                            <td class=\"price\"> <a class=\"btn btn-primary\" autocomplete=\"off\"");
                BeginWriteAttribute("href", " href=\"", 3324, "\"", 3369, 2);
                WriteAttributeValue("", 3331, "/SellingPostViewModel/GetByID/", 3331, 30, true);
#nullable restore
#line 69 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\SellingPostViewModel\GetAll.cshtml"
WriteAttributeValue("", 3361, item.ID, 3361, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Show Details</a></td>\r\n                                       \r\n                                            <td class=\"price\"> <a class=\"btn btn-primary\"");
                BeginWriteAttribute("href", " href=\"", 3524, "\"", 3565, 2);
                WriteAttributeValue("", 3531, "/SellingPostViewModel/New/", 3531, 26, true);
#nullable restore
#line 71 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\SellingPostViewModel\GetAll.cshtml"
WriteAttributeValue("", 3557, item.ID, 3557, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Add Post</a></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 73 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\SellingPostViewModel\GetAll.cshtml"
 }

                                    else if (item.adv_type == "Rental")
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr");
                BeginWriteAttribute("class", " class=\"", 3794, "\"", 3802, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            <td class=""car-image""><div class=""img"" style=""background-image:url();""></div></td>

                                            <td class=""product-name"">
                                                <h3 style=""display:none"">");
#nullable restore
#line 81 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\SellingPostViewModel\GetAll.cshtml"
                                                                    Write(item.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n\r\n                                            </td>\r\n                                            <td class=\"price\">\r\n\r\n                                                <div class=\"price-rate\">\r\n                                                    ");
#nullable restore
#line 87 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\SellingPostViewModel\GetAll.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </td>

                                            <td class=""price"">
                                                <div class=""price-rate"">
                                                    ");
#nullable restore
#line 93 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\SellingPostViewModel\GetAll.cshtml"
                                               Write(item.post_date);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </td>
                                            <td class=""price"">
                                                <div class=""price-rate"">
                                                    Rental Post
                                                </div>
                                            </td>
                                            <td class=""price""> <a class=""btn btn-primary""");
                BeginWriteAttribute("href", " href=\"", 5174, "\"", 5215, 2);
                WriteAttributeValue("", 5181, "/RentalPostViewModel/Edit/", 5181, 26, true);
#nullable restore
#line 101 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\SellingPostViewModel\GetAll.cshtml"
WriteAttributeValue("", 5207, item.ID, 5207, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Edit</a></td>\r\n                                            <td class=\"price\"> <a class=\"btn btn-primary\" autocomplete=\"off\"");
                BeginWriteAttribute("href", " href=\"", 5340, "\"", 5384, 2);
                WriteAttributeValue("", 5347, "/RentalPostViewModel/GetByID/", 5347, 29, true);
#nullable restore
#line 102 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\SellingPostViewModel\GetAll.cshtml"
WriteAttributeValue("", 5376, item.ID, 5376, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Show Details</a></td>
                                            
                                            <td class=""price""> <a class=""btn btn-primary"" href=""/SellingPostViewModel/New"">Add Post</a></td>
                                        </tr><!-- END TR-->");
#nullable restore
#line 105 "C:\Users\ACER\Downloads\Version5\version4\version3\version3\Project With layout\arabeeeety\Arabitey\Views\SellingPostViewModel\GetAll.cshtml"
                                                           }
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                }
                                }


                            </tbody>
                        </table>

                    </div>
                </div>
            </div>
        </div>
    </section>




");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
