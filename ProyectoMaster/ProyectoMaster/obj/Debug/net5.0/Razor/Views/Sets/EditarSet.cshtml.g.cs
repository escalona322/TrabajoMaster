#pragma checksum "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Sets\EditarSet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f64dfae8eb64e1e5c4c10a7842cf0f90c461a60b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sets_EditarSet), @"mvc.1.0.view", @"/Views/Sets/EditarSet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f64dfae8eb64e1e5c4c10a7842cf0f90c461a60b", @"/Views/Sets/EditarSet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6b6a8b764c0663de323939f088c673011efca13", @"/Views/_ViewImports.cshtml")]
    public class Views_Sets_EditarSet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<VistaApuntadosTorneo>>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Sets\EditarSet.cshtml"
   
    string ronda = (string)ViewData["RONDA"];
    string resultado = (string)ViewData["RESULTADO"];

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f64dfae8eb64e1e5c4c10a7842cf0f90c461a60b4894", async() => {
                WriteLiteral("\r\n    <div class=\"input-group my-2\">\r\n        <label class=\"input-group-text\">Jugador 1</label>\r\n        <select name=\"ap1\" class=\"form-control\">\r\n");
#nullable restore
#line 10 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Sets\EditarSet.cshtml"
             foreach (VistaApuntadosTorneo vista in @Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f64dfae8eb64e1e5c4c10a7842cf0f90c461a60b5610", async() => {
                    WriteLiteral("\r\n                    ");
#nullable restore
#line 13 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Sets\EditarSet.cshtml"
               Write(vista.Nick);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Sets\EditarSet.cshtml"
                   WriteLiteral(vista.IdApuntado);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 15 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Sets\EditarSet.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n\r\n    </div>\r\n    <div class=\"input-group my-2\">\r\n        <label class=\"input-group-text\">Jugador 2</label>\r\n        <select name=\"ap2\" class=\"form-control\">\r\n");
#nullable restore
#line 22 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Sets\EditarSet.cshtml"
             foreach (VistaApuntadosTorneo vista in @Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f64dfae8eb64e1e5c4c10a7842cf0f90c461a60b8309", async() => {
                    WriteLiteral("\r\n                    ");
#nullable restore
#line 25 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Sets\EditarSet.cshtml"
               Write(vista.Nick);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Sets\EditarSet.cshtml"
                   WriteLiteral(vista.IdApuntado);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 27 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Sets\EditarSet.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n    </div>\r\n    <div class=\"input-group my-2\">\r\n        <label class=\"input-group-text\">Ganador</label>\r\n        <select name=\"apganador\" class=\"form-control\">\r\n");
#nullable restore
#line 33 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Sets\EditarSet.cshtml"
             foreach (VistaApuntadosTorneo vista in @Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f64dfae8eb64e1e5c4c10a7842cf0f90c461a60b11008", async() => {
                    WriteLiteral("\r\n                    ");
#nullable restore
#line 36 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Sets\EditarSet.cshtml"
               Write(vista.Nick);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Sets\EditarSet.cshtml"
                   WriteLiteral(vista.IdApuntado);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 38 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Sets\EditarSet.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n\r\n    </div>\r\n    <div class=\"input-group my-2\">\r\n        <label class=\"input-group-text\">Resultado: </label>\r\n        <input type=\"text\" name=\"resultado\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1513, "\"", 1531, 1);
#nullable restore
#line 44 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Sets\EditarSet.cshtml"
WriteAttributeValue("", 1521, resultado, 1521, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    </div>\r\n    <div class=\"input-group my-2\">\r\n        <label class=\"input-group-text\">Ronda: </label>\r\n        <input type=\"text\" name=\"ronda\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1701, "\"", 1715, 1);
#nullable restore
#line 48 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Sets\EditarSet.cshtml"
WriteAttributeValue("", 1709, ronda, 1709, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    </div>\r\n    <div class=\"input-group my-2\">\r\n");
#nullable restore
#line 51 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Sets\EditarSet.cshtml"
          
            int idtorneo = (int)ViewData["IDTORNEO"];
        

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"hidden\" name=\"torneo\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1909, "\"", 1926, 1);
#nullable restore
#line 54 "D:\TrabajosMaster\ProyectoMaster\ProyectoMaster\ProyectoMaster\Views\Sets\EditarSet.cshtml"
WriteAttributeValue("", 1917, idtorneo, 1917, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-outline-info form-control\">\r\n        Enviar\r\n    </button>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<VistaApuntadosTorneo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
