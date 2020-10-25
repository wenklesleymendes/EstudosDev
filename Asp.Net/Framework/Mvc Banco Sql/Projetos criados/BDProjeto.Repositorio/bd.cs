using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace BDProjeto.Repositorio
{
    public class bd : IDisposable
    {
        private readonly SqlConnection conexao;
        public bd()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString);
            conexao.Open();
        }

        public void ExecutaComando(string strQuery)
        {
            var cmdComando = new SqlCommand
            {
                CommandText = strQuery,
                CommandType = CommandType.Text,
                Connection = conexao
            };
            cmdComando.ExecuteNonQuery();
        }

        public SqlDataReader ExecutaComandoComRetorno(string strQuery)
        {
            var cmdComandoSelect = new SqlCommand(strQuery, conexao);
            return cmdComandoSelect.ExecuteReader();
        }

        public void Dispose()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
