#pragma checksum "C:\Users\ompra\OneDrive\Desktop\DIS_Project\Assignment4_DIS-master\Assignment4_DIS-master\Assignment4_DIS\Views\Stations\Stations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cefbae87fc9f62083e39f70426280af4cd2cce51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stations_Stations), @"mvc.1.0.view", @"/Views/Stations/Stations.cshtml")]
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
#line 1 "C:\Users\ompra\OneDrive\Desktop\DIS_Project\Assignment4_DIS-master\Assignment4_DIS-master\Assignment4_DIS\Views\_ViewImports.cshtml"
using Assignment4_DIS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ompra\OneDrive\Desktop\DIS_Project\Assignment4_DIS-master\Assignment4_DIS-master\Assignment4_DIS\Views\_ViewImports.cshtml"
using Assignment4_DIS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cefbae87fc9f62083e39f70426280af4cd2cce51", @"/Views/Stations/Stations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8033c70670191f0dc7e04f8320fb254700d2c44c", @"/Views/_ViewImports.cshtml")]
    public class Views_Stations_Stations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assignment4_DIS.Models.Stations>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Stations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetStationsWithLocation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cefbae87fc9f62083e39f70426280af4cd2cce514671", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>FuelStations</title>

    <link rel=""stylesheet"" type=""text/css"" href=""../css/FuelStations.css"" />
    <link href=""https://fonts.googleapis.com/css?family=Roboto:400,700,500""
          rel=""stylesheet""
          type=""text/css"" />
    <link rel=""stylesheet""
          type=""text/css""
          href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.4.0/css/font-awesome.css"" />
");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cefbae87fc9f62083e39f70426280af4cd2cce516074", async() => {
                WriteLiteral("\n        <div class=\"tab\" style=\"text-align:center;\">\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cefbae87fc9f62083e39f70426280af4cd2cce516400", async() => {
                    WriteLiteral("\n\n                <input id=\"txtSearch\" class=\"search\" type=\"text\" placeholder=\"Search here with Location..\" name=\"location\">\n\n                <button type=\"submit\">Search</button>\n\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

            <br>
            <table id=""t01"">

                <tr>
                    <th>Fuel Station Name</th>
                    <th>Fuel Type</th>
                    <th>Distance In Miles</th>
                    <th>Hours Of Operations</th>
                    <th>Address</th>
                    <th>City</th>
                    <th>ZIP</th>
                    <th>State</th>
                    <th>Country</th>
                    <th>Electric Vehicle Pricing</th>
                    <th>Electric Vehicle Network</th>
                    

                </tr>
");
#nullable restore
#line 45 "C:\Users\ompra\OneDrive\Desktop\DIS_Project\Assignment4_DIS-master\Assignment4_DIS-master\Assignment4_DIS\Views\Stations\Stations.cshtml"
                 foreach (var d in Model.data)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 48 "C:\Users\ompra\OneDrive\Desktop\DIS_Project\Assignment4_DIS-master\Assignment4_DIS-master\Assignment4_DIS\Views\Stations\Stations.cshtml"
               Write(d.station_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                <td>");
#nullable restore
#line 49 "C:\Users\ompra\OneDrive\Desktop\DIS_Project\Assignment4_DIS-master\Assignment4_DIS-master\Assignment4_DIS\Views\Stations\Stations.cshtml"
               Write(d.fuel_type_code);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                <td>");
#nullable restore
#line 50 "C:\Users\ompra\OneDrive\Desktop\DIS_Project\Assignment4_DIS-master\Assignment4_DIS-master\Assignment4_DIS\Views\Stations\Stations.cshtml"
               Write(d.distance);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                <td>");
#nullable restore
#line 51 "C:\Users\ompra\OneDrive\Desktop\DIS_Project\Assignment4_DIS-master\Assignment4_DIS-master\Assignment4_DIS\Views\Stations\Stations.cshtml"
               Write(d.access_days_time);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                <td>");
#nullable restore
#line 52 "C:\Users\ompra\OneDrive\Desktop\DIS_Project\Assignment4_DIS-master\Assignment4_DIS-master\Assignment4_DIS\Views\Stations\Stations.cshtml"
               Write(d.street_address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                <td>");
#nullable restore
#line 53 "C:\Users\ompra\OneDrive\Desktop\DIS_Project\Assignment4_DIS-master\Assignment4_DIS-master\Assignment4_DIS\Views\Stations\Stations.cshtml"
               Write(d.city);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                <td>");
#nullable restore
#line 54 "C:\Users\ompra\OneDrive\Desktop\DIS_Project\Assignment4_DIS-master\Assignment4_DIS-master\Assignment4_DIS\Views\Stations\Stations.cshtml"
               Write(d.zip);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                <td>");
#nullable restore
#line 55 "C:\Users\ompra\OneDrive\Desktop\DIS_Project\Assignment4_DIS-master\Assignment4_DIS-master\Assignment4_DIS\Views\Stations\Stations.cshtml"
               Write(d.state);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                <td>");
#nullable restore
#line 56 "C:\Users\ompra\OneDrive\Desktop\DIS_Project\Assignment4_DIS-master\Assignment4_DIS-master\Assignment4_DIS\Views\Stations\Stations.cshtml"
               Write(d.country);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                <td>");
#nullable restore
#line 57 "C:\Users\ompra\OneDrive\Desktop\DIS_Project\Assignment4_DIS-master\Assignment4_DIS-master\Assignment4_DIS\Views\Stations\Stations.cshtml"
               Write(d.ev_pricing);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                <td>");
#nullable restore
#line 58 "C:\Users\ompra\OneDrive\Desktop\DIS_Project\Assignment4_DIS-master\Assignment4_DIS-master\Assignment4_DIS\Views\Stations\Stations.cshtml"
               Write(d.ev_network);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                \n\n            </tr>\n");
#nullable restore
#line 62 "C:\Users\ompra\OneDrive\Desktop\DIS_Project\Assignment4_DIS-master\Assignment4_DIS-master\Assignment4_DIS\Views\Stations\Stations.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("              \n            </table>\n\n        </div>\n");
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
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment4_DIS.Models.Stations> Html { get; private set; }
    }
}
#pragma warning restore 1591
