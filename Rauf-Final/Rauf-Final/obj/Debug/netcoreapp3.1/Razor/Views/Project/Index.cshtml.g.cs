#pragma checksum "C:\Users\User\Desktop\Rauf-Final-Proje\Rauf-Final\Rauf-Final\Views\Project\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8f94932dcf1aca3cd3e5aaed0e8f8bb440b5a91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Index), @"mvc.1.0.view", @"/Views/Project/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f94932dcf1aca3cd3e5aaed0e8f8bb440b5a91", @"/Views/Project/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fb3736bcfc2797cda490bb35d6b6ecf70c1f559", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Project", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProjectDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\Rauf-Final-Proje\Rauf-Final\Rauf-Final\Views\Project\Index.cshtml"
  
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
            <li>Project</li>
        </ul>
        <h2><span>Latest</span> From Our Project</h2>
    </div>
</div>
<!-- End Page Title Section -->
<!-- Project Section -->
<div class=""project-section section-padding"">
    <div class=""outer-container"">
        <div class=""row clearfix"">

            <!-- Column -->
            <div class=""column col-lg-6 col-md-12 col-sm-12"">
                <div class=""row clearfix"">

                    <!-- Inner Column -->
                    <div class=""inner-column col-lg-6 col-md-6 col-sm-12"">
                        <div class=""gallery-block"">
                            <div class=""inner-box"">
                                <div class=""image"">
                                    <img src=""images/gallery/2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1009, "\"", 1015, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    <div class=\"overlay-box\">\r\n                                        <div class=\"overlay-inner\">\r\n                                            <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8f94932dcf1aca3cd3e5aaed0e8f8bb440b5a915664", async() => {
                WriteLiteral("WOTa Money Save");
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
            WriteLiteral(@"</h3>
                                            <div class=""designation"">Finance, Consulting</div>
                                            <a href=""project-details.html"" class=""arrow ti-angle-right""></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <!-- Inner Column -->
                    <div class=""inner-column col-lg-6 col-md-6 col-sm-12"">
                        <div class=""gallery-block"">
                            <div class=""inner-box"">
                                <div class=""image"">
                                    <img src=""images/gallery/3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2063, "\"", 2069, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                    <div class=""overlay-box"">
                                        <div class=""overlay-inner"">
                                            <h3><a href=""project-details.html"">WOTa Money Save</a></h3>
                                            <div class=""designation"">Finance, Consulting</div>
                                            <a href=""project-details.html"" class=""arrow ti-angle-right""></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <!-- Inner Column -->
                    <div class=""inner-column col-lg-12 col-md-12 col-sm-12"">
                        <div class=""gallery-block"">
                            <div class=""inner-box"">
                                <div class=""image"">
                                    <img src=""images/gallery/4.jpg");
            WriteLiteral("\"");
            BeginWriteAttribute("alt", " alt=\"", 3095, "\"", 3101, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                    <div class=""overlay-box"">
                                        <div class=""overlay-inner"">
                                            <h3><a href=""project-details.html"">WOTa Money Save</a></h3>
                                            <div class=""designation"">Finance, Consulting</div>
                                            <a href=""project-details.html"" class=""arrow ti-angle-right""></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>

            <!-- Column -->
            <div class=""column col-lg-6 col-md-12 col-sm-12"">
                <div class=""gallery-block"">
                    <div class=""inner-box"">
                        <div class=""image"">
                            <img src=""images/gallery/1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4112, "\"", 4118, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                            <div class=""overlay-box"">
                                <div class=""overlay-inner"">
                                    <h3><a href=""project-details.html"">WOTa Money Save</a></h3>
                                    <div class=""designation"">Finance, Consulting</div>
                                    <a href=""project-details.html"" class=""arrow ti-angle-right""></a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>
<!-- End Project Section -->
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
