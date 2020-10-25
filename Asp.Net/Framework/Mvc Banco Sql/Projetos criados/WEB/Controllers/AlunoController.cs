using BDProjeto.Aplicacao;
using BDProjeto.Dominio;
using DBProjeto.Aplicacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEB.Controllers
{
    public class AlunoController : Controller
    {

       /* private UsuarioAplicacao appUsuario;
        public AlunoController()
        {
            appUsuario = UsuarioAplicacaoConstrutor.UsuarioApEF();
        }*/

        // GET: Aluno
        public ActionResult Index()
        {

            var appUsuario = UsuarioAplicacaoConstrutor.UsuarioApADO();
            var listaUsuarios = appUsuario.ListarTodos();
            return View(listaUsuarios);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Usuarios usuario)
        {
            if (ModelState.IsValid)
            {
                var appUsuario = UsuarioAplicacaoConstrutor.UsuarioApADO();
                appUsuario.Salvar(usuario);
                return RedirectToAction("Index");
            }
            
            return View(usuario);
        }



        public ActionResult Editar(string id)
        {
            var appUsuario = UsuarioAplicacaoConstrutor.UsuarioApADO();
            var usuario = appUsuario.ListarPorId(id);

            if(usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }


        [HttpPost]
        public ActionResult Editar(Usuarios usuario)
        {
            if (ModelState.IsValid)
            {
                var appUsuario = UsuarioAplicacaoConstrutor.UsuarioApADO();
                appUsuario.Salvar(usuario);
                return RedirectToAction("Index");
            }

            return View(usuario);
        }



        public ActionResult Detalhes(string id)
        {
            var appUsuario = UsuarioAplicacaoConstrutor.UsuarioApADO();
            var usuario = appUsuario.ListarPorId(id);

            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }



        public ActionResult Excluir(string id)
        {
           var appUsuario = UsuarioAplicacaoConstrutor.UsuarioApADO();
            var usuario = appUsuario.ListarPorId(id);

            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult ExcluirConfirmado(string id)
        {
            var appUsuario = UsuarioAplicacaoConstrutor.UsuarioApADO();
            var usuario = appUsuario.ListarPorId(id);
            appUsuario.Excluir(usuario);
            return RedirectToAction("Index");
        }


    }
}