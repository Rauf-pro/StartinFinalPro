#pragma checksum "C:\Users\User\Desktop\Rauf-Final-Proje\Rauf-Final\Rauf-Final\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a74f3802d5db83310b58cb71a225a25a3be3c8af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Rauf-Final-Proje\Rauf-Final\Rauf-Final\Views\_ViewImports.cshtml"
using Rauf_Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Rauf-Final-Proje\Rauf-Final\Rauf-Final\Views\_ViewImports.cshtml"
using Rauf_Final.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Rauf-Final-Proje\Rauf-Final\Rauf-Final\Views\_ViewImports.cshtml"
using Rauf_Final.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Rauf-Final-Proje\Rauf-Final\Rauf-Final\Views\_ViewImports.cshtml"
using Rauf_Final.DATA;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a74f3802d5db83310b58cb71a225a25a3be3c8af", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fb3736bcfc2797cda490bb35d6b6ecf70c1f559", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlogDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("contact.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\Rauf-Final-Proje\Rauf-Final\Rauf-Final\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Page Title Section -->
<div class=""page-title-section"">
    <div class=""auto-container"">
        <ul class=""post-meta"">
            <li><a href=""index.html"">Index</a></li>
            <li>Blog</li>
        </ul>
        <h2><span>Latest</span> From Our Press</h2>
    </div>
</div>
<!-- End Page Title Section -->
<!--Sidebar Page Container-->
<div class=""sidebar-page-container padding-top"">
    <div class=""auto-container"">
        <div class=""row clearfix"">

            <!-- Content Side -->
            <div class=""content-side col-lg-9 col-md-12 col-sm-12"">
                <div class=""our-blogs"">

                    <!-- News Block Three -->
                    <div class=""news-block-three"">
                        <div class=""inner-box"">
                            <div class=""image"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a74f3802d5db83310b58cb71a225a25a3be3c8af6128", async() => {
                WriteLiteral("<img src=\"images/resource/news-4.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 990, "\"", 996, 0);
                EndWriteAttribute();
                WriteLiteral(" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"title\">business</div>\r\n                            <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a74f3802d5db83310b58cb71a225a25a3be3c8af7810", async() => {
                WriteLiteral("Problems About Social Insurance For Truck Drivers");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h4>
                            <div class=""post-date"">Decmber 14th, 2020 by <span>Admin</span></div>
                        </div>
                    </div>

                    <!-- News Block Three -->
                    <div class=""news-block-three"">
                        <div class=""inner-box"">
                            <div class=""image"">
                                <a href=""blog-detail.html""><img src=""images/resource/news-5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1700, "\"", 1706, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                            </div>
                            <div class=""title"">news</div>
                            <h4><a href=""blog-detail.html"">Payment Online -Things That You Know To Protect Your Money Before Perform A Checkout</a></h4>
                            <div class=""post-date"">Decmber 14th, 2020 by <span>Admin</span></div>
                        </div>
                    </div>

                    <!-- News Block Three -->
                    <div class=""news-block-three"">
                        <div class=""inner-box"">
                            <div class=""image"">
                                <a href=""blog-detail.html""><img src=""images/resource/news-6.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2419, "\"", 2425, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                            </div>
                            <div class=""title"">business</div>
                            <h4><a href=""blog-detail.html"">5 Steps To Build Strategy Planning</a></h4>
                            <div class=""post-date"">Decmber 14th, 2020 by <span>Admin</span></div>
                        </div>
                    </div>

                    <!-- News Block Three -->
                    <div class=""news-block-three"">
                        <div class=""inner-box"">
                            <div class=""image"">
                                <a href=""blog-detail.html""><img src=""images/resource/news-7.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3092, "\"", 3098, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                            </div>
                            <div class=""title"">tips & tricks</div>
                            <h4><a href=""blog-detail.html"">5 Secrets To Coaching Your Employees To Greatness</a></h4>
                            <div class=""post-date"">Decmber 14th, 2020 by <span>Admin</span></div>
                        </div>
                    </div>

                    <!-- News Block Three -->
                    <div class=""news-block-three"">
                        <div class=""inner-box"">
                            <div class=""image"">
                                <a href=""blog-detail.html""><img src=""images/resource/news-8.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3785, "\"", 3791, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                            </div>
                            <div class=""title"">News</div>
                            <h4><a href=""blog-detail.html"">Trend Of Consumer Market 2020</a></h4>
                            <div class=""post-date"">Decmber 14th, 2020 by <span>Admin</span></div>
                        </div>
                    </div>

                </div>

                <!-- Post Share Options -->
                <div class=""styled-pagination"">
                    <ul class=""clearfix"">
                        <li><a href=""#"">1</a></li>
                        <li class=""active""><a href=""#"">2</a></li>
                        <li><a href=""#"">3</a></li>
                        <li><a href=""#"">4</a></li>
                        <li class=""next""><a href=""#""><span class=""ti-angle-right""></span> </a></li>
                    </ul>
                </div>

            </div>

            <!--Sidebar Side-->
            <div class=""sidebar-side col-lg-3 col-md-12 col-sm-12");
            WriteLiteral(@""">
                <aside class=""sidebar sticky-top margin-left"">

                    <!-- Search -->
                    <div class=""sidebar-widget search-box"">
                        <div class=""sidebar-title"">
                            <h4>Search</h4>
                        </div>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a74f3802d5db83310b58cb71a225a25a3be3c8af13764", async() => {
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <input type=\"search\" name=\"search-field\"");
                BeginWriteAttribute("value", " value=\"", 5308, "\"", 5316, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Type & Hit Enter...\" required>\r\n                                <button type=\"submit\"><span class=\"icon fa fa-search\"></span></button>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>

                    <!--Category Blog-->
                    <div class=""sidebar-widget categories-blog"">
                        <div class=""sidebar-title"">
                            <h4>Categories</h4>
                        </div>
                        <ul>
                            <li><a href=""#"">All <span>25</span></a></li>
                            <li><a href=""#"">News <span>12</span></a></li>
                            <li><a href=""#"">business <span>7</span></a></li>
                            <li><a href=""#"">tips & tricks <span>4</span></a></li>
                            <li><a href=""#"">Others <span>2</span></a></li>
                        </ul>
                    </div>

                    <!-- Popular Posts -->
                    <div class=""sidebar-widget popular-posts"">
                        <div class=""sidebar-title"">
                            <h4>Recent Posts</h4>
                        </div>
                        <div ");
            WriteLiteral("class=\"widget-content\">\r\n                            <div class=\"post\">\r\n                                <figure class=\"post-thumb\"><a href=\"blog-single.html\"><img src=\"images/resource/post-thumb-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 6760, "\"", 6766, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></figure>
                                <div class=""text""><a href=""blog-single.html"">5 Secrets To Coaching Your Employees To Greatness</a></div>
                            </div>

                            <div class=""post"">
                                <figure class=""post-thumb""><a href=""blog-single.html""><img src=""images/resource/post-thumb-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7136, "\"", 7142, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></figure>
                                <div class=""text""><a href=""blog-single.html"">5 Steps To Build Strategy Planning</a></div>
                            </div>

                            <div class=""post"">
                                <figure class=""post-thumb""><a href=""blog-single.html""><img src=""images/resource/post-thumb-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7497, "\"", 7503, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></figure>
                                <div class=""text""><a href=""blog-single.html"">Trend Of Consumer Market 2020</a></div>
                            </div>
                        </div>
                    </div>

                    <!-- Tags -->
                    <div class=""sidebar-widget tags"">
                        <div class=""sidebar-title"">
                            <h4>Tags</h4>
                        </div>
                        <div class=""widget-content"">
                            <a href=""#"">Structure</a>
                            <a href=""#"">Envato</a>
                            <a href=""#"">Premium</a>
                            <a href=""#"">Clean</a>
                            <a href=""#"">WordPress</a>
                        </div>
                    </div>

                </aside>
            </div>

        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
