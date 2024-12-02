using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entities.Compras
{
    [Table("Compra")]
    public class CompraEntity
    {
        [Key]
        public long id_Compra { get; set; }
        public long Cedula_Cliente { get; set; }
        public DateTime Fecha_Compra { get; set; }
        public double Valor_Total { get; set; }
        public string direccionentrega { get; set; } = string.Empty;
        public long id_Producto { get; set; }
        public long id_Estado_Compra { get; set; }
    }
}
