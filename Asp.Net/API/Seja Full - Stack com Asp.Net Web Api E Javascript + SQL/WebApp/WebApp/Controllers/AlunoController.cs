using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApp.Models;

namespace WebApp.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/Aluno")]
    public class AlunoController : ApiController
    {
        // GET: api/Aluno
        [HttpGet]
        [Route("Recuperar")]
        public IHttpActionResult Get()
        {
            try
            {
                var aluno = new Aluno();
                return Ok(aluno.ListaAlunos());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }

        // GET: api/Aluno/5
        [HttpGet]
        [Route("Recuperar")]
        public Aluno Get(int id)
        {
            var alunos = new Aluno();
            return alunos.ListaAlunos().Where(a => a.Id == id).FirstOrDefault();
        }

        // GET: api/Aluno/5
        [HttpGet]
        [Route(@"RecuperarPorDataNome/{data:regex([0-9]{4}\-[0-9])}/{nome:minlength(5)}")]
        public IHttpActionResult Recuperar(string data, string nome)
        {
            try
            {
                var aluno = new Aluno();
                IEnumerable< Aluno> alunos = aluno.ListaAlunos().Where(a => a.Data == data || a.Nome == nome);

                if (!alunos.Any())
                {
                    return NotFound();
                }

                return Ok(alunos);

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
                throw;
            }

        }

        // POST: api/Aluno
        public List<Aluno> Post(Aluno aluno)
        {
            var _aluno = new Aluno();
            _aluno.Inserir(aluno);

            return _aluno.ListaAlunos();
        }

        // PUT: api/Aluno/5
        public Aluno Put(int id, [FromBody] Aluno aluno)
        {
            var _aluno = new Aluno();
            return _aluno.Atualizar(id, aluno);
        }

        // DELETE: api/Aluno/5
        public void Delete(int id)
        {
            var _aluno = new Aluno();
            _aluno.Deletar(id);
        }
    }
}
