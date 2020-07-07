using CrudPessoas.DAL.EntityContext;
using CrudPessoas.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPessoas.DAL
{
    public class GraficoDAL
    {

        public List<GraficoViewModel> RetornaGrafico()
        {
            using(var context = new Context())
            {
                var retorno = context.Database.SqlQuery<GraficoViewModel>("select pessoa.Nome, SUM(gasto.Valor) as Valor from PessoaModel pessoa inner join GastoModel gasto on pessoa.Id = gasto.idPessoa group by nome").ToList();
                return retorno;
            }
        }
    }
}