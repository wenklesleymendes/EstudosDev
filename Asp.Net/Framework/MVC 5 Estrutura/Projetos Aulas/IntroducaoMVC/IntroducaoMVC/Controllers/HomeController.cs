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
                RepresentacaoDados = "ViewTipada",
                PesssoaId = 4,
                Nome = "Eliete Aparecida Silva Mendes",
                Tipo = "Desenvolvedor"
            };

            
            return View(pessoa);
        }

        public ActionResult IndexVDB()
        {
            var pessoaViewData = new Pessoa()
            {
                RepresentacaoDados = "ViewData",
                PesssoaId = 1,
                Nome = "Wenklesley Mendes Oliveira",
                Tipo = "Desenvolvedor"
            };

            ViewData["RepresentacaoDados"] = pessoaViewData.RepresentacaoDados;
            ViewData["PesssoaId"] = pessoaViewData.PesssoaId;
            ViewData["Nome"] = pessoaViewData.Nome;
            ViewData["Tipo"] = pessoaViewData.Tipo;

            var pessoaViewBag = new Pessoa()
            {
                RepresentacaoDados = "ViewBag",
                PesssoaId = 2,
                Nome = "Kaio Nathan Silva Mendes",
                Tipo = "Professor de Linguas estrangeiras"
            };

            ViewBag.Dados = pessoaViewBag.RepresentacaoDados;
            ViewBag.Id = pessoaViewBag.PesssoaId;
            ViewBag.Nome = pessoaViewBag.Nome;
            ViewBag.Tipo = pessoaViewBag.Tipo;

            return View();
        }

        public ActionResult IndexVTP()
        {
            var pessoaViewTipada = new Pessoa()
            {
                RepresentacaoDados = "ViewTipada",
                PesssoaId = 3,
                Nome = "Henrry Gabriel Silva Mendes",
                Tipo = "Administrador Financeiro"
            };

            return View(pessoaViewTipada);
        }

        public  ActionResult Contatos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lista()
        {
            return View();
        }
    }
}