using EcommerceAPI.Infraestructura.Database.Context;
using EcommerceAPI.Infraestructura.Database.Entities.Cliente;

namespace EcommerceAPI.Infraestructura.Repositorios.Clientes
{
    public class ClientesRepository : IClientesRepository
    {
        private readonly EcommerceContext _context;
        public ClientesRepository(EcommerceContext context)
        {
            _context = context;
        }

        public ClienteEntity Actualizar(ClienteEntity clienteEntity)
        {
            _context.Cliente.Update(clienteEntity);
            _context.SaveChanges();
            return clienteEntity;
        }

        public ClienteEntity Crear(ClienteEntity clienteEntity)
        {
            _context.Cliente.Add(clienteEntity);
            _context.SaveChanges();
            return clienteEntity;
        }

        public void Eliminar(ClienteEntity clienteEntity)
        {
            _context.Cliente.Remove(clienteEntity);
            _context.SaveChanges();
        }

        public List<ClienteEntity> ObtenerClientes()
        {
            return _context.Cliente.ToList();
        }

        public ClienteEntity ObtenerClientes(long id)
        {
            return _context.Cliente.Find(id);
        }
    }
}
