#pragma checksum "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffbabf7e739e06d0ae92b260d4197d62937f26c4"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjektAPBD.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\_Imports.razor"
using ProjektAPBD.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\_Imports.razor"
using ProjektAPBD.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
using Client.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/stock/{Ticker}")]
    public partial class Stock : StockBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
 if (Stock == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><img src=\"https://i.giphy.com/media/3oEjI6SIIHBdRxXI40/giphy.webp\"></p>");
#nullable restore
#line 16 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "p");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
                                                 AddToWatchList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "style", "float: right;");
            __builder.AddContent(6, 
#nullable restore
#line 19 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
                                                                                        res

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(7, "p");
            __builder.AddMarkupContent(8, "\r\n        Search Company\r\n        ");
            __builder.OpenComponent<ProjektAPBD.Client.Shared.SearchComponent>(9);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "float-container");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "float-child");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "green");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "src", 
#nullable restore
#line 29 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
                           Stock.Icon

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "width", "200px");
            __builder.AddAttribute(20, "height", "200px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "float-child");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "float-container");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "float-child");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "green");
            __builder.AddMarkupContent(30, "Ticker:<br>");
            __builder.OpenElement(31, "b");
            __builder.AddContent(32, 
#nullable restore
#line 37 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
                                                         Stock.Ticker

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n                ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "float-child");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "blue");
            __builder.AddMarkupContent(38, "Name:<br>");
            __builder.OpenElement(39, "b");
            __builder.AddContent(40, 
#nullable restore
#line 41 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
                                                      Stock.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "float-container");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "float-child");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "green");
            __builder.AddMarkupContent(48, "Industry:<br>");
            __builder.OpenElement(49, "b");
            __builder.AddContent(50, 
#nullable restore
#line 48 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
                                                           Stock.Industry

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n                ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "float-child");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "blue");
            __builder.AddMarkupContent(56, "Country:<br>");
            __builder.OpenElement(57, "b");
            __builder.AddContent(58, 
#nullable restore
#line 52 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
                                                         Stock.Country

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.OpenElement(60, "div");
            __builder.AddMarkupContent(61, "<h3>\r\n            Description:\r\n        </h3>\r\n        ");
            __builder.OpenElement(62, "p");
            __builder.AddContent(63, 
#nullable restore
#line 62 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
            Stock.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
     if (StockDetails == null || Stock.Ticker != Ticker)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(64, "<p>Loading chart...</p>");
#nullable restore
#line 67 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfStockChart>(65);
            __builder.AddAttribute(66, "Title", "OHCL Chart");
            __builder.AddAttribute(67, "EnablePeriodSelector", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 70 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
                                                               false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.StockChartSeriesCollection>(69);
                __builder2.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.StockChartSeries>(71);
                    __builder3.AddAttribute(72, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 72 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
                                         ChartSeriesType.HiloOpenClose

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 72 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
                                                                                     StockDetails

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(74, "XName", "Date");
                    __builder3.AddAttribute(75, "High", "High");
                    __builder3.AddAttribute(76, "Low", "Low");
                    __builder3.AddAttribute(77, "Open", "Open");
                    __builder3.AddAttribute(78, "Close", "Close");
                    __builder3.AddAttribute(79, "Volume", "Volume");
                    __builder3.AddAttribute(80, "BearFillColor", "#2ecd71");
                    __builder3.AddAttribute(81, "BullFillColor", "#e74c3d");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 78 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
         if (Articles == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(82, "<p>Loading articles...</p>");
#nullable restore
#line 81 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
             foreach (var ele in Articles)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "article");
            __builder.OpenElement(85, "h2");
            __builder.OpenElement(86, "b");
            __builder.AddContent(87, 
#nullable restore
#line 87 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
                            ele.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                    ");
            __builder.OpenElement(89, "p");
            __builder.OpenElement(90, "i");
            __builder.AddContent(91, 
#nullable restore
#line 88 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
                           ele.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.OpenElement(93, "h5");
            __builder.AddAttribute(94, "align", "right");
            __builder.OpenElement(95, "b");
            __builder.AddContent(96, 
#nullable restore
#line 89 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
                                           ele.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                    ");
            __builder.OpenElement(98, "a");
            __builder.AddAttribute(99, "href", 
#nullable restore
#line 90 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
                              ele.AmpUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(100, "Link do artyku??u ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 92 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
             

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
     
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(101, @"<style>
    .float-container {
        padding: 20px;
    }

    .float-child {
        width: 50%;
        float: left;
        padding: 20px;
    }

    .stockchartloader {
        border: 6px solid #f3f3f3;
        border-top: 6px solid #7a0fff;
        width: 40px;
        height: 40px;
        position: absolute;
        top: 46%;
        left: 46%;
        border-radius: 50%;
        -webkit-animation: loader 2s linear infinite;
        animation: loader 2s linear infinite;
    }

    .stockchartdiv {
        visibility: hidden;
    }
    .article{
        margin-top: 25px;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "C:\Users\s22596\Desktop\Projekt APBD s22596\ProjektAPBD\ProjektAPBD\Client\Pages\Stock.razor"
       
    private string res = "Add to watch list";
    private string _userId;
    private List<Stock> stocks = new List<Stock>();
    public List<ProjektAPBD.Shared.Models.StockDataDTO> StockDetails;
    public List<ProjektAPBD.Shared.Models.StockArticleDTO> Articles;
    protected override async Task OnParametersSetAsync()
    {
        Stock = await _stockService.GetStockAsync(Ticker);
        StockDetails = await _stockService.AgregateBarsAsync(Ticker);
        Articles = await _stockService.GetArticlesAsync(Ticker);
        await GetClaimsPrincipalData();
        await base.OnParametersSetAsync();

    }

    private async Task GetClaimsPrincipalData()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity.IsAuthenticated)
        {
            _userId = user.FindFirst(c => c.Type == "sub")?.Value;
        }
    }
    private async void AddToWatchList()
    {
        var odp = await _stockService.AddWatchStockAsync(_userId, Ticker);
        res = "Added to watch list";
    }
    public class StockData
    {
        public DateTime Date { get; set; }
        public double Open { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double High { get; set; }
        public double Volume { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStockService _stockService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
