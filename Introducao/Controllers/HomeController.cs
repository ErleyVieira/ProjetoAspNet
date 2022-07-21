using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Erley Vieira",
                Tipo = "Administrador"
            };
            
            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;

            return View(pessoa);
        }

        //public ActionResult ()
        public ActionResult Contatos()
        {
            ViewBag.Message = "Contatos";

            return View();
        }
        public ActionResult Sobre()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        



    }
}