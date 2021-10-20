using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AutoEscolaPeDeChumbo.Pages.Funcionarios
{
    public class Funcionario
    {

        public int FuncionarioID { get; set; }
        [Display(Name = "Nome Funcionário")]
        public string Nome { get; set; }
        [Display(Name = "Data Admissão")]
        public DateTime dtAmissao { get; set; }

        [Display(Name = "Salário Bruto")]
        public decimal SalBruto { get; set; }
    }
}
