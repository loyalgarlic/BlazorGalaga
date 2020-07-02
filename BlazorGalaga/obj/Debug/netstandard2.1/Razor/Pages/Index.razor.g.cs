#pragma checksum "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "220debb40a95cb94f28f058c673d551420b6a379"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorGalaga.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/_Imports.razor"
using BlazorGalaga;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/_Imports.razor"
using BlazorGalaga.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/_Imports.razor"
using Blazor.Extensions.Canvas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/_Imports.razor"
using Blazor.Extensions.Canvas.Canvas2D;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/_Imports.razor"
using Blazor.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/_Imports.razor"
using Blazor.Extensions.Canvas.WebGL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/_Imports.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/_Imports.razor"
using BlazorGalaga.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/_Imports.razor"
using BlazorGalaga.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>


    .content {
        padding: 0px !important;
    }

    div.context.px-4 {
        padding: 0px !important;
    }

    .main > div {
        padding: 0px !important;
    }
    canvas {
        background-color: black;
        display: block;
        width: 100%;
        height: 100%;
        /* position: fixed; */
    }
    body {
        overflow-y: hidden; /* Hide vertical scrollbar */
        overflow-x: hidden; /* Hide horizontal scrollbar */
    }
</style>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "theCanvas");
            __builder.AddAttribute(3, "style", "position: fixed; opacity: 1; background-color: aqua; width: 100%; height: 100%");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<Blazor.Extensions.Canvas.BECanvas>(5);
            __builder.AddAttribute(6, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 31 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                     672

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 31 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                                  944

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(8, (__value) => {
#nullable restore
#line 31 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                                             _canvasReference = (Blazor.Extensions.Canvas.BECanvas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "img");
            __builder.AddAttribute(12, "style", "display:none");
            __builder.AddAttribute(13, "src", "Assets/spritesheet.png");
            __builder.AddElementReferenceCapture(14, (__value) => {
#nullable restore
#line 34 "/Users/bcollins/Projects/BlazorGalaga/BlazorGalaga/Pages/Index.razor"
                                spriteSheet = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
