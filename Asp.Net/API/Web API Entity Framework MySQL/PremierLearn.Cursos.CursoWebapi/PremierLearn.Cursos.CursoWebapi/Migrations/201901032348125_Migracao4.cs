namespace PremierLearn.Cursos.CursoWebapi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracao4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Livros", "CodigoEditora", "Editoras");
            DropIndex("Livros", new[] { "CodigoEditora" });
            CreateIndex("Livros", "CodigoEditora");
            AddForeignKey("Livros", "CodigoEditora", "Editoras", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livros", "CodigoEditora", "dbo.Editoras");
            DropIndex("dbo.Livros", new[] { "CodigoEditora" });
            CreateIndex("dbo.Livros", "CodigoEditora");
            AddForeignKey("dbo.Livros", "CodigoEditora", "dbo.Editoras", "Id", cascadeDelete: true);
        }
    }
}
