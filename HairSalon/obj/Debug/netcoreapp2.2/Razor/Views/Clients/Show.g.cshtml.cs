#pragma checksum "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Clients/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "286b704cd42fd5f09c01f483bf596ed7c67458b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Show), @"mvc.1.0.view", @"/Views/Clients/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Show.cshtml", typeof(AspNetCore.Views_Clients_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286b704cd42fd5f09c01f483bf596ed7c67458b8", @"/Views/Clients/Show.cshtml")]
    public class Views_Clients_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(23, 239, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "286b704cd42fd5f09c01f483bf596ed7c67458b84053", async() => {
                BeginContext(29, 162, true);
                WriteLiteral("\n  <meta charset=\'utf-8\'>\n  <title>To Do List</title>\n  <link rel=\'stylesheet\' href=\'https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\'>\n  ");
                EndContext();
                BeginContext(191, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "286b704cd42fd5f09c01f483bf596ed7c67458b84598", async() => {
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
                EndContext();
                BeginContext(254, 1, true);
                WriteLiteral("\n");
                EndContext();
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
            EndContext();
            BeginContext(262, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(263, 762, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "286b704cd42fd5f09c01f483bf596ed7c67458b86775", async() => {
                BeginContext(269, 72, true);
                WriteLiteral("\n  <div class=\"container\">\n    <h1>Client information</h1>\n    <h3>Name ");
                EndContext();
                BeginContext(342, 25, false);
#line 12 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Clients/Show.cshtml"
        Write(Model["client"].GetName());

#line default
#line hidden
                EndContext();
                BeginContext(367, 17, true);
                WriteLiteral("</h3>\n      // <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 384, "\'", 464, 5);
                WriteAttributeValue("", 391, "/stylists/", 391, 10, true);
#line 13 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Clients/Show.cshtml"
WriteAttributeValue("", 401, Model["stylist"].GetId(), 401, 25, false);

#line default
#line hidden
                WriteAttributeValue("", 426, "/clients/", 426, 9, true);
#line 13 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Clients/Show.cshtml"
WriteAttributeValue("", 435, Model["client"].GetId(), 435, 24, false);

#line default
#line hidden
                WriteAttributeValue("", 459, "/edit", 459, 5, true);
                EndWriteAttribute();
                BeginContext(465, 34, true);
                WriteLiteral(">Edit this item</a>\n      // <form");
                EndContext();
                BeginWriteAttribute("action", " action=\"", 499, "\"", 583, 5);
                WriteAttributeValue("", 508, "/stylists/", 508, 10, true);
#line 14 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Clients/Show.cshtml"
WriteAttributeValue("", 518, Model["stylist"].GetId(), 518, 25, false);

#line default
#line hidden
                WriteAttributeValue("", 543, "/clients/", 543, 9, true);
#line 14 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Clients/Show.cshtml"
WriteAttributeValue("", 552, Model["client"].GetId(), 552, 24, false);

#line default
#line hidden
                WriteAttributeValue("", 576, "/delete", 576, 7, true);
                EndWriteAttribute();
                BeginContext(584, 97, true);
                WriteLiteral(" method=\"post\">\n      //   <button type=\"submit\">Delete this item</button>\n      </form>\n      <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 681, "\"", 735, 3);
                WriteAttributeValue("", 688, "/stylists/", 688, 10, true);
#line 17 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Clients/Show.cshtml"
WriteAttributeValue("", 698, Model["stylist"].GetId(), 698, 25, false);

#line default
#line hidden
                WriteAttributeValue("", 723, "/clients/new", 723, 12, true);
                EndWriteAttribute();
                BeginContext(736, 119, true);
                WriteLiteral(">Add New Client</a>\n      <a href=\"/stylists\">View All Stylists</a>\n      <a href=\"/homepage\">Homepage</a>\n\n      <form");
                EndContext();
                BeginWriteAttribute("action", " action=\'", 855, "\'", 904, 3);
                WriteAttributeValue("", 864, "/clients/", 864, 9, true);
#line 21 "/Users/heatherzurek/Desktop/HairSalon-DB/HairSalon/Views/Clients/Show.cshtml"
WriteAttributeValue("", 873, Model["client"].GetId(), 873, 24, false);

#line default
#line hidden
                WriteAttributeValue("", 897, "/delete", 897, 7, true);
                EndWriteAttribute();
                BeginContext(905, 113, true);
                WriteLiteral(" method=\"post\">\n        <button type=\"submit\" class=\"btn btn-dark\">Delete Client</button>\n      </form>\n  </div>\n");
                EndContext();
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
            EndContext();
            BeginContext(1025, 9, true);
            WriteLiteral("\n</html>\n");
            EndContext();
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
