#pragma checksum "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40439f00ebabc46cb952510af365821b6be9d15e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Create), @"mvc.1.0.view", @"/Views/Restaurants/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40439f00ebabc46cb952510af365821b6be9d15e", @"/Views/Restaurants/Create.cshtml")]
    public class Views_Restaurants_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurants.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h4>Add a new Restaurant</h4>\n\n");
#nullable restore
#line 9 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.TextBoxFor(model => model.Description));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.LabelFor(model => model.PriceRange));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.TextBoxFor(model => model.PriceRange));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.LabelFor(model => model.MenuLink));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.TextBoxFor(model => model.MenuLink));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.LabelFor(model => model.Cuisine));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.DropDownList("CuisineId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Add new restaurant\" class=\"btn btn-success\" />\n");
#nullable restore
#line 27 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 28 "/Users/jcallahan/Desktop/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.ActionLink("Show all restaurants", "Index"));

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
