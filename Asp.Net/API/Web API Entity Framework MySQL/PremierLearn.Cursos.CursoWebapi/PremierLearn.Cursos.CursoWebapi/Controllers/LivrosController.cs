﻿using PremierLearn.Cursos.CursoWebapi.Models.Context;
using PremierLearn.Cursos.CursoWebapi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.OData;
//using System.Web.Http.OData;

namespace PremierLearn.Cursos.CursoWebapi.Controllers
{
    public class LivrosController : ApiController
    {
        BancoContext db = new BancoContext();

        //Get
        //Post
        //Put
        //Delete

        public IHttpActionResult PostLivro(Livro livro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Livros.Add(livro);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = livro.Codigo }, livro);
        }

        [EnableQuery(AllowedQueryOptions = System.Web.Http.OData.Query.AllowedQueryOptions.OrderBy)]
        public IHttpActionResult GetLivros(int pagina = 1, int quantidadeItens = 50)
        {
            if (pagina <= 0 || quantidadeItens <= 0)
                return BadRequest("Os parâmetros 'página e 'quantidadeItens' devem ser maiores que zero.");

            if (quantidadeItens > 50)
                return BadRequest("O tamanho máximo de página permitido é 50.");

            int totalPaginas = (int)Math.Ceiling(db.Livros.Count() / Convert.ToDecimal(quantidadeItens));

            if (pagina > totalPaginas)
                return NotFound();

            HttpContext.Current.Response.AddHeader("X-Desenvolvedor", "Fernando Carmo");

            HttpContext.Current.Response.AddHeader("X-Paginacao-TotalPaginas", totalPaginas.ToString());

            if (pagina > 1)
                HttpContext.Current.Response.AddHeader("X-Paginacao-PaginaAnterior",
                    Url.Link("DefaultComActionApi", new { pagina = pagina - 1, quantidadeItens = quantidadeItens }));

            if (totalPaginas > pagina)
                HttpContext.Current.Response.AddHeader("X-Paginacao-ProximaPagina",
                    Url.Link("DefaultComActionApi", new { pagina = pagina + 1, quantidadeItens = quantidadeItens }));

            var livros = db.Livros.OrderBy(c => c.Codigo).Skip(quantidadeItens * (pagina - 1)).Take(quantidadeItens);

            return Ok(livros);
        }

        public IHttpActionResult GetLivro(int id)
        {
            if (id <= 0)
                return BadRequest("O Código do livro deve ser maior que 0");

            var livro = db.Livros.Find(id);
            if (livro == null)
                return NotFound();
            return Ok(livro);
        }

        public IHttpActionResult PutLivro(int id, Livro livro)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != livro.Codigo)
                return BadRequest("O Id informado na URL é diferente do código do livro");

            if (db.Livros.Count(l => l.Codigo == livro.Codigo) == 0)
                return NotFound();

            db.Entry(livro).State = EntityState.Modified;

            //Livro livroOriginal = db.Livros.Find(id);
            //db.Entry(livroOriginal).CurrentValues.SetValues(livro);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        public IHttpActionResult DeleteLivro(int id)
        {
            if (id <= 0)
                return BadRequest("O ID deve ser maior que 0.");

            Livro livro = db.Livros.Find(id);

            if (livro == null)
                return NotFound();

            db.Entry(livro).State = EntityState.Deleted;

            //db.Livros.Remove(livro);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        //[HttpGet]
        //public IHttpActionResult RecuperarLivros(int pagina = 1, int quantidadeItens = 10)
        //{
        //    if (pagina <= 0 || quantidadeItens <= 0)
        //        return BadRequest("Os parâmetros 'página e 'quantidadeItens' devem ser maiores que zero.");

        //    if (quantidadeItens > 10)
        //        return BadRequest("O tamanho máximo de página permitido é 10.");

        //    int totalPaginas = (int)Math.Ceiling(db.Livros.Count() / Convert.ToDecimal(quantidadeItens));

        //    if (pagina > totalPaginas)
        //        return NotFound();

        //    HttpContext.Current.Response.AddHeader("X-Desenvolvedor", "Fernando Carmo");

        //    HttpContext.Current.Response.AddHeader("X-Paginacao-TotalPaginas", totalPaginas.ToString());

        //    if (pagina > 1)
        //        HttpContext.Current.Response.AddHeader("X-Paginacao-PaginaAnterior",
        //            Url.Link("DefaultComActionApi", new { pagina = pagina - 1, quantidadeItens = quantidadeItens }));

        //    if (totalPaginas > pagina)
        //        HttpContext.Current.Response.AddHeader("X-Paginacao-ProximaPagina",
        //            Url.Link("DefaultComActionApi", new { pagina = pagina + 1, quantidadeItens = quantidadeItens }));

        //    var livros = db.Livros.OrderBy(c => c.Codigo).Skip(quantidadeItens * (pagina - 1)).Take(quantidadeItens);

        //    return Ok(livros);
        //}

        //[HttpGet]
        //public IHttpActionResult RecuperarTodosLivros(int pagina = 1, int quantidadeItens = 10)
        //{
        //    if (pagina <= 0 || quantidadeItens <= 0)
        //        return BadRequest("Os parâmetros 'página e 'quantidadeItens' devem ser maiores que zero.");

        //    if (quantidadeItens > 10)
        //        return BadRequest("O tamanho máximo de página permitido é 10.");

        //    int totalPaginas = (int)Math.Ceiling(db.Livros.Count() / Convert.ToDecimal(quantidadeItens));

        //    if (pagina > totalPaginas)
        //        return NotFound();

        //    HttpContext.Current.Response.AddHeader("X-Desenvolvedor", "Fernando Carmo");

        //    HttpContext.Current.Response.AddHeader("X-Paginacao-TotalPaginas", totalPaginas.ToString());

        //    if (pagina > 1)
        //        HttpContext.Current.Response.AddHeader("X-Paginacao-PaginaAnterior",
        //            Url.Link("DefaultComActionApi", new { pagina = pagina - 1, quantidadeItens = quantidadeItens }));

        //    if (totalPaginas > pagina)
        //        HttpContext.Current.Response.AddHeader("X-Paginacao-ProximaPagina",
        //            Url.Link("DefaultComActionApi", new { pagina = pagina + 1, quantidadeItens = quantidadeItens }));

        //    var livros = db.Livros.OrderBy(c => c.Codigo).Skip(quantidadeItens * (pagina - 1)).Take(quantidadeItens);

        //    return Ok(livros);
        //}

        //[ActionName("MeuLivro")]

    }
}
