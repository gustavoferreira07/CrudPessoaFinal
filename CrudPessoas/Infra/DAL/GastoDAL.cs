using CrudPessoas.DAL.EntityContext;
using CrudPessoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPessoas.DAL
{
    public class GastoDAL
    {
        public void InsertRange(IEnumerable<GastoModel> gasto)
        {
            using(var context = new Context())
            {
                context.Gastos.AddRange(gasto);
                context.SaveChanges();
            }
        }

        public List<GastoModel> GetAll()
        { 
           
            using(var context = new Context())
            {
                var retorno = context.Gastos.ToList();
                List<GastoModel> gastos = new List<GastoModel>();
                foreach (var item in retorno)
                {
                    item.Pessoa = context.Pessoas.Where(p => p.Id == item.idPessoa).FirstOrDefault();
                    gastos.Add(item);
                }
                return gastos;
            }
        }

    }
}