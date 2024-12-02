using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Comunes.Classes.Contracts.Producto
{
    public class ProductoContract
    {
        public long id_Producto { get; set; }
        public string Nombre_Producto { get; set; } = string.Empty;
        public double Valor_Producto { get; set; }
        public string Descripcion_Producto { get; set; } = string.Empty;
        public string? Imagen_Producto { get; set; } = string.Empty;
        public long id_EstadoProducto { get; set; }
        public int Stock { get; set; }
    }
}
