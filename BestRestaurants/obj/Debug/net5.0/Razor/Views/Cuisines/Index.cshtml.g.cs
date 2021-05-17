#pragma checksum "/Users/sofiaacosta/Epicodus/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e253ad74447aa80d559383a68ca62e441ddd5c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuisines_Index), @"mvc.1.0.view", @"/Views/Cuisines/Index.cshtml")]
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
#line 5 "/Users/sofiaacosta/Epicodus/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
using BestRestaurants.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e253ad74447aa80d559383a68ca62e441ddd5c2", @"/Views/Cuisines/Index.cshtml")]
    public class Views_Cuisines_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/sofiaacosta/Epicodus/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Cuisine Types:</h1>\n\n");
#nullable restore
#line 9 "/Users/sofiaacosta/Epicodus/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No cuisines have been added yet!</h3>\n");
#nullable restore
#line 12 "/Users/sofiaacosta/Epicodus/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<ul>\n");
#nullable restore
#line 15 "/Users/sofiaacosta/Epicodus/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
   foreach (Cuisine cuisine in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 17 "/Users/sofiaacosta/Epicodus/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
   Write(Html.ActionLink($"{cuisine.Name}", "Details", new { id = cuisine.CuisineId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 18 "/Users/sofiaacosta/Epicodus/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n\n<p>");
#nullable restore
#line 21 "/Users/sofiaacosta/Epicodus/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
Write(Html.ActionLink("Add new category", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 22 "/Users/sofiaacosta/Epicodus/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
