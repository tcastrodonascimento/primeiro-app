using Microsoft.AspNetCore.Mvc;

namespace Primeiro_APP.Controllers
{
    


    public class AlunoController : Controller
    {
        [ViewData] public string nome { get; set; }
        [ViewData] public string sobrenome { get; set; }
        [ViewData] public string terceironome { get; set; }
        public IActionResult Index()
        {
            ViewBag.nota = "Aluno nota 10";
            ViewData["Escola"] = "Escola Pedro Fonseca";

            nome = "Thiago";
            sobrenome = "Vinicius";
            terceironome = "67";


            return View();
        }


        public IActionResult test()
        {
            TempData["MSG_EX"] = "mensagem do tempdata";
            return RedirectToAction("Resultado");
        }

        public IActionResult Resultado()
        {
           
            if (TempData["MSG_EX"] != null)
                ViewBag.exemplo = "Alunos do terceiro B";
            return View();
        }


    }

}
