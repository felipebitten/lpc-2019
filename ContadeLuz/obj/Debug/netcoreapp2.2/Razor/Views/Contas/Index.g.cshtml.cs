#pragma checksum "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55e9c2a01b8e69d33c4b4feb77697de7c507b09c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contas_Index), @"mvc.1.0.view", @"/Views/Contas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contas/Index.cshtml", typeof(AspNetCore.Views_Contas_Index))]
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
#line 1 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\_ViewImports.cshtml"
using ContadeLuz;

#line default
#line hidden
#line 2 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\_ViewImports.cshtml"
using ContadeLuz.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55e9c2a01b8e69d33c4b4feb77697de7c507b09c", @"/Views/Contas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7148d09bdaf5ee1c3de96319a13883be2ceb053", @"/Views/_ViewImports.cshtml")]
    public class Views_Contas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContadeLuz.Models.Conta>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 543, true);
            WriteLiteral(@"
</br></br>
<a href=""Contas/Create"" class=""btn btn-primary"">Nova Conta</a>
</br></br>

<div class=""container"">
    <table class=""table"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Data Leitura</th>
                <th>Numero Leitura</th>
                <th>Quantidade Kw</th>
                <th>Valor Conta</th>
                <th>Data Pagamento</th>
                <th>Media de Consumo</th>
                <th></th>
                <th></th>
            </tr>
        </thead>

");
            EndContext();
#line 23 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
            BeginContext(636, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(675, 7, false);
#line 26 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
               Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(682, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(710, 16, false);
#line 27 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
               Write(item.dataLeitura);

#line default
#line hidden
            EndContext();
            BeginContext(726, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(754, 18, false);
#line 28 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
               Write(item.numeroLeitura);

#line default
#line hidden
            EndContext();
            BeginContext(772, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(800, 10, false);
#line 29 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
               Write(item.qtdKw);

#line default
#line hidden
            EndContext();
            BeginContext(810, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(838, 15, false);
#line 30 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
               Write(item.valorConta);

#line default
#line hidden
            EndContext();
            BeginContext(853, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(881, 18, false);
#line 31 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
               Write(item.dataPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(899, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(927, 17, false);
#line 32 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
               Write(item.mediaConsumo);

#line default
#line hidden
            EndContext();
            BeginContext(944, 52, true);
            WriteLiteral("</td>\r\n                <td><a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", "\r\n                    href=\"", 996, "\"", 1046, 2);
            WriteAttributeValue("", 1024, "Contas/Delete/", 1024, 14, true);
#line 34 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
WriteAttributeValue("", 1038, item.id, 1038, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1047, 65, true);
            WriteLiteral(">Delete</a> </td>\r\n                <td><a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " \r\n                    href=\"", 1112, "\"", 1161, 2);
            WriteAttributeValue("", 1141, "Contas/Edit/", 1141, 12, true);
#line 36 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
WriteAttributeValue("", 1153, item.id, 1153, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1162, 38, true);
            WriteLiteral(">Editar</a> </td>\r\n            </tr>\r\n");
            EndContext();
#line 38 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1211, 607, true);
            WriteLiteral(@"    </table>
</div>
    <h3> Maior Consumo </h3>
    <div class=""container"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Data Leitura</th>
                    <th>Numero Leitura</th>
                    <th>Quantidade Kw</th>
                    <th>Valor Conta</th>
                    <th>Data Pagamento</th>
                    <th>Media de Consumo</th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
                <tr>
                    <td>");
            EndContext();
            BeginContext(1819, 17, false);
#line 58 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
                   Write(ViewBag.Maximo.id);

#line default
#line hidden
            EndContext();
            BeginContext(1836, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1868, 26, false);
#line 59 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
                   Write(ViewBag.Maximo.dataLeitura);

#line default
#line hidden
            EndContext();
            BeginContext(1894, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1926, 28, false);
#line 60 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
                   Write(ViewBag.Maximo.numeroLeitura);

#line default
#line hidden
            EndContext();
            BeginContext(1954, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1986, 20, false);
#line 61 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
                   Write(ViewBag.Maximo.qtdKw);

#line default
#line hidden
            EndContext();
            BeginContext(2006, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2038, 25, false);
#line 62 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
                   Write(ViewBag.Maximo.valorConta);

#line default
#line hidden
            EndContext();
            BeginContext(2063, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2095, 28, false);
#line 63 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
                   Write(ViewBag.Maximo.dataPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(2123, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2155, 27, false);
#line 64 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
                   Write(ViewBag.Maximo.mediaConsumo);

#line default
#line hidden
            EndContext();
            BeginContext(2182, 648, true);
            WriteLiteral(@"</td>
                </tr>
        </table>
    </div>

     <h3> Menor Consumo </h3>
    <div class=""container"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Data Leitura</th>
                    <th>Numero Leitura</th>
                    <th>Quantidade Kw</th>
                    <th>Valor Conta</th>
                    <th>Data Pagamento</th>
                    <th>Media de Consumo</th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
                <tr>
                    <td>");
            EndContext();
            BeginContext(2831, 17, false);
#line 86 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
                   Write(ViewBag.Minimo.id);

#line default
#line hidden
            EndContext();
            BeginContext(2848, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2880, 26, false);
#line 87 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
                   Write(ViewBag.Minimo.dataLeitura);

#line default
#line hidden
            EndContext();
            BeginContext(2906, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2938, 28, false);
#line 88 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
                   Write(ViewBag.Minimo.numeroLeitura);

#line default
#line hidden
            EndContext();
            BeginContext(2966, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2998, 20, false);
#line 89 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
                   Write(ViewBag.Minimo.qtdKw);

#line default
#line hidden
            EndContext();
            BeginContext(3018, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3050, 25, false);
#line 90 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
                   Write(ViewBag.Minimo.valorConta);

#line default
#line hidden
            EndContext();
            BeginContext(3075, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3107, 28, false);
#line 91 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
                   Write(ViewBag.Minimo.dataPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(3135, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3167, 27, false);
#line 92 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Index.cshtml"
                   Write(ViewBag.Minimo.mediaConsumo);

#line default
#line hidden
            EndContext();
            BeginContext(3194, 58, true);
            WriteLiteral("</td>\r\n                </tr>\r\n        </table>\r\n    </div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContadeLuz.Models.Conta>> Html { get; private set; }
    }
}
#pragma warning restore 1591