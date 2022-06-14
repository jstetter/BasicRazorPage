#pragma checksum "/Users/jstetter/Projects/BasicRazorPage/BasicRazorPage/TestApp/TestApp/Pages/Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b41f5d2ae60e273d23e1cdffc2c221d63809f937"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TestApp.Pages.Pages_Error), @"mvc.1.0.razor-page", @"/Pages/Error.cshtml")]
namespace TestApp.Pages
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
#line 1 "/Users/jstetter/Projects/BasicRazorPage/BasicRazorPage/TestApp/TestApp/Pages/_ViewImports.cshtml"
using TestApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b41f5d2ae60e273d23e1cdffc2c221d63809f937", @"/Pages/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f3bff7bae877bf75d3dea2c4fb00036484c1cbb", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Error : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/jstetter/Projects/BasicRazorPage/BasicRazorPage/TestApp/TestApp/Pages/Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"text-danger\">Error.</h1>\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\n\n");
#nullable restore
#line 10 "/Users/jstetter/Projects/BasicRazorPage/BasicRazorPage/TestApp/TestApp/Pages/Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\n        <strong>Request ID:</strong> <code>");
#nullable restore
#line 13 "/Users/jstetter/Projects/BasicRazorPage/BasicRazorPage/TestApp/TestApp/Pages/Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\n    </p>\n");
#nullable restore
#line 15 "/Users/jstetter/Projects/BasicRazorPage/BasicRazorPage/TestApp/TestApp/Pages/Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to the <strong>Development</strong> environment displays detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel>)PageContext?.ViewData;
        public ErrorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
