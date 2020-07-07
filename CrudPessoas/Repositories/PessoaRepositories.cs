using CrudPessoas.DAL;
using CrudPessoas.DAL.EntityContext;
using CrudPessoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPessoas.Repositories
{
    public class PessoaRepositories : IRepositoryBase<PessoaModel>
    {
        PessoaDAL pessoaDAL = new PessoaDAL();
        public void Add(PessoaModel obj)
        {
            pessoaDAL.AdicionaPessoa(obj);
        }

        public void AddRange(IEnumerable<PessoaModel> obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PessoaModel> GetAll()
        {
            return pessoaDAL.GetAll();
        }

        public PessoaModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(PessoaModel obj)
        {
            pessoaDAL.Delete(obj);
        }

        public void Update(PessoaModel obj)
        {
             pessoaDAL.Update(obj);
        }
    }
}