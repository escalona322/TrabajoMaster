#pragma checksum "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9bb9adb1a3f28154531db27282589ab4821aa93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jugadores_PerfilJugador), @"mvc.1.0.view", @"/Views/Jugadores/PerfilJugador.cshtml")]
namespace AspNetCore
{
    #line hidden
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
#nullable restore
#line 3 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9bb9adb1a3f28154531db27282589ab4821aa93", @"/Views/Jugadores/PerfilJugador.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6b6a8b764c0663de323939f088c673011efca13", @"/Views/_ViewImports.cshtml")]
    public class Views_Jugadores_PerfilJugador : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Jugador>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Torneos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetallesTorneo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
  
    List<Torneo> torneos = new List<Torneo>();
    foreach (Torneo torneo in (IEnumerable<Torneo>)ViewData["TORNEOS"])
    {
        torneos.Add(torneo);
    }

    List<VistaSetFormateado> sets = new List<VistaSetFormateado>();
    foreach (VistaSetFormateado set in (IEnumerable<VistaSetFormateado>)ViewData["SETS"])
    {
        sets.Add(set);
    }

            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-2\" style=\"background-color: lightgray; height: 25em\">\r\n        <div class=\"row my-3\">\r\n");
#nullable restore
#line 20 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
             if(Model.Equipo != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span style=\"font-weight: bold; color: darkred; font-size: 1.2em\">");
#nullable restore
#line 22 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                                                             Write(Model.Equipo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | </span>\r\n");
#nullable restore
#line 23 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span style=\"font-weight: bold; color: red; font-size: 1.2em \">");
#nullable restore
#line 24 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                                                      Write(Model.Nick);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"row my-3\">\r\n            <span style=\"font-weight: bold; color: red; font-size: 1.2em \">Nombre: ");
#nullable restore
#line 27 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                                                              Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"row my-3\">\r\n            <span style=\"font-weight: bold; color: red; font-size: 1.2em \">Email: ");
#nullable restore
#line 30 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                                                             Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"row my-3\">\r\n            <span style=\"font-weight: bold; color: red; font-size: 1.2em \">Region: ");
#nullable restore
#line 33 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                                                              Write(Model.Region);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>     \r\n    </div>\r\n    <div class=\"col-10\">\r\n        <div style=\"height: 20em; overflow: scroll;overflow-x: hidden \">\r\n");
#nullable restore
#line 38 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
              
                if (sets.Count == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row mx-2\">\r\n                        <h2>Este jugador no tiene sets guardados</h2>\r\n                    </div>\r\n");
