namespace EcommerceAPI.Comunes.Classes.Contracts.Ecommerce
{
    internal class CompraContract
    {
        public long id_Compra { get; set; }
        public long Cedula_Cliente { get; set; }
        public DateTime Fecha_Compra { get; set; }
        public double Valor_Total { get; set; }
        public string direccionentrega { get; set; } = string.Empty;
        public long id_Producto { get; set; }
        public long id_Estado_Compra { get; set; }
    }
}
