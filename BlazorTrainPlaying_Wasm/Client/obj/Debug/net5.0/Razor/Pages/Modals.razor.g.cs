#pragma checksum "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\Pages\Modals.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c39fc8f2d443963e6298ec9f7b9f8b0123bd4c4d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTrainPlaying_Wasm.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\_Imports.razor"
using BlazorTrainPlaying_Wasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\_Imports.razor"
using BlazorTrainPlaying_Wasm.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/modals")]
    public partial class Modals : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Modal dialogs</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h2>Open source Blazored Modal</h2>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card mb-4");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.OpenElement(6, "p");
            __builder.AddAttribute(7, "class", "card-text");
            __builder.OpenElement(8, "code");
            __builder.AddContent(9, 
#nullable restore
#line 10 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\Pages\Modals.razor"
                  "Just an example of usage: Modal.Show<Confirm>(\"Welcome to Blazored Modal\", options);"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\Pages\Modals.razor"
                  ShowModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "class", "btn btn-primary");
            __builder.AddContent(14, "Show Modal");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n");
            __builder.AddMarkupContent(16, "<div><p>Checkout installation and usage:</p>\r\n    <a href=\"https://github.com/Blazored/Modal\"></a></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\Pages\Modals.razor"
       

    [CascadingParameter]
    public IModalService Modal { get; set; }

    private void ShowModal() => Modal.Show<Confirm>("Welcome to Blazored Modal");

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
