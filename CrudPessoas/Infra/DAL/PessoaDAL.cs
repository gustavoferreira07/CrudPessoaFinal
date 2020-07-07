using CrudPessoas.DAL.EntityContext;
using CrudPessoas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudPessoas.DAL
{
    public class PessoaDAL
    {
        public void AdicionaPessoa(PessoaModel pessoa)
        {
            using(var context = new Context())
            {
                context.Pessoas.Add(pessoa);
                context.SaveChanges();
            }
        }

        public IEnumerable<PessoaModel> GetAll()
        {
            using (var context = new Context())
            {
                return context.Pessoas.ToList();
            }
        }
        public void Update(PessoaModel pessoa)
        {
            using(var context = new Context())
            {
                context.Pessoas.Attach(pessoa);
                context.Entry(pessoa).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(PessoaModel pessoa)
        {
            using(var context = new Context())
            {
                context.Pessoas.Attach(pessoa);
                context.Entry(pessoa).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}