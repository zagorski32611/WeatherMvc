#pragma checksum "/home/joe/development/netcore/weatherMvc/weatherMvc/Views/Shared/_WeatherDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99299158bf42602b8eddf9f86067f9374b069e04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__WeatherDetails), @"mvc.1.0.view", @"/Views/Shared/_WeatherDetails.cshtml")]
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
#line 1 "/home/joe/development/netcore/weatherMvc/weatherMvc/Views/_ViewImports.cshtml"
using weatherMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/joe/development/netcore/weatherMvc/weatherMvc/Views/_ViewImports.cshtml"
using weatherMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99299158bf42602b8eddf9f86067f9374b069e04", @"/Views/Shared/_WeatherDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f7237e3a649cabf7da0b077dcbee213d153545d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__WeatherDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/joe/development/netcore/weatherMvc/weatherMvc/Views/Shared/_WeatherDetails.cshtml"
  
    var weatherData = (WeatherData)ViewData["weatherData"];
    var locationData = (LocationData)ViewData["location"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<header class=\"bg-light border-bottom box-shadow\">\n  <div class=\"row\">\n    <div class=\"col\">\n      <h4 class=\"badge\">Humidity ");
#nullable restore
#line 8 "/home/joe/development/netcore/weatherMvc/weatherMvc/Views/Shared/_WeatherDetails.cshtml"
                            Write(weatherData.currently.humidity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n    <div class=\"col\">\n      <h4 class=\"badge\">Dew Point ");
#nullable restore
#line 11 "/home/joe/development/netcore/weatherMvc/weatherMvc/Views/Shared/_WeatherDetails.cshtml"
                             Write(weatherData.currently.dewPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n    <div class=\"col\">\n      <h4 class=\"badge\">Wind Speed ");
#nullable restore
#line 14 "/home/joe/development/netcore/weatherMvc/weatherMvc/Views/Shared/_WeatherDetails.cshtml"
                              Write(weatherData.currently.windSpeed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n    <div class=\"col\">\n      <h4 class=\"badge\">Nearest Storm ");
#nullable restore
#line 17 "/home/joe/development/netcore/weatherMvc/weatherMvc/Views/Shared/_WeatherDetails.cshtml"
                                 Write(weatherData.currently.nearestStormDistance);

#line default
#line hidden
#nullable disable
            WriteLiteral(" mi</h4>\n    </div>\n    <div class=\"col\">\n      <h4 class=\"badge\">Ozone ");
#nullable restore
#line 20 "/home/joe/development/netcore/weatherMvc/weatherMvc/Views/Shared/_WeatherDetails.cshtml"
                         Write(weatherData.currently.ozone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n    <div class=\"col\">\n      <h4 class=\"badge\">Visibility ");
#nullable restore
#line 23 "/home/joe/development/netcore/weatherMvc/weatherMvc/Views/Shared/_WeatherDetails.cshtml"
                              Write(weatherData.currently.visibility);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n    <div class=\"col\">\n      <h4 class=\"badge\" id=\"badge-custom-danger\">Pressure ");
#nullable restore
#line 26 "/home/joe/development/netcore/weatherMvc/weatherMvc/Views/Shared/_WeatherDetails.cshtml"
                                                     Write(weatherData.currently.pressure);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n  </div>\n</header>");
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
