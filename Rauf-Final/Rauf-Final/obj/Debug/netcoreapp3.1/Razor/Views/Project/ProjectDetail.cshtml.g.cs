#pragma checksum "C:\Users\User\Desktop\Rauf-Final-Proje\Rauf-Final\Rauf-Final\Views\Project\ProjectDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e15396908868ee27707b4bd5203f49103d11dd04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_ProjectDetail), @"mvc.1.0.view", @"/Views/Project/ProjectDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e15396908868ee27707b4bd5203f49103d11dd04", @"/Views/Project/ProjectDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fb3736bcfc2797cda490bb35d6b6ecf70c1f559", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_ProjectDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/project/project-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("finance"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/project/project-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/project/project-4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/project/project-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\Rauf-Final-Proje\Rauf-Final\Rauf-Final\Views\Project\ProjectDetail.cshtml"
  
    ViewData["Title"] = "ProjectDetail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Page Title Section -->
<div class=""page-title-section"">
    <div class=""auto-container"">
        <ul class=""post-meta"">
            <li><a href=""index.html"">Index</a></li>
            <li>Project</li>
        </ul>
        <h2><span>Latest</span> From Our Project</h2>
    </div>
</div>
<!-- End Page Title Section -->

<div class=""project-section section-padding"">
    <div class=""auto-container"">
        <div class=""row"">

            <!-- Portfolio Left -->
            <div class=""col-lg-4 col-md-6 col-12"">
                <div class=""work-left work-details"">
                    <div class=""portfolio-main-info"">
                        <h2 class=""title"">About the <br> project</h2>
                        <!-- Start Details List -->
                        <div class=""work-details-list mt-60"">

                            <div class=""details-list"">
                                <label>Date</label>
                                <span>28 Sep 2007</span>
                     ");
            WriteLiteral(@"       </div>

                            <div class=""details-list"">
                                <label>Client</label>
                                <span>HighGrove Partners</span>
                            </div>

                            <div class=""details-list"">
                                <label>Categories</label>
                                <span><a href=""#"">Digital</a></span>
                            </div>

                            <div class=""details-list"">
                                <label>Awards</label>
                                <span>2015 Digital World Awards 2016 Finale Awards</span>
                            </div>

                        </div>
                        <!-- End Details List -->
                        <!-- Start Work Share -->
                        <div class=""work-share section-padding-top-70"">
                            <h6 class=""heading heading-h6"">SHARE</h6>
                        </div>
                    ");
            WriteLiteral(@"</div>
                </div>
            </div>

            <!-- Work Right -->
            <div class=""col-lg-7 col-md-6 offset-lg-1 col-12"">
                <div class=""work-left work-details mt-lg-30"">
                    <div class=""work-main-info"">
                        <div class=""work-content"">
                            <h6 class=""title"">ABOUT THE PROJECT</h6>

                            <div class=""desc mt-40"">
                                <div class=""content mb-25"">
                                    <p>
                                        Digital marketing encompasses all marketing efforts
                                        that use an electronic device or the internet. Businesses leverage
                                        digital channels such as search engines, social media, email, and
                                        their websites to connect with current and prospective customers.
                                    </p>
                       ");
            WriteLiteral(@"         </div>
                                <div class=""content mb-25"">
                                    <p>
                                        It is. In fact, “constant” internet usage among
                                        adults increased by 5% in just the last three years, according to
                                        Pew Research. And although we say it a lot, the way people shop and
                                        buy really has changed along with it — meaning offline marketing
                                        isn’t as effective as it used to be.
                                    </p>
                                </div>
                                <div class=""content mb-60"">
                                    <p>
                                        Marketing has always been about connecting with your
                                        audience in the right place and at the right time. Today, that
                                  ");
            WriteLiteral(@"      means you need to meet them where they are already spending time:
                                        on the internet. (Source: blog.hubspot.com)
                                    </p>
                                </div>

                                <div class=""work-btn"">
                                    <a class=""theme-btn btn-style-one"" href=""#""><span class=""txt"">Go to link</span></a>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Start Thumbnail -->
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""custom-column-thumbnail mt-lg-70"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e15396908868ee27707b4bd5203f49103d11dd0411109", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>

        <!-- Start Digital Marketion Area -->
        <div class=""row mt-lg-100"">
            <div class=""col-lg-4 col-md-12 col-12"">
                <div class=""digital-marketing"">
                    <h3 class=""heading heading-h3"">Digital Marketing.</h3>
                </div>
            </div>
            <div class=""col-lg-7 col-md-12 col-12 offset-lg-1"">
                <div class=""digital-marketing mt-30"">
                    <div class=""inner"">
                        <p>
                            Marketing has always been about connecting with your audience in
                            the right place and at the right time. Today, that means you need to meet them
                            where they are already spending time: on the internet. A seasoned inbound
                            marketer might say inbound marketing and digital marketing are virtually the
                            same thing, but there are");
            WriteLiteral(@" some minor differences. And conversations with
                            marketers and business owners in the U.S., U.K., Asia, Australia, and New
                            Zealand, I've learned a lot about how those small differences are being
                            observed across the world.
                        </p>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Digital Marketion Area -->
        <!-- Start Gallery Area -->
        <div class=""custom-layout-gallery mt-lg-100"">
            <div class=""row mb-n30"">
                <div class=""col-lg-6 col-md-6 col-12"">
                    <div class=""thumbnail"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e15396908868ee27707b4bd5203f49103d11dd0414109", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6 col-md-6 col-12 mt-50\">\r\n                    <div class=\"thumbnail\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e15396908868ee27707b4bd5203f49103d11dd0415502", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"col-lg-12 mtb-30\">\r\n                    <div class=\"thumbnail\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e15396908868ee27707b4bd5203f49103d11dd0416885", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- End Gallery Area -->\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
