using BDProjeto.Dominio;
using BDProjeto.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDProjeto.RepositorioEF
{
    public class UsuarioRepositorioEF : IRepositorio<Usuarios>
    {

        private readonly BD bd;

        public UsuarioRepositorioEF()
        {
            bd = new BD();
        }

        public void Excluir(Usuarios entidade)
        {
            var usuarioExcluir = bd.usuario.First(x => x.Id == entidade.Id);
            bd.Set<Usuarios>().Remove(usuarioExcluir);
            bd.SaveChanges();
        }

        public Usuarios ListarPorId(string id)
        {
            int idint;
            Int32.TryParse(id, out idint);
            return bd.usuario.First(x => x.Id == idint);
        }

        public IEnumerable<Usuarios> ListarTodos()
        {
            return bd.usuario;
        }

        public void Salvar(Usuarios entidade)
        {
            if(entidade.Id > 0)
            {
                var usuarioAlterar = bd.usuario.First(x => x.Id == entidade.Id);
                usuarioAlterar.Nome = entidade.Nome;
                usuarioAlterar.Cargo = entidade.Cargo;
                usuarioAlterar.Data = entidade.Data;
            }else
            {
                bd.usuario.Add(entidade);
            }
            bd.SaveChanges();
        }
    }
}