#nullable restore
#line 44 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"background-color: lightgreen\">\r\n                        <h1 class=\"text-center\"> SETS</h1>\r\n                    </div>\r\n                    <div class=\"row mx-2\">\r\n                        <h3 class=\"text-center\"> ");
#nullable restore
#line 51 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                            Write(sets.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" sets jugados, ");
#nullable restore
#line 51 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                                                      Write(ViewData["SETSGANADOS"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Victorias | Winrate: ");
#nullable restore
#line 51 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                                                                                                    Write(ViewData["WINRATE"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 54 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                    int contador = 0;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                     foreach (VistaSetFormateado set in sets)
                    {
                        if (contador % 2 == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""row"" style=""background-color: lightpink"">

                                <div class=""col my-3"">
                                    <span style=""font-size: 1.20em; font-weight: bold; color:green"">
                                        R: ");
#nullable restore
#line 63 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                      Write(set.Ronda);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </span>
                                </div>
                                <div class=""col my-3"">

                                    <span style=""font-size: 1.20em; font-weight: bold"">
                                        ");
#nullable restore
#line 69 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                   Write(set.Nick1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"color:red; font-weight:bold\">VS</span> ");
#nullable restore
#line 69 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                                                                                  Write(set.Nick2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </span>
                                </div>
                                <div class=""col my-3"">
                                    <span style=""font-size:1.20em; font-weight:bold; color: limegreen""> Ganador: ");
#nullable restore
#line 73 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                                                                                            Write(set.NickGanador);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"col my-3\">\r\n                                    <span style=\"font-size:1.20em; font-weight:bold\">\r\n                                        | Result: ");
#nullable restore
#line 77 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                             Write(set.Resultado);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </span>\r\n                                </div>\r\n                                <div class=\"col my-3\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9bb9adb1a3f28154531db27282589ab4821aa9313658", async() => {
                WriteLiteral("\r\n                                        Ver torneo\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idtorneo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                               WriteLiteral(set.IdTorneo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idtorneo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idtorneo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idtorneo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 89 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""row"" style=""background-color: lightcyan"">
                                <div class=""col my-3"">
                                    <span style=""font-size: 1.20em; font-weight: bold; color:green"">
                                        R: ");
#nullable restore
#line 95 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                      Write(set.Ronda);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </span>
                                </div>
                                <div class=""col my-3"">

                                    <span style=""font-size: 1.20em; font-weight: bold"">
                                        ");
#nullable restore
#line 101 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                   Write(set.Nick1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"color:red; font-weight:bold\">VS</span> ");
#nullable restore
#line 101 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                                                                                  Write(set.Nick2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </span>
                                </div>
                                <div class=""col my-3"">
                                    <span style=""font-size:1.20em; font-weight:bold; color: limegreen""> Ganador: ");
#nullable restore
#line 105 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                                                                                            Write(set.NickGanador);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"col my-3\">\r\n                                    <span style=\"font-size:1.20em; font-weight:bold\">\r\n                                        | Result: ");
#nullable restore
#line 109 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                             Write(set.Resultado);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </span>\r\n                                </div>\r\n                                <div class=\"col my-3\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9bb9adb1a3f28154531db27282589ab4821aa9319442", async() => {
                WriteLiteral("\r\n                                        Ver torneo\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idtorneo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 116 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                               WriteLiteral(set.IdTorneo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idtorneo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idtorneo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idtorneo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 121 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                        }
                        contador++;
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                     
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 130 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
          
            if (torneos.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <h2>Este jugador no se ha apuntado a ningun torneo</h2>\r\n\r\n                </div>\r\n");
#nullable restore
#line 137 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
            }
            else
            {
                int cont = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("       <div style=\"height: 20em; overflow: scroll; overflow-x: hidden\">\r\n        <div style=\"background-color: lightyellow\">\r\n            <h1 class=\"text-center\"> TORNEOS</h1>\r\n        </div>\r\n        \r\n");
#nullable restore
#line 146 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
         foreach (Torneo tor in torneos)
        {
            if (cont % 2 == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\" style=\"background-color: lightcoral\">\r\n\r\n                    <div class=\"col my-3\">\r\n                        <span style=\"font-size: 1.20em; font-weight: bold; color:green\">\r\n                            ");
#nullable restore
#line 154 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                       Write(tor.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                    <div class=\"col my-3\">\r\n\r\n                        <span style=\"font-size: 1.20em; font-weight: bold\">\r\n                            ");
#nullable restore
#line 160 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                       Write(tor.Region);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                    <div class=\"col my-3\">\r\n                        <span style=\"font-size: 1.20em; font-weight: bold\">\r\n                            Entrants: ");
#nullable restore
#line 165 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                 Write(tor.Napuntados);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                    <div class=\"col my-3\">\r\n                        <span style=\"font-size:1.20em; font-weight:bold\">\r\n                            | Tipo: ");
#nullable restore
#line 170 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                               Write(tor.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                    <div class=\"col my-3\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9bb9adb1a3f28154531db27282589ab4821aa9326059", async() => {
                WriteLiteral("\r\n                            Ver torneo\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idtorneo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 177 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                   WriteLiteral(tor.IdTorneo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idtorneo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idtorneo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idtorneo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 182 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\" style=\"background-color: lightgreen\">\r\n                    <div class=\"col my-3\">\r\n                        <span style=\"font-size: 1.20em; font-weight: bold; color:green\">\r\n                            ");
#nullable restore
#line 188 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                       Write(tor.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                    <div class=\"col my-3\">\r\n\r\n                        <span style=\"font-size: 1.20em; font-weight: bold\">\r\n                            ");
#nullable restore
#line 194 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                       Write(tor.Region);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                    <div class=\"col my-3\">\r\n                        <span style=\"font-size: 1.20em; font-weight: bold\">\r\n                            Entrants: ");
#nullable restore
#line 199 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                 Write(tor.Napuntados);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>                         \r\n                    </div>\r\n                    <div class=\"col my-3\">\r\n                        <span style=\"font-size:1.20em; font-weight:bold\">\r\n                            | Tipo: ");
#nullable restore
#line 204 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                               Write(tor.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                    <div class=\"col my-3\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9bb9adb1a3f28154531db27282589ab4821aa9331081", async() => {
                WriteLiteral("\r\n                            Ver torneo\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idtorneo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 211 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                                   WriteLiteral(tor.IdTorneo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idtorneo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idtorneo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idtorneo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 216 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
            }
            cont++;

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 221 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\PerfilJugador.cshtml"
                    
            }
         

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n   </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Jugador> Html { get; private set; }
    }
}
#pragma warning restore 1591
