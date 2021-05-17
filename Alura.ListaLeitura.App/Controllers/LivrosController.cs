using Alura.ListaLeitura.App.Models;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alura.ListaLeitura.App.Logica
{
    public class LivrosController : Controller 
    {


        public IEnumerable<Livro> Livros { get; set; }
       

        public IActionResult ParaLer()
        {
       
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.ParaLer.Livros;
           
            return View("lista");

        
        }

        public IActionResult Lendo()
        {
          
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lendo.Livros;
            return View("lista");
        }

        public IActionResult Lidos()
        {

            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lidos.Livros;
            return View("lista");
        }

           public string Detalhes(int id)
        {
            var repo = new LivroRepositorioCSV();
            var livro = repo.Todos.First(l => l.Id == id);
            return livro.Detalhes();
        }

        public string  Teste()
        {
            return "Nova funcionalidade implementada";
        }
    }
}