using CrudPessoas.DAL;
using CrudPessoas.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPessoas.Repositories
{
    public class GraficoRepositories
    {
        GraficoDAL GraficoDAL = new GraficoDAL();
        public List<GraficoViewModel> GetAll()
        {
          return  GraficoDAL.RetornaGrafico();
        }
    }
}