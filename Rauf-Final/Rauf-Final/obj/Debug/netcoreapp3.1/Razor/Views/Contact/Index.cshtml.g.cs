#pragma checksum "C:\Users\User\Desktop\Rauf-Final-Proje\Rauf-Final\Rauf-Final\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd49abefb8d28ebbc8ea048e1169f88b753cf29f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd49abefb8d28ebbc8ea048e1169f88b753cf29f", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fb3736bcfc2797cda490bb35d6b6ecf70c1f559", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\Rauf-Final-Proje\Rauf-Final\Rauf-Final\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Map Section -->
<div class=""map-section"">
    <div class=""contact-map-area"">
        <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3039.433374128529!2d49.8539949!3d40.3770867!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307d079efb5163%3A0xc20aa51a5f0b5e01!2sCode%20Academy!5e0!3m2!1sen!2s!4v1643218426333!5m2!1sen!2s"" width=""600"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 443, "\"", 461, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy""></iframe>
    </div>
</div>
<!-- End Map Section -->
<!-- Contact Page Section -->
<div class=""contact-page-section"">
    <div class=""auto-container"">
        <!-- Contact Info Boxed -->
        <div class=""contact-info-boxed"">
            <div class=""row clearfix"">

                <!-- Column -->
                <div class=""column col-lg-6 col-md-6 col-sm-12"">
                    <h2>Brooklyn, <span>New York</span></h2>
                    <div class=""text"">849 Diamond Str, 07th Floor, NY 10012, New York, <br> United State America</div>
                    <div class=""email"">Email: <a href=""mailto:infor@consulte.co"">infor@consulte.co</a></div>
                </div>

                <!-- Column -->
                <div class=""column col-lg-6 col-md-6 col-sm-12"">
                    <div class=""call"">Call directly:<br><a href=""#"">+1 212-226-3126</a></div>
                    <ul class=""location-list"">
                        <li><span>Brand Offices:</span>Allentown PA | ");
            WriteLiteral(@"Allanta, GA | Chicago, IL | Dallas, TX, <br> Edison, NJ | Houston, TX</li>
                        <li><span>Work Hours:</span>Mon - Sat: 8.00 - 17.00, Sunday closed</li>
                    </ul>
                </div>

            </div>
        </div>

        <!-- Form Boxed -->
        <div class=""form-boxed"">
            <div class=""sec-title centered"">
                <div class=""title"">contact us</div>
                <h2>We Always Here <span>To Help You</span></h2>
            </div>

            <div class=""boxed-inner"">
                <!-- Contact Form -->
                <div class=""contact-form"">
                    <!-- Contact Form -->
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd49abefb8d28ebbc8ea048e1169f88b753cf29f7230", async() => {
                WriteLiteral(@"
                        <div class=""row clearfix"">
                            <div class=""col-lg-4 col-md-6 col-sm-12 form-group"">
                                <input type=""text"" name=""name"" placeholder=""Name *"" required>
                            </div>

                            <div class=""col-lg-4 col-md-6 col-sm-12 form-group"">
                                <input type=""email"" name=""email"" placeholder=""Emaill Address *"" required>
                            </div>

                            <div class=""col-lg-4 col-md-12 col-sm-12 form-group"">
                                <input type=""text"" name=""subject"" placeholder=""Subject (Optional)"" required>
                            </div>

                            <div class=""col-lg-12 col-md-12 col-sm-12 form-group"">
                                <textarea name=""message"" placeholder=""Message""></textarea>
                            </div>

                            <div class=""col-lg-12 col-md-12 col-sm-12 text-center f");
                WriteLiteral(@"orm-group"">
                                <button class=""theme-btn btn-style-one"" type=""submit"" name=""submit-form""><span class=""txt"">Send Message</span></button>
                            </div>

                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <p class=\"form-messege\"></p>\r\n\r\n                </div>\r\n                <!--End Contact Form -->\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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