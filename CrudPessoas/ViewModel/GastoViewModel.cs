using CrudPessoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPessoas.ViewModel
{
    public class GastoViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int idPessoa { get; set; }
        public PessoaModel Pessoa { get; set; }
    }
}