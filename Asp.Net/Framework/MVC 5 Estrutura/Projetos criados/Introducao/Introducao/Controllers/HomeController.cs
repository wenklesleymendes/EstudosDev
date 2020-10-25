using Introducao.Models;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Hugo Vasconcelos",
                Tipo = "Administrador"
            };

         
            return View(pessoa);
        }

        public ActionResult Contatos()
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