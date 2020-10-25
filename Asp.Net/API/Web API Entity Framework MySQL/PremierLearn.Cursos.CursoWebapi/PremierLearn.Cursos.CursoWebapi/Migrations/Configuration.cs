namespace PremierLearn.Cursos.CursoWebapi.Migrations
{
    using Newtonsoft.Json;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Http;

    internal sealed class Configuration : DbMigrationsConfiguration<PremierLearn.Cursos.CursoWebapi.Models.Context.BancoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());
        }
    }
}
