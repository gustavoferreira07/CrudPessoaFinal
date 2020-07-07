using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudPessoas.Models
{
    public class DashboardModel
    {
        [DisplayFormat(DataFormatString = "{0:#.##}")]
        public double Valortotal { get; set; }
        public string PessoaComMaisGasto { get; set; }
        public string PessoaMaisVelha { get; set; }
        [DisplayFormat(DataFormatString = "{0:#.##}")]
        public double MenorGasto { get; set; }
    }
}