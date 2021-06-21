using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroOrdenesDetalle.Models
{
    public class Productos
    {
        [Key]
        public int ProductosId { get; set; }

        [Required(ErrorMessage = "Ingresar una descripcion")]
        [MinLength(3, ErrorMessage = "Agregar una descripcion valida")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Ingresar el costo del producto")]
        public decimal Costo { get; set; }

        [Required(ErrorMessage = "ingresar la cantidad del producto en inventario")]
        public int Inventario { get; set; }

        [Required(ErrorMessage = "seleccionar el id del suplidor")]
        public int SuplidorId { get; set; }

        [ForeignKey("SuplidorId")]
        public virtual Suplidores Suplidores { get; set; }

        public Productos()
        {
            ProductosId = 0;
            Descripcion = string.Empty;
            Costo = 0;
            Inventario = 0;

        }
    }
}
