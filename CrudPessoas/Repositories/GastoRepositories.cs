using CrudPessoas.DAL;
using CrudPessoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPessoas.Repositories
{
    public class GastoRepositories : IRepositoryBase<GastoModel>
    {
        GastoDAL gastoDAL = new GastoDAL();
        public void Add(GastoModel obj)
        {
            
        }

        public void AddRange(IEnumerable<GastoModel> obj)
        {
            gastoDAL.InsertRange(obj);
        }

        public IEnumerable<GastoModel> GetAll()
        {

            return gastoDAL.GetAll();
        }

        public GastoModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(GastoModel obj)
        {
            throw new NotImplementedException();
        }

        public void Update(GastoModel obj)
        {
            throw new NotImplementedException();
        }
    }
}