#pragma checksum "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29bd38e07d479107e92867aa7754c0c1e3dc8264"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Edit), @"mvc.1.0.view", @"/Views/Restaurants/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29bd38e07d479107e92867aa7754c0c1e3dc8264", @"/Views/Restaurants/Edit.cshtml")]
    public class Views_Restaurants_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurants.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this restaurant: ");
#nullable restore
#line 9 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Edit.cshtml"
                     Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 11 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Edit.cshtml"
Write(Html.HiddenFor(model => model.RestaurantId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Edit.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Edit.cshtml"
Write(Html.EditorFor(model => model.Description));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Edit.cshtml"
Write(Html.LabelFor(model => model.PriceRange));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Edit.cshtml"
Write(Html.EditorFor(model => model.PriceRange));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Edit.cshtml"
Write(Html.LabelFor(model => model.MenuLink));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Edit.cshtml"
Write(Html.TextBoxFor(model => model.MenuLink));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Edit.cshtml"
Write(Html.LabelFor(model => model.Cuisine));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Edit.cshtml"
Write(Html.DropDownList("CuisineId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"save\" />\n");
#nullable restore
#line 32 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 34 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurants.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
