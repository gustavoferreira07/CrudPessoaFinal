using CrudPessoas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CrudPessoas.DAL.EntityConfiguration
{
    public class PessoaConfiguration: EntityTypeConfiguration<PessoaModel>
    {
        public PessoaConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.Nome).IsRequired().HasMaxLength(150);
            Property(c => c.CPF).IsRequired();            
        }
    }
}