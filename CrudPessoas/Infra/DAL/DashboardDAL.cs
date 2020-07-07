using CrudPessoas.DAL.EntityContext;
using CrudPessoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace CrudPessoas.DAL
{
    public class DashboardDAL
    {
        public DashboardModel RetornaDash()
        {
            DashboardModel dashboardModel = new DashboardModel();
            using(var context = new Context())
            {
                dashboardModel.PessoaMaisVelha = context
                    .Database
                    .SqlQuery<string>("select nome from PessoaModel where Idade = ( select  Max(idade) from PessoaModel)").FirstOrDefault();
                
                dashboardModel.MenorGasto = context
                    .Database
                    .SqlQuery<double>("select MIN(sel.valor) from(select sum(gasto.Valor) as valor from PessoaModel pessoa inner join GastoModel gasto on pessoa.Id = gasto.IdPessoa group by pessoa.Id) sel").FirstOrDefault();
               
                dashboardModel.Valortotal = context
                    .Database
                    .SqlQuery<double>(" select sum(valor) from GastoModel").FirstOrDefault();

                dashboardModel.PessoaComMaisGasto = context
                    .Database
                    .SqlQuery<string>("select sel.nome from (select pessoa.Nome, sum(gasto.Valor) as valor from PessoaModel pessoa inner join GastoModel gasto on pessoa.Id = gasto.IdPessoa group by pessoa.nome) sel where sel.valor = (select MAX(valor) from(select pessoa.Nome, sum(gasto.Valor) as valor from PessoaModel pessoa inner join GastoModel gasto on pessoa.Id = gasto.IdPessoa group by pessoa.nome) ret)").FirstOrDefault().ToString();
            }
            return dashboardModel;

        }
    }
}