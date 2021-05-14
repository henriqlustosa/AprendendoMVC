using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alura.ListaLeitura.App.Logica;
using Alura.ListaLeitura.App.Mvc;

namespace Alura.ListaLeitura.App
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }
        public void Configure(IApplicationBuilder app)
        {
            //app.Run(Roteamento);
            var routeBuilder = new RouteBuilder(app);
            routeBuilder.MapRoute("{classe}/{metodo}", RoteamentoPadrao.TratamentoPadrao);
            //routeBuilder.MapRoute("Livros/ParaLer", LogicaLivros.ParaLer);
            //routeBuilder.MapRoute("Livros/Lendo", LogicaLivros.Lendo);
            //routeBuilder.MapRoute("Livros/Lidos", LogicaLivros.Lidos);
            //routeBuilder.MapRoute("Cadastro/NovoLivro/{nome}/{autor}", LogicaCadastro.NovoLivro);
            //routeBuilder.MapRoute("Cadastro/ExibeFormulario", LogicaCadastro.ExibeFormulario);
            //routeBuilder.MapRoute("Livros/Detalhes/{id:int}", LogicaLivros.Detalhes);
            //routeBuilder.MapRoute("Cadastro/Incluir", LogicaCadastro.Incluir);
            var rotas = routeBuilder.Build();

            app.UseRouter(rotas);

        }

        
   


        //public Task Roteamento(HttpContext context)
        //{
        //    var _repo = new LivroRepositorioCSV();

        //    var caminhosAtendidos = new Dictionary<string, RequestDelegate>
        //    {
        //        { "/Livros/ParaLer",LivrosParaLer },
        //        { "/Livros/Lendo",LivrosLendo },
        //        { "/Livros/Lidos" ,LivrosLidos}
        //    };
        //    if (caminhosAtendidos.ContainsKey(context.Request.Path))
        //    {
        //        var metodo = caminhosAtendidos[context.Request.Path];

        //        return metodo.Invoke(context);
        //    }
        //    else
        //    {
        //        context.Response.StatusCode = 404;
        //        return context.Response.WriteAsync("Caminho Inexistente");
        //    }



        //}

        

    }
}