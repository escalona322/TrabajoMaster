#pragma checksum "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\EditarJugador.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87d7bf4630f967280704292bfa686a836d4e6984"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jugadores_EditarJugador), @"mvc.1.0.view", @"/Views/Jugadores/EditarJugador.cshtml")]
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
#nullable restore
#line 3 "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87d7bf4630f967280704292bfa686a836d4e6984", @"/Views/Jugadores/EditarJugador.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b374ad3cd3a30e2a2e29e60184240e02b80b695c", @"/Views/_ViewImports.cshtml")]
    public class Views_Jugadores_EditarJugador : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Jugador>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group align-content-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87d7bf4630f967280704292bfa686a836d4e69844163", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"idjugador\"");
                BeginWriteAttribute("value", " value=\"", 119, "\"", 143, 1);
#nullable restore
#line 3 "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\EditarJugador.cshtml"
WriteAttributeValue("", 127, Model.IdJugador, 127, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    <div class=\"input-group my-2\">\r\n        <label class=\"input-group-text\">Nick: </label>\r\n        <input type=\"text\" name=\"nick\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 299, "\"", 318, 1);
#nullable restore
#line 6 "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\EditarJugador.cshtml"
WriteAttributeValue("", 307, Model.Nick, 307, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    </div>\r\n    <div class=\"input-group my-2\">\r\n        <label class=\"input-group-text\">Region: </label>\r\n        <input type=\"text\" name=\"region\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 490, "\"", 511, 1);
#nullable restore
#line 10 "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\EditarJugador.cshtml"
WriteAttributeValue("", 498, Model.Region, 498, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    </div>\r\n    <div class=\"input-group my-2\">\r\n        <label class=\"input-group-text\">Nombre: </label>\r\n        <input type=\"text\" name=\"nombre\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 683, "\"", 704, 1);
#nullable restore
#line 14 "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\EditarJugador.cshtml"
WriteAttributeValue("", 691, Model.Nombre, 691, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    </div>\r\n    <div class=\"input-group my-2\">\r\n        <label class=\"input-group-text\">Email: </label>\r\n        <input type=\"number\" name=\"email\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 876, "\"", 896, 1);
#nullable restore
#line 18 "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\EditarJugador.cshtml"
WriteAttributeValue("", 884, Model.Email, 884, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    </div>\r\n    <div class=\"input-group my-2\">\r\n        <label class=\"input-group-text\">Password: </label>\r\n        <input type=\"text\" name=\"password\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1072, "\"", 1095, 1);
#nullable restore
#line 22 "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\EditarJugador.cshtml"
WriteAttributeValue("", 1080, Model.Password, 1080, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    </div>\r\n    <div class=\"input-group my-2\">\r\n        <label class=\"input-group-text\">Rol: </label>\r\n        <input type=\"text\" name=\"rol\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1261, "\"", 1279, 1);
#nullable restore
#line 26 "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\EditarJugador.cshtml"
WriteAttributeValue("", 1269, Model.Rol, 1269, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    </div>\r\n    <div class=\"input-group my-2\">\r\n        <label class=\"input-group-text\">Equipo: </label>\r\n        <input type=\"text\" name=\"equipo\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1451, "\"", 1472, 1);
#nullable restore
#line 30 "C:\Users\AlumnoMCSD\source\repos\TrabajoMaster\ProyectoMaster\ProyectoMaster\Views\Jugadores\EditarJugador.cshtml"
WriteAttributeValue("", 1459, Model.Equipo, 1459, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-outline-info form-control\">\r\n        Enviar\r\n    </button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
