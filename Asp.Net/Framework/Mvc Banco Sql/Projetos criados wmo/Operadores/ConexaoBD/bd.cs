using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBD
{
    class bd : IDisposable
    {
        private readonly SqlConnection conexao;

        public bd()
        {
            conexao = new SqlConnection(@"data source=NTMENDES\NEWSHP; Integrated Security=SSPI; Initial Catalog=SistemaMNG");
            conexao.Open();
        }

        public void ExecultaCommando(string strQuery)
        {
            var cmd = new SqlCommand
            {
                CommandText = strQuery,
                CommandType = CommandType.Text,
                Connection =  conexao
            };
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


    }
}
