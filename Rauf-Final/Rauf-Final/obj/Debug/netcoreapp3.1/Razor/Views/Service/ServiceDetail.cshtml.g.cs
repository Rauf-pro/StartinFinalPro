#pragma checksum "C:\Users\User\Desktop\Rauf-Final-Proje\Rauf-Final\Rauf-Final\Views\Service\ServiceDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9e2965a5f5bd1f80ed7735f09a3b23865bad901"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_ServiceDetail), @"mvc.1.0.view", @"/Views/Service/ServiceDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9e2965a5f5bd1f80ed7735f09a3b23865bad901", @"/Views/Service/ServiceDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fb3736bcfc2797cda490bb35d6b6ecf70c1f559", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_ServiceDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/resource/service-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/resource/graph.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\Desktop\Rauf-Final-Proje\Rauf-Final\Rauf-Final\Views\Service\ServiceDetail.cshtml"
  
    ViewData["Title"] = "ServiceDetail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Sidebar Page Container-->
<div class=""sidebar-page-container"">
    <div class=""auto-container"">
        <!-- Service Title Box -->
        <div class=""service-title-box"">
            <h2>Business Services Consulting</h2>
        </div>
        <div class=""row clearfix"">

            <!-- Content Side -->
            <div class=""content-side col-lg-9 col-md-12 col-sm-12"">
                <div class=""service-detail"">
                    <div class=""inner-box"">
                        <div class=""image"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9e2965a5f5bd1f80ed7735f09a3b23865bad9015495", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""lower-content"">
                            <p>We work closely with Employers across all industry sectors to ensure that their internal sed Human Resource systems processes align to their business requirements idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the great explorer of the truth.</p>
                            <p>Take a 360-degree sed view of yours situations using our seds deep experience, industries specialization and global reach ensure that their internal sed Human Resource systems processes align to their business requirements idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings ensure that their internal sed Human Resource systems processes align to their business requirements ut idea of denouncing pleasure and praising pain was born and I will give you a complet");
            WriteLiteral(@"e account seds expound the actual teachings</p>
                            <blockquote>
                                HasTech ??? we help companies assess their skills and choose a new direction which utilizes the talents of the team and resources most productively.
                            </blockquote>
                            <h4>Specific Services</h4>
                            <div class=""row clearfix"">

                                <!-- Service Block -->
                                <div class=""service-block style-two col-lg-4 col-md-6 col-12"">
                                    <div class=""inner-box"">
                                        <div class=""icon-box"">
                                            <span class=""icon ti-user""></span>
                                        </div>
                                        <h5><a href=""service-detail.html"">Talent & HR Analytics</a></h5>
                                        <div class=""text"">Which of ever undertke labo");
            WriteLiteral(@"rious physical exercised excepts.</div>
                                    </div>
                                </div>

                                <!-- Service Block -->
                                <div class=""service-block style-two col-lg-4 col-md-6 col-12"">
                                    <div class=""inner-box"">
                                        <div class=""icon-box"">
                                            <span class=""icon ti-pie-chart""></span>
                                        </div>
                                        <h5><a href=""service-detail.html"">Fraud & Risk Analytics</a></h5>
                                        <div class=""text"">Great explorer the master builder working human happiness.</div>
                                    </div>
                                </div>

                                <!-- Service Block -->
                                <div class=""service-block style-two col-lg-4 col-md-6 col-12"">
                  ");
            WriteLiteral(@"                  <div class=""inner-box"">
                                        <div class=""icon-box"">
                                            <span class=""icon ti-stats-up""></span>
                                        </div>
                                        <h5><a href=""service-detail.html"">Marketing Analytics</a></h5>
                                        <div class=""text"">Chooses to enjoy a pleasure that has no anoing consequences</div>
                                    </div>
                                </div>

                            </div>

                            <!-- Analysis Columns -->
                            <div class=""analysis-columns"">
                                <div class=""row clearfix"">
                                    <!-- Column -->
                                    <div class=""column col-lg-6 col-md-6 col-sm-12"">
                                        <h4>Advantages Of Services</h4>
                                        <p>Be");
            WriteLiteral(@"guiled and demoralized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue beguiled and demoralized by the charms of pleasure of the moment, so blinded by desire trouble.</p>
                                        <ul class=""list-style-one"">
                                            <li>Develop new ideas and market them</li>
                                            <li>Build leadership and management skills</li>
                                            <li>Improve manufacturing processes</li>
                                            <li>Build a business strategy and plan</li>
                                            <li>Demoralized by the charm of the moment</li>
                                        </ul>
                                    </div>
                                    <!-- Column -->
                                    <div class=""column col-lg-6 col-md-6 col-sm-12"">
                   ");
            WriteLiteral("                     <h4>Competitors Research & Analysis</h4>\r\n                                        <div class=\"graph-image\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9e2965a5f5bd1f80ed7735f09a3b23865bad90112114", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                            </div>
                            <!-- End Analysis Columns -->

                            <div class=""accordian-box"">
                                <h4>Research Beyond The Business Plan</h4>

                                <!--Accordian Box-->
                                <ul class=""accordion-box"">

                                    <!--Block-->
                                    <li class=""accordion block active-block"">
                                        <div class=""acc-btn active""><div class=""icon-outer""><span class=""icon icofont-plus""></span> <span class=""icon icofont-minus""></span></div>Client Prospecting</div>
                                        <div class=""acc-content current"">
                                            <div class=""content"">
                                                <div class=""accordi");
            WriteLiteral(@"an-text"">We also ensure that the whole team is included in the process and that no one is left out during the turnaround. The most crucial part is ensuring some degree of financial stability during the turnaround.</div>
                                            </div>
                                        </div>
                                    </li>

                                    <!--Block-->
                                    <li class=""accordion block"">
                                        <div class=""acc-btn""><div class=""icon-outer""><span class=""icon icofont-plus""></span> <span class=""icon icofont-minus""></span></div>Website Research</div>
                                        <div class=""acc-content"">
                                            <div class=""content"">
                                                <div class=""accordian-text"">We also ensure that the whole team is included in the process and that no one is left out during the turnaround. The most crucial part is");
            WriteLiteral(@" ensuring some degree of financial stability during the turnaround.</div>
                                            </div>
                                        </div>
                                    </li>

                                    <!--Block-->
                                    <li class=""accordion block"">
                                        <div class=""acc-btn""><div class=""icon-outer""><span class=""icon icofont-plus""></span> <span class=""icon icofont-minus""></span></div>Grant & Funding Research</div>
                                        <div class=""acc-content"">
                                            <div class=""content"">
                                                <div class=""accordian-text"">We also ensure that the whole team is included in the process and that no one is left out during the turnaround. The most crucial part is ensuring some degree of financial stability during the turnaround.</div>
                                            </div>
           ");
            WriteLiteral(@"                             </div>
                                    </li>

                                </ul>

                            </div>

                        </div>
                    </div>
                </div>
            </div>

            <!--Sidebar Side-->
            <div class=""sidebar-side col-lg-3 col-md-12 col-sm-12"">
                <aside class=""sidebar sticky-top"">

                    <!-- Category Widget -->
                    <div class=""sidebar-widget categories-widget"">

                        <div class=""category-boxed"">
                            <a href=""#"" class=""overlay-link""></a>
                            <div class=""boxed-inner"">
                                <div class=""icon ti-blackboard""></div>
                                <h6>Business Strategy Planning</h6>
                            </div>
                        </div>

                        <div class=""category-boxed"">
                            <a href=""#"" clas");
            WriteLiteral(@"s=""overlay-link""></a>
                            <div class=""boxed-inner"">
                                <div class=""icon ti-stats-up""></div>
                                <h6>Economic and Financial</h6>
                            </div>
                        </div>

                        <div class=""category-boxed"">
                            <a href=""#"" class=""overlay-link""></a>
                            <div class=""boxed-inner"">
                                <div class=""icon ti-shield""></div>
                                <h6>Insurance Planning Consulation</h6>
                            </div>
                        </div>

                        <div class=""category-boxed"">
                            <a href=""#"" class=""overlay-link""></a>
                            <div class=""boxed-inner"">
                                <div class=""icon ti-home""></div>
                                <h6>Estate & Properties Planning</h6>
                            </div>
     ");
            WriteLiteral(@"                   </div>

                        <div class=""category-boxed"">
                            <a href=""#"" class=""overlay-link""></a>
                            <div class=""boxed-inner"">
                                <div class=""icon ti-stamp""></div>
                                <h6>Audit & Evaluation Consulting</h6>
                            </div>
                        </div>

                        <div class=""category-boxed"">
                            <a href=""#"" class=""overlay-link""></a>
                            <div class=""boxed-inner"">
                                <div class=""icon ti-money""></div>
                                <h6>Taxes & Efficiency Consulting</h6>
                            </div>
                        </div>

                        <div class=""category-boxed"">
                            <a href=""#"" class=""overlay-link""></a>
                            <div class=""boxed-inner"">
                                <div class=""icon ");
            WriteLiteral(@"ti-shopping-cart-full""></div>
                                <h6>Consumer Product Market</h6>
                            </div>
                        </div>

                        <div class=""category-boxed"">
                            <a href=""#"" class=""overlay-link""></a>
                            <div class=""boxed-inner"">
                                <div class=""icon ti-truck""></div>
                                <h6>Transportation and Logistic Planning</h6>
                            </div>
                        </div>

                    </div>

                    <!-- brochure Widget -->
                    <div class=""sidebar-widget brochures-widget"">
                        <div class=""widget-content"">
                            <h4>Our brochures</h4>
                            <div class=""text"">Download our comapny profile & 2017 financial brochure.</div>
                            <ul class=""brochure-list"">
                                <li><a href=""#""><sp");
            WriteLiteral(@"an class=""icon far fa-file-pdf""></span>Donwload PDF</a></li>
                                <li><a href=""#""><span class=""icon far fa-file-word""></span>Donwload DOC</a></li>
                            </ul>
                        </div>
                    </div>

                    <!-- Enquiry Widget -->
                    <div class=""sidebar-widget enquiry-widget"">
                        <div class=""widget-content"">
                            <h4>For Business Enquiry</h4>
                            <div class=""text"">You can also send us an email and we???ll get in touch shortly, or Troll Free</div>
                            <div class=""number"">Number :<a href=""tel:+91-00-700-6202"">(+91) 00-700-6202.</a></div>
                            <a href=""#"" class=""theme-btn btn-style-two""><span class=""txt"">Send Email</span></a>
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
