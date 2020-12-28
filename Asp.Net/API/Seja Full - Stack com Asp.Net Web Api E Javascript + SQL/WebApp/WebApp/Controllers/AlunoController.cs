using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AlunoController : ApiController
    {
        // GET: api/Aluno
        public IEnumerable<Aluno> Get()
        {
            return new Aluno().ListaAlunos();
        }

        // GET: api/Aluno/5
        public Aluno Get(int id)
        {
            var alunos = new Aluno();
            return alunos.ListaAlunos().Where(a => a.Id == id).FirstOrDefault();
        }

        // POST: api/Aluno
        public List<Aluno> Post(Aluno aluno)
        {
            var _aluno = new Aluno();
            _aluno.Inserir(aluno);

            return _aluno.ListaAlunos();
        }

        // PUT: api/Aluno/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Aluno/5
        public void Delete(int id)
        {
        }
    }
}
