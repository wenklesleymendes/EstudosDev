using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace WebApp.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Data { get; set; }
        public string RA { get; set; }

        public List<Aluno> ListaAlunos()
        {
            var caminhoArquivo = HostingEnvironment.MapPath(@"~/App_Data\Base.json");
            var json = File.ReadAllText(caminhoArquivo);
            return JsonConvert.DeserializeObject<List<Aluno>>(json); ;
        }

        public bool ReescrevarArquivo(List<Aluno> listaAlunos)
        {
            var caminhoArquivo = HostingEnvironment.MapPath(@"~/App_Data\Base.json");
            var json = JsonConvert.SerializeObject(listaAlunos, Formatting.Indented);
            File.WriteAllText(caminhoArquivo, json);
            return true;
        }

        public Aluno Inserir(Aluno aluno)
        {
            var listaAlunos = this.ListaAlunos();
            var maxId = listaAlunos.Max(p => p.Id);
            aluno.Id = maxId + 1;
            listaAlunos.Add(aluno);

            ReescrevarArquivo(listaAlunos);

            return aluno;
        }

        public Aluno Atualizar(int idAluno, Aluno aluno)
        {
            var listaAlunos = this.ListaAlunos();
            var indiceAluno = listaAlunos.FindIndex(p => p.Id == aluno.Id);
            if (indiceAluno >= 0)
            {
                aluno.Id = idAluno;
                listaAlunos[indiceAluno] = aluno;
            }
            else
            {
                return null;
            }

            ReescrevarArquivo(listaAlunos);
            return aluno;
        }

        public bool Deletar(int idAluno)
        {
            var listaAlunos = this.ListaAlunos();
            var indiceAluno = listaAlunos.FindIndex(p => p.Id == idAluno);
            if (indiceAluno >= 0)
            {
                listaAlunos.RemoveAt(indiceAluno);
            }
            else
            {
                return false;
            }

            ReescrevarArquivo(listaAlunos);
            return true;
        }
    }
}