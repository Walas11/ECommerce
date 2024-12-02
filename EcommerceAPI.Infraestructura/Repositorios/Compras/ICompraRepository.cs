using EcommerceAPI.Infraestructura.Database.Entities.Cliente;
using EcommerceAPI.Infraestructura.Database.Entities.Compras;

namespace EcommerceAPI.Infraestructura.Repositorios.Compras
{
    public interface ICompraRepository
    {
        List<CompraEntity> ObtenerCompra();
        CompraEntity ObtenerCompra(long id);
        CompraEntity Crear(CompraEntity clienteEntity);
        CompraEntity Actualizar(CompraEntity clienteEntity);
        void Eliminar(CompraEntity clienteEntity);
    }
}
