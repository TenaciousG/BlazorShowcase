#pragma checksum "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\Pages\Binding.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48f1d8c904ec93b846e6e86df8457f06b9a1ea48"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Binding")]
    public partial class Binding : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Binding</h3>\n\n");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, 
#nullable restore
#line 4 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\Pages\Binding.razor"
     Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.AddMarkupContent(4, "<h2>Two way default</h2>\n");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "style", "width: 50%;");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\Pages\Binding.razor"
              Message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Message = __value, Message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n\n");
            __builder.AddMarkupContent(10, "<h2>Two way oninput</h2>\n");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "style", "width: 50%;");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\Pages\Binding.razor"
              Message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Message = __value, Message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n\n");
            __builder.AddMarkupContent(16, "<h2>Two way oninput keyuphandler</h2>\n");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\Pages\Binding.razor"
                                                       KeyUpHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "style", "width: 50%;");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\Pages\Binding.razor"
              Message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Message = __value, Message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\GlenOlsen\source\repos\BlazorTrain\BlazorTrainPlaying_Wasm\Client\Pages\Binding.razor"
       
    

    public string Message { get; set; } = "Two way bound message";

    private void KeyUpHandler(KeyboardEventArgs obj)
    {
        Console.WriteLine("Key released");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
