using EcommerceAPI.Infraestructura.Database.Entities.Cliente;

namespace EcommerceAPI.Infraestructura.Repositorios.Clientes
{
    public interface IClientesRepository
    {
        List<ClienteEntity> ObtenerClientes();
        ClienteEntity ObtenerClientes(long id);
        ClienteEntity Crear(ClienteEntity clienteEntity);
        ClienteEntity Actualizar(ClienteEntity clienteEntity);
        void Eliminar(ClienteEntity clienteEntity);
    }
}
