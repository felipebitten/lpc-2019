#pragma checksum "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Maior.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e1ecbb0cd9f9128a343c117b70520099fc4effb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contas_Maior), @"mvc.1.0.view", @"/Views/Contas/Maior.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contas/Maior.cshtml", typeof(AspNetCore.Views_Contas_Maior))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e1ecbb0cd9f9128a343c117b70520099fc4effb", @"/Views/Contas/Maior.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7148d09bdaf5ee1c3de96319a13883be2ceb053", @"/Views/_ViewImports.cshtml")]
    public class Views_Contas_Maior : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContadeLuz.Models.Conta>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 686, true);
            WriteLiteral(@"
</br></br>
<!-- <a href=""Contas/Create"" class=""btn btn-primary"">Nova Conta</a> -->
<a href=""Contas/Create"" class=""btn btn-primary"">Menor Consumo</a>
<a href=""Contas/Create"" class=""btn btn-primary"">Maior Consumo</a>
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
#line 25 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Maior.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
            BeginContext(779, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(818, 7, false);
#line 28 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Maior.cshtml"
               Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(825, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(853, 16, false);
#line 29 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Maior.cshtml"
               Write(item.dataLeitura);

#line default
#line hidden
            EndContext();
            BeginContext(869, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(897, 18, false);
#line 30 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Maior.cshtml"
               Write(item.numeroLeitura);

#line default
#line hidden
            EndContext();
            BeginContext(915, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(943, 10, false);
#line 31 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Maior.cshtml"
               Write(item.qtdKw);

#line default
#line hidden
            EndContext();
            BeginContext(953, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(981, 15, false);
#line 32 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Maior.cshtml"
               Write(item.valorConta);

#line default
#line hidden
            EndContext();
            BeginContext(996, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1024, 18, false);
#line 33 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Maior.cshtml"
               Write(item.dataPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(1042, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1070, 17, false);
#line 34 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Maior.cshtml"
               Write(item.mediaConsumo);

#line default
#line hidden
            EndContext();
            BeginContext(1087, 52, true);
            WriteLiteral("</td>\r\n                <td><a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", "\r\n                    href=\"", 1139, "\"", 1189, 2);
            WriteAttributeValue("", 1167, "Contas/Delete/", 1167, 14, true);
#line 36 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Maior.cshtml"
WriteAttributeValue("", 1181, item.id, 1181, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1190, 65, true);
            WriteLiteral(">Delete</a> </td>\r\n                <td><a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " \r\n                    href=\"", 1255, "\"", 1304, 2);
            WriteAttributeValue("", 1284, "Contas/Edit/", 1284, 12, true);
#line 38 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Maior.cshtml"
WriteAttributeValue("", 1296, item.id, 1296, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1305, 38, true);
            WriteLiteral(">Editar</a> </td>\r\n            </tr>\r\n");
            EndContext();
#line 40 "C:\Users\Felipe Bittencourt\Desktop\ContadeLuz\Views\Contas\Maior.cshtml"
        }

#line default
#line hidden
            BeginContext(1354, 20, true);
            WriteLiteral("    </table>\r\n</div>");
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
