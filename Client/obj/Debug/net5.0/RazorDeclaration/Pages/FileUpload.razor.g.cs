// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Personal\Talks\BlazorFileManagement\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Personal\Talks\BlazorFileManagement\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Personal\Talks\BlazorFileManagement\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Personal\Talks\BlazorFileManagement\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Personal\Talks\BlazorFileManagement\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Personal\Talks\BlazorFileManagement\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Personal\Talks\BlazorFileManagement\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Personal\Talks\BlazorFileManagement\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Personal\Talks\BlazorFileManagement\client\_Imports.razor"
using client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Personal\Talks\BlazorFileManagement\client\_Imports.razor"
using client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Personal\Talks\BlazorFileManagement\client\Pages\FileUpload.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/files")]
    public partial class FileUpload : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Personal\Talks\BlazorFileManagement\client\Pages\FileUpload.razor"
 
    IBrowserFile file;
    public async Task OnInputFileChange(InputFileChangeEventArgs e)  
    {  
        file = e.File;  
        
    }  
  

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
