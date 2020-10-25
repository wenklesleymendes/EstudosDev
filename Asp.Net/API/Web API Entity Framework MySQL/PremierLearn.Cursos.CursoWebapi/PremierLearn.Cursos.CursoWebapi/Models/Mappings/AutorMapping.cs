using PremierLearn.Cursos.CursoWebapi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace PremierLearn.Cursos.CursoWebapi.Models.Mappings
{
    public class AutorMapping : EntityTypeConfiguration<Autor>       
    {
        public AutorMapping()
        {
            ToTable("tbl_autores");
            HasKey(a => a.Id);
            Property(a => a.Nome).IsRequired().HasMaxLength(100);
            Property(a => a.Email).IsRequired();
            Property(a => a.Observacao).HasMaxLength(2000);
            Property(a => a.QuantidadeLivrosVendidos).HasColumnName("qntdLivrosVendidos");
        }
    }
}