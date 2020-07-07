using CrudPessoas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CrudPessoas.DAL.EntityConfiguration
{
    public class GastoConfiguration: EntityTypeConfiguration<GastoModel>
    {
        public GastoConfiguration()
        {
            HasKey(g => g.Id);
            Property(g => g.Descricao).IsRequired();
            Property(g => g.Valor).IsRequired();
            HasRequired(g => g.Pessoa).WithMany().HasForeignKey(g => g.idPessoa);
        }
    }
}