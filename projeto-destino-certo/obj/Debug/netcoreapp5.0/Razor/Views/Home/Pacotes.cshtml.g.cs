#pragma checksum "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Pacotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e54594a1ca3a43352168803d9c6d7eed734c1487"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Pacotes), @"mvc.1.0.view", @"/Views/Home/Pacotes.cshtml")]
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
#line 1 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/_ViewImports.cshtml"
using projeto_destino_certo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/_ViewImports.cshtml"
using projeto_destino_certo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Pacotes.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e54594a1ca3a43352168803d9c6d7eed734c1487", @"/Views/Home/Pacotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62dc632e00c762f86a3e907f5348c6ae15d28f1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Pacotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pacotes>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icones-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icone-pacotes.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icone-shopping.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("icone-sacola"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icone-add.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Adicionar novo pacote"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registro_Pacotes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icone-close.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Remover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Pacotes.cshtml"
  
    ViewData["Title"] = "Pacotes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<main class=\"fundo-color\" style=\"min-height: 100vh;\"> \n<div class=\"pacotes-content\">  \n<div>\n    <div class=\"icone-titulo\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e54594a1ca3a43352168803d9c6d7eed734c14877242", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<h3 class=\"titulos\">PACOTES</h3></div>\n</div>\n<a href=\"listagem.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e54594a1ca3a43352168803d9c6d7eed734c14878413", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\n</div>\n<p class=\"paragrafos\">Aproveite agora os descontos exclusivos com parcelamento em até 15x sem juros! Não perca essa chance, compre e viaje quando quiser!</p>\n<div class=\"pacotes-cards\"> \n\n");
#nullable restore
#line 17 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Pacotes.cshtml"
 foreach (Pacotes p in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <style>
.card06{
    background-image: url(""../img/card-default.png"");
    background-size: contain;
    background-position: top;
    background-repeat: no-repeat;  
}
</style>
 <div class=""cards cards-text card06""> 
    <div class=""card-button"">
   
");
#nullable restore
#line 30 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Pacotes.cshtml"
    if(Context.Session.GetString("conta") == "usuario")
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <style>\n                    .card-button a {\n                     display: none;\n                    }\n                </style>\n");
#nullable restore
#line 38 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Pacotes.cshtml"
                }  

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Pacotes.cshtml"
      if(Context.Session.GetString("conta") == "administrador")
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <style>\n                    .card-button a {\n                     display: block;\n                    }\n                </style>\n");
#nullable restore
#line 47 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Pacotes.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Pacotes.cshtml"
      if(Context.Session.GetString("conta") == "colaborador")
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <style>\n                    .card-button a {\n                     display: block;\n                    }\n                </style>\n");
#nullable restore
#line 56 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Pacotes.cshtml"
                }                                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e54594a1ca3a43352168803d9c6d7eed734c148712196", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e54594a1ca3a43352168803d9c6d7eed734c148712412", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    <a class=\"button\"");
            BeginWriteAttribute("href", " href=\"", 1871, "\"", 1908, 2);
            WriteAttributeValue("", 1878, "/Home/Excluir_Pacotes?id=", 1878, 25, true);
#nullable restore
#line 59 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Pacotes.cshtml"
WriteAttributeValue("", 1903, p.id, 1903, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e54594a1ca3a43352168803d9c6d7eed734c148715048", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\n    </div>       \n<h6>");
#nullable restore
#line 61 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Pacotes.cshtml"
Write(p.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n<p>Saindo de ");
#nullable restore
#line 62 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Pacotes.cshtml"
        Write(p.origem);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>Saída: ");
#nullable restore
#line 62 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Pacotes.cshtml"
                             Write(p.saida);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>Retorno: ");
#nullable restore
#line 62 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Pacotes.cshtml"
                                                  Write(p.retorno);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>Preço ida e volta de: <br><b>");
#nullable restore
#line 62 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Pacotes.cshtml"
                                                                                             Write(p.preco);

#line default
#line hidden
#nullable disable
            WriteLiteral(" R$</b><br><i>Usuário: ");
#nullable restore
#line 62 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Pacotes.cshtml"
                                                                                                                            Write(p.usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\n</div>    \n");
#nullable restore
#line 64 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Pacotes.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n</main>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pacotes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
