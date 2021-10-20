using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoEscolaPeDeChumbo.Pages.Alunos
{
    public class Alunos
    {
        public int ID { get; set; }

        [Display(Name = "Nome Aluno")]
        public string Nome { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public string Tel { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }



    }
}
