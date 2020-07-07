using CrudPessoas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;

namespace CrudPessoas.ViewModel
{
    public class PessoaViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimio {0} caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha o campo CPF")]
       
        public string CPF { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        public int Idade { get; set; }

    }
}