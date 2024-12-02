using EcommerceAPI.Comunes.Classes.Contracts.Compra;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Clientes
{
    public interface IClientesService
    {
        List<ClienteContract> ObtenerClientes();
        ClienteContract ObtenerClientes(int id);
        ClienteContract Crear(ClienteContract clienteContract);
        ClienteContract Actualizar(ClienteContract clienteContract);
        bool Eliminar(int id);
    }
}
