#pragma checksum "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38296b8f7365ec1daab31bf678bc2c237f6904ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prestamos_Index), @"mvc.1.0.view", @"/Views/Prestamos/Index.cshtml")]
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
#line 1 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\_ViewImports.cshtml"
using Prestamos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\_ViewImports.cshtml"
using Prestamos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38296b8f7365ec1daab31bf678bc2c237f6904ab", @"/Views/Prestamos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dafb0e09d8695b375a7bade3da5e5653ec9a115f", @"/Views/_ViewImports.cshtml")]
    public class Views_Prestamos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Prestamos.Models.Prestamo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Index.cshtml"
  
    ViewData["Title"] = "Prestamos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Listado de prestamos</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38296b8f7365ec1daab31bf678bc2c237f6904ab4151", async() => {
                WriteLiteral("Crear nuevo prestamo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-striped table-dark\">\r\n    <thead ");
            WriteLiteral("\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Capital));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Intereses));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Periodo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Clientes.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Capital));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Intereses));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Periodo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Clientes.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a class=\"btn btn-success\" asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1312, "\"", 1335, 1);
#nullable restore
#line 46 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Index.cshtml"
WriteAttributeValue("", 1327, item.Id, 1327, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a> |\r\n                <a class=\"btn btn-warning\" asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1414, "\"", 1437, 1);
#nullable restore
#line 47 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Index.cshtml"
WriteAttributeValue("", 1429, item.Id, 1429, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detalles</a> |\r\n                <a class=\"btn btn-danger\" asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1516, "\"", 1539, 1);
#nullable restore
#line 48 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Index.cshtml"
WriteAttributeValue("", 1531, item.Id, 1531, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Eliminar</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\Keven\OneDrive\Escritorio\Calculadora Prestamos\Prestamos\Prestamos\Views\Prestamos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Prestamos.Models.Prestamo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
