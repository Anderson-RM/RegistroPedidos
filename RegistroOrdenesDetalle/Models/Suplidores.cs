using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroOrdenesDetalle.Models
{
    public class Suplidores
    {
        [Key]
        public int SuplidorId { get; set; }

        [Required(ErrorMessage = "Ingresar el nombre del suplidor")]
        [MinLength(1, ErrorMessage = "Ingresar un nombre valido")]
        public string Nombre { get; set; }

        public Suplidores()
        {
            SuplidorId = 0;
            Nombre = string.Empty;
        }
    }
}
