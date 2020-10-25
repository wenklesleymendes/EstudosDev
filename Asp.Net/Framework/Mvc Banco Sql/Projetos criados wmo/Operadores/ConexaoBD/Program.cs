using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBD
{
    class Program
    {
        static void Main(string[] args)
        {
            //var conexao = new SqlConnection(@"data source=NTMENDES\NEWSHP; Integrated Security=SSPI; Initial Catalog=SistemaMNG");
            //conexao.Open();

            //string strQueryUpdate = "UPDATE Operadores SET NOME = 'Wenklesley Mendes Oliveira' " +
            //                        "WHERE CODIGO = 1";
            //SqlCommand cmdQueryUpdate = new SqlCommand(strQueryUpdate, conexao);
            //cmdQueryUpdate.ExecuteNonQuery();

            //string strQueryDelete = "DELETE FROM Operadores WHERE CODIGO = 3";
            //SqlCommand cmdQueryDelete = new SqlCommand(strQueryDelete, conexao);
            //cmdQueryDelete.ExecuteNonQuery();

            Console.Write("Digite o nome do Operador: ");
            string nome = Console.ReadLine();


            Console.Write("Digite o cargo do Operador: ");
            string cargo = Console.ReadLine();


            Console.Write("Digite a data do cadastro: ");
            string data = Console.ReadLine();

            string strQueryInsert = $"INSERT INTO Operadores(NOME, CARGO, DATA) " +
                                    $"VALUES ('{nome}' , '{cargo}', '{data}')";

            SqlCommand cmdQueryInsert = new SqlCommand(strQueryInsert, conexao);
            cmdQueryInsert.ExecuteNonQuery();


            string strQuerySelect = "SELECT * FROM Operadores";
            SqlCommand cmdCommandSelect = new SqlCommand(strQuerySelect, conexao);
            SqlDataReader dados = cmdCommandSelect.ExecuteReader();

            while (dados.Read())
            {
                Console.WriteLine($"Codigo:{dados["CODIGO"]} " +
                                  $"Nome:{dados["NOME"]} " +
                                  $"Cargo:{dados["CARGO"]} " +
                                  $"Data: {dados["DATA"]} ");
            }
        }
    }
}
