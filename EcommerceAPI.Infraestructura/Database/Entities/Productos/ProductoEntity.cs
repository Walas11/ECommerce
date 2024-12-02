using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Database.Entities.Productos
{
    [Table("Producto")]
    public class ProductoEntity
    {
        [Key]
        public long id_Producto { get; set; }
        public string Nombre_Producto { get; set; } = string.Empty;
        public double Valor_Producto { get; set; }
        public string Descripcion_Producto { get; set; } = string.Empty;
        public string? Imagen_Producto { get; set; } = string.Empty;
        public long id_EstadoProducto { get; set; }
        public int Stock { get; set; }
    }
}
