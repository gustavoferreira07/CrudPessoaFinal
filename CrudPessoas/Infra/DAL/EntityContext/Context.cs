using CrudPessoas.DAL.EntityConfiguration;
using CrudPessoas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace CrudPessoas.DAL.EntityContext
{
    public class Context: DbContext
    {
        public Context()
            : base("CrudPessoaConnection")
        {

        }
        public DbSet<PessoaModel> Pessoas { get; set; }
        public DbSet<GastoModel> Gastos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Remove a pluralização das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Deixa por padrão todos os campos tipo "string" sejam "varchar" no SQL, e não "NVarchar"
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            //Caso o tamanho do varchar não seja informado, ele atribui por padrão o valor de 100
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new PessoaConfiguration());            
            modelBuilder.Configurations.Add(new GastoConfiguration());
        }
    }
}