using IntroducaoMVC.Models;
using System.Web.Mvc;

namespace IntroducaoMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa()
            {
                Rd = $"View Tipada pelo metodo {nameof(Index)} ",
                PessoaId = 4,
                Nome = "Eliete Aparecida Silva Mendes",
                Tipo = "Desenvolvedor"
            };

            
            return View(pessoa);
        }

        public ActionResult IndexVDB()
        {
            var pessoaViewData = new Pessoa()
            {
                Rd = "ViewData",
                PessoaId = 1,
                Nome = "Wenklesley Mendes Oliveira",
                Tipo = "Desenvolvedor"
            };

            ViewData["RepresentacaoDados"] = pessoaViewData.Rd;
            ViewData["PesssoaId"] = pessoaViewData.PessoaId;
            ViewData["Nome"] = pessoaViewData.Nome;
            ViewData["Tipo"] = pessoaViewData.Tipo;

            var pessoaViewBag = new Pessoa()
            {
                Rd = "ViewBag",
                PessoaId = 2,
                Nome = "Kaio Nathan Silva Mendes",
                Tipo = "Professor de Linguas estrangeiras"
            };

            ViewBag.Dados = pessoaViewBag.Rd;
            ViewBag.Id = pessoaViewBag.PessoaId;
            ViewBag.Nome = pessoaViewBag.Nome;
            ViewBag.Tipo = pessoaViewBag.Tipo;

            return View();
        }

        public ActionResult IndexVTP()
        {
            var pessoa = new Pessoa()
            {
                Rd = $"View Tipada pelo metodo {nameof(IndexVTP)}",
                PessoaId = 3,
                Nome = "Henrry Gabriel Silva Mendes",
                Tipo = "Administrador Financeiro"
            };

            return View(pessoa);
        }

        public  ActionResult Contatos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            return View(pessoa);
        }
    }
}