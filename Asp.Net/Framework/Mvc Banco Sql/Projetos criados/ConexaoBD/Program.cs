using System;
using System.Data.SqlClient;

using BDProjeto.Dominio;

using DBProjeto.Aplicacao;

namespace DOS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var app = UsuarioAplicacaoConstrutor.UsuarioApADO();

            SqlConnection conexao = new SqlConnection(@"data source=HUGO-PC\SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=ExemploBD");
            conexao.Open();

           
           
            Console.Write("Digite o nome do usuário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o cargo do usuário: ");
            string cargo = Console.ReadLine();

            Console.Write("Digite a data de cadastro: ");
            string data = Console.ReadLine();

            var usuarios = new Usuarios
            {
                Nome = nome,
                Cargo = cargo,
                Data = DateTime.Parse(data)
                
            };

           // usuarios.Id = 5;

            app.Salvar(usuarios);
            

           


           var dados = app.ListarTodos();

            foreach(var usuario in dados)
            {
                Console.WriteLine("Id:{0}, Nome:{1}, Cargo:{2}, Data:{3}", usuario.Id, usuario.Nome, usuario.Cargo, usuario.Data);
            }
        }
    }
}
