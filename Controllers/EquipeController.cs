using System;
using ASPNET_core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_CORE.Controllers
{
    [Route("Equipe")]
    public class EquipeController : Controller
    {
        Equipe EquipeModel = new Equipe();

        [Route("Index")]
        public IActionResult Index()
        {
            ViewBag.Equipe = EquipeModel.ReadAll();
            return View();
        }
        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe newEquipe = new Equipe();
            newEquipe.IdEquipe = Int32.Parse(form["IdEquipe"]);
            newEquipe.Nome = form["Nome"];
            newEquipe.Imagem = form["imagem"];
            
            EquipeModel.Create(newEquipe);            
            ViewBag.Equipes = EquipeModel.ReadAll();

            return LocalRedirect("~/Equipe/Index");

        }
    }
}