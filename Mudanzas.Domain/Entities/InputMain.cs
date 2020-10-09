using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Mudanzas.Domain.Entities
{
    public class InputMain
    {
        [Required]
        [Range(1, 500)]
        public int NumeroDias_T { get; set; }

        public List<InputCargaDia> ListaCargas;
    }
    
}
