using CrudPessoas.DAL;
using CrudPessoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPessoas.Repositories
{
    public class DashboardRepositories : IRepositoryBase<DashboardModel>
    {
        DashboardDAL dashboardDAL = new DashboardDAL();
        public void Add(DashboardModel obj)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<DashboardModel> obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DashboardModel> GetAll()
        {
            throw new NotImplementedException();
        }
        public DashboardModel Get()
        {
           return dashboardDAL.RetornaDash();
        }

        public DashboardModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(DashboardModel obj)
        {
            throw new NotImplementedException();
        }

        public void Update(DashboardModel obj)
        {
            throw new NotImplementedException();
        }
    }
}