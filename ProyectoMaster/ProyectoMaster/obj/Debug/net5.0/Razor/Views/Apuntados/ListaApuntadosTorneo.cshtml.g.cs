#pragma checksum "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\Apuntados\ListaApuntadosTorneo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21c9387a4f8cad1222df9c572601030c6fbcc853"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Apuntados_ListaApuntadosTorneo), @"mvc.1.0.view", @"/Views/Apuntados/ListaApuntadosTorneo.cshtml")]
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
#line 1 "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\_ViewImports.cshtml"
using ProyectoMaster;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\_ViewImports.cshtml"
using ProyectoMaster.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c9387a4f8cad1222df9c572601030c6fbcc853", @"/Views/Apuntados/ListaApuntadosTorneo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a131a80764e5d065b60ee7c76a19709de0c16991", @"/Views/_ViewImports.cshtml")]
    public class Views_Apuntados_ListaApuntadosTorneo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<VistaApuntadosJugadores>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n    <h1 class=\"text-center\">\r\n        Lista apuntados torneos\r\n    </h1>\r\n");
#nullable restore
#line 6 "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\Apuntados\ListaApuntadosTorneo.cshtml"
     foreach (VistaApuntadosJugadores vista in @Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row my-1 border border-primary\">\r\n            <div class=\"container\">\r\n");
#nullable restore
#line 10 "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\Apuntados\ListaApuntadosTorneo.cshtml"
                 if (vista.Equipo != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span style=\"color:dimgrey\">");
#nullable restore
#line 12 "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\Apuntados\ListaApuntadosTorneo.cshtml"
                                           Write(vista.Equipo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | </span>\r\n");
#nullable restore
#line 13 "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\Apuntados\ListaApuntadosTorneo.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 14 "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\Apuntados\ListaApuntadosTorneo.cshtml"
                 Write(vista.Nick);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\Apuntados\ListaApuntadosTorneo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<VistaApuntadosJugadores>> Html { get; private set; }
    }
}
#pragma warning restore 1591