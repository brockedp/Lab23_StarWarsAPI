#pragma checksum "C:\Users\Deno\Documents\Grand Circus\Labs\Lab23_StarWarsAPI\Lab23_StarWarsAPI\Views\Home\GetPlanetbyId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0879e5dde946e54e8941ba4b6b4431067ddd425"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetPlanetbyId), @"mvc.1.0.view", @"/Views/Home/GetPlanetbyId.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetPlanetbyId.cshtml", typeof(AspNetCore.Views_Home_GetPlanetbyId))]
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
#line 1 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab23_StarWarsAPI\Lab23_StarWarsAPI\Views\_ViewImports.cshtml"
using Lab23_StarWarsAPI;

#line default
#line hidden
#line 2 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab23_StarWarsAPI\Lab23_StarWarsAPI\Views\_ViewImports.cshtml"
using Lab23_StarWarsAPI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0879e5dde946e54e8941ba4b6b4431067ddd425", @"/Views/Home/GetPlanetbyId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12682cb7ff9093e6d1b55c7b3104fd5fd77b871b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetPlanetbyId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab23_StarWarsAPI.Models.Planets>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab23_StarWarsAPI\Lab23_StarWarsAPI\Views\Home\GetPlanetbyId.cshtml"
  
    ViewData["Title"] = "GetPlanetbyId";

#line default
#line hidden
            BeginContext(92, 41, true);
            WriteLiteral("\r\n<h1>Planet</h1>\r\n\r\n<ul>\r\n    <li>Name: ");
            EndContext();
            BeginContext(134, 10, false);
#line 10 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab23_StarWarsAPI\Lab23_StarWarsAPI\Views\Home\GetPlanetbyId.cshtml"
         Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(144, 25, true);
            WriteLiteral("</li>\r\n    <li>Rotation: ");
            EndContext();
            BeginContext(170, 21, false);
#line 11 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab23_StarWarsAPI\Lab23_StarWarsAPI\Views\Home\GetPlanetbyId.cshtml"
             Write(Model.rotation_period);

#line default
#line hidden
            EndContext();
            BeginContext(191, 22, true);
            WriteLiteral("</li>\r\n    <li>Orbit: ");
            EndContext();
            BeginContext(214, 20, false);
#line 12 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab23_StarWarsAPI\Lab23_StarWarsAPI\Views\Home\GetPlanetbyId.cshtml"
          Write(Model.orbital_period);

#line default
#line hidden
            EndContext();
            BeginContext(234, 25, true);
            WriteLiteral("</li>\r\n    <li>Diameter: ");
            EndContext();
            BeginContext(260, 14, false);
#line 13 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab23_StarWarsAPI\Lab23_StarWarsAPI\Views\Home\GetPlanetbyId.cshtml"
             Write(Model.diameter);

#line default
#line hidden
            EndContext();
            BeginContext(274, 24, true);
            WriteLiteral("</li>\r\n    <li>Climate: ");
            EndContext();
            BeginContext(299, 13, false);
#line 14 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab23_StarWarsAPI\Lab23_StarWarsAPI\Views\Home\GetPlanetbyId.cshtml"
            Write(Model.climate);

#line default
#line hidden
            EndContext();
            BeginContext(312, 24, true);
            WriteLiteral("</li>\r\n    <li>Gravity: ");
            EndContext();
            BeginContext(337, 13, false);
#line 15 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab23_StarWarsAPI\Lab23_StarWarsAPI\Views\Home\GetPlanetbyId.cshtml"
            Write(Model.gravity);

#line default
#line hidden
            EndContext();
            BeginContext(350, 25, true);
            WriteLiteral("</li>\r\n    <li>Terrain:  ");
            EndContext();
            BeginContext(376, 13, false);
#line 16 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab23_StarWarsAPI\Lab23_StarWarsAPI\Views\Home\GetPlanetbyId.cshtml"
             Write(Model.terrain);

#line default
#line hidden
            EndContext();
            BeginContext(389, 31, true);
            WriteLiteral("</li>\r\n    <li>Surface Water:  ");
            EndContext();
            BeginContext(421, 19, false);
#line 17 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab23_StarWarsAPI\Lab23_StarWarsAPI\Views\Home\GetPlanetbyId.cshtml"
                   Write(Model.surface_water);

#line default
#line hidden
            EndContext();
            BeginContext(440, 28, true);
            WriteLiteral("</li>\r\n    <li>Population:  ");
            EndContext();
            BeginContext(469, 16, false);
#line 18 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab23_StarWarsAPI\Lab23_StarWarsAPI\Views\Home\GetPlanetbyId.cshtml"
                Write(Model.population);

#line default
#line hidden
            EndContext();
            BeginContext(485, 16, true);
            WriteLiteral("</li>\r\n\r\n</ul>\r\n");
            EndContext();
            BeginContext(502, 43, false);
#line 21 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab23_StarWarsAPI\Lab23_StarWarsAPI\Views\Home\GetPlanetbyId.cshtml"
Write(Html.ActionLink("Go back to home", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(545, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab23_StarWarsAPI.Models.Planets> Html { get; private set; }
    }
}
#pragma warning restore 1591
