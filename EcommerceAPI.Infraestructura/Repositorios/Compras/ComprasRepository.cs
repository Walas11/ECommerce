using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities.Cliente;
using EcommerceAPI.Infraestructura.Database.Entities.Compras;

namespace EcommerceAPI.Infraestructura.Repositorios.Compras
{
    public class ComprasRepository : ICompraRepository
    {
        private readonly EcommerceContext _context;
        public ComprasRepository(EcommerceContext context)
        {
            _context = context;
        }
        public CompraEntity Actualizar(CompraEntity clienteEntity)
        {
            throw new NotImplementedException();
        }

        public CompraEntity Crear(CompraEntity clienteEntity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(CompraEntity clienteEntity)
        {
            _context.Cliente.Remove(clienteEntity);
            _context.SaveChanges();
        }

        public List<CompraEntity> ObtenerCompra()
        {
            throw new NotImplementedException();
        }

        public CompraEntity ObtenerCompra(long id)
        {
            throw new NotImplementedException();
        }
    }
}
