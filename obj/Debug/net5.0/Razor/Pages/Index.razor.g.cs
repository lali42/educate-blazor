#pragma checksum "D:\works\ฝึกงาน\BlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dfd63c3fc6958465e9dc89515c12c8e0bbbdb4b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\works\ฝึกงาน\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\works\ฝึกงาน\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\works\ฝึกงาน\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\works\ฝึกงาน\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\works\ฝึกงาน\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\works\ฝึกงาน\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\works\ฝึกงาน\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\works\ฝึกงาน\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\works\ฝึกงาน\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\works\ฝึกงาน\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\works\ฝึกงาน\BlazorApp\Pages\Index.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""header_section""><div class=""banner_section""><div class=""container-fluid""><section class=""slide-wrapper""><div class=""container-fluid""><div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel""><div class=""carousel-inner""><div class=""carousel-item active""><div class=""row""><div class=""col-sm-2 padding_0""><p class=""mens_taital"">Gaming Gear</p>
							<div class=""page_no"">0/2</div>
							<p class=""mens_taital_2"">Gaming Gear</p></div>
						<div class=""col-sm-5""><div class=""banner_taital""><h1 class=""banner_text"">New Gaming Chair </h1>
								<h1 class=""mens_text""><strong>VERTAGEAR GAMING</strong></h1>
								<p class=""lorem_text"">VERTAGEAR GAMING SL 2000 BLACK-RED (05-VTG-617724128578) (ASSEMBLY REQUIRED)</p>
								<button class=""buy_bt"">Buy Now</button>
								<button class=""more_bt"">See More</button></div></div>
						<div class=""col-sm-5""><div class=""shoes_img""><img src=""images/chair02.png""></div></div></div></div></div></div></div></section></div></div></div>
	


    ");
            __builder.AddMarkupContent(1, @"<div class=""layout_padding collection_section""><div class=""container""><h1 class=""new_text""><strong>ROG Game On T-Shirt</strong></h1>
    	    <p class=""consectetur_text"">We dare to challenge. Dare to compete. Dare to win. The hybrid street culture the future. Arebel spirit with fresh blood.</p></div></div>
    ");
            __builder.AddMarkupContent(2, @"<div class=""collectipn_section_3 layuot_padding""><div class=""container""><div class=""racing_shoes""><div class=""row""><div class=""col-md-8""><div class=""shoes-img3""><img src=""images/t-shirt01.png""></div></div>
    				<div class=""col-md-4""><div class=""sale_text""><strong>Sale <br><span style=""color: #0a0506;"">ROG Game On</span> <br>T-Shirt</strong></div>
    					<div class=""number_text""><strong>฿ <span style=""color: #0a0506"">890</span></strong></div>
    					<button class=""seemore"">See More</button></div></div></div></div></div>
    ");
            __builder.AddMarkupContent(3, "<div class=\"collection_section layout_padding\"><div class=\"container\"><h1 class=\"new_text\"><strong>Products</strong></h1></div></div>\r\n\t\r\n\r\n    \r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "layout_padding gallery_section");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
#nullable restore
#line 78 "D:\works\ฝึกงาน\BlazorApp\Pages\Index.razor"
                 foreach (var entry in BlogDatabase.Default.BlogEntries)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-sm-4");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "best_shoes");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "class", "best_text");
            __builder.AddAttribute(16, "href", "/product/" + (
#nullable restore
#line 82 "D:\works\ฝึกงาน\BlazorApp\Pages\Index.razor"
                                                                  entry.ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, 
#nullable restore
#line 82 "D:\works\ฝึกงาน\BlazorApp\Pages\Index.razor"
                                                                              entry.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "shoes_icon");
            __builder.OpenElement(21, "img");
            __builder.AddAttribute(22, "src", 
#nullable restore
#line 83 "D:\works\ฝึกงาน\BlazorApp\Pages\Index.razor"
                                                               entry.Img1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "star_text");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "left_part");
            __builder.OpenElement(28, "h6");
            __builder.AddContent(29, 
#nullable restore
#line 86 "D:\works\ฝึกงาน\BlazorApp\Pages\Index.razor"
                                         entry.Descrip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "right_part");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "shoes_price");
            __builder.AddMarkupContent(35, "฿ ");
            __builder.OpenElement(36, "span");
            __builder.AddAttribute(37, "style", "color: #ff4e5b;");
            __builder.AddContent(38, 
#nullable restore
#line 89 "D:\works\ฝึกงาน\BlazorApp\Pages\Index.razor"
                                                                                              entry.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                            ");
            __builder.AddMarkupContent(40, "<div class=\"buy_now_bt\"><button class=\"buy_text\">Buy Now</button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 97 "D:\works\ฝึกงาน\BlazorApp\Pages\Index.razor"
                    
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
