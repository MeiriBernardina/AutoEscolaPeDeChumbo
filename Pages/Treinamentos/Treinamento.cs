using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoEscolaPeDeChumbo.Pages.Treinamentos
{
    public class Treinamento
    {
        public int ID { get; set; }
        [Display(Name = "Tipo de treinamento")]
        public string TipoTreinamento { get; set; }
        [Display(Name = "Data início")]

        [Required]
        public DateTime DtInicio { get; set; }

    }
}
