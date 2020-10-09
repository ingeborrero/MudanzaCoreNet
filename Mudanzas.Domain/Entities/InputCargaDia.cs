using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Mudanzas.Domain.Entities
{
    public class InputCargaDia
    {
        [Required]
        [Range(1, 100, ErrorMessage = "Elementos deben estar entre 1-100.")]
        public int NumeroElementos_N { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Peso debe estar entre 1-100.")]
        public List<Int16> Elementos_WI { get; set; }
    }
}
