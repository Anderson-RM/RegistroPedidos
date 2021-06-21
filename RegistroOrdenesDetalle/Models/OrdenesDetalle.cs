using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroOrdenesDetalle.Models
{
    public class OrdenesDetalle
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = " seleccionar el id de la orden")]
        public int OrdenId { get; set; }

        [Required(ErrorMessage = " seleccionar la cantidad del producto")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "seleccionar el id del producto")]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = " ingresar el costo del producto")]
        public decimal Costo { get; set; }

        public OrdenesDetalle()
        {
            Id = 0;
            OrdenId = 0;
            Cantidad = 0;
            ProductoId = 0;
            Costo = 0;
        }
    }
}
