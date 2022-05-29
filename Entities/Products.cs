using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Products
    {
        [Key]
        [Required]
        public int ProductoCodigo { get; set; }
        [Required]
        public string ProductoCategoria { get; set; }
        [Required]
        public string ProductoMarca { get; set; }
        [Required]
        public string ProductoDescripcion { get; set; }
        [Required]
        public int ProductoPrecio { get; set; }


    }
}
