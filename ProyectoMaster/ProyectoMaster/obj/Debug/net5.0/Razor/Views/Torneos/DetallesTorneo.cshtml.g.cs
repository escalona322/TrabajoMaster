#pragma checksum "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Torneos\DetallesTorneo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17d06c339ad7b7073c0180359c0ad86fff975fdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Torneos_DetallesTorneo), @"mvc.1.0.view", @"/Views/Torneos/DetallesTorneo.cshtml")]
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
#line 1 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\_ViewImports.cshtml"
using ProyectoMaster;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\_ViewImports.cshtml"
using ProyectoMaster.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17d06c339ad7b7073c0180359c0ad86fff975fdc", @"/Views/Torneos/DetallesTorneo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a131a80764e5d065b60ee7c76a19709de0c16991", @"/Views/_ViewImports.cshtml")]
    public class Views_Torneos_DetallesTorneo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>\r\n    Detalles torneo\r\n</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-1\">\r\n    </div>\r\n    <div class=\"col-5\">\r\n");
#nullable restore
#line 8 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Torneos\DetallesTorneo.cshtml"
          
            Torneo torneo = (Torneo)ViewData["TORNEO"];
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>");
#nullable restore
#line 11 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Torneos\DetallesTorneo.cshtml"
       Write(torneo.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>\r\n\r\n    </div>\r\n    <div class=\"col-5\">\r\n\r\n    </div>\r\n    <div class=\"col-1\">\r\n\r\n    </div>\r\n</div>");
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
