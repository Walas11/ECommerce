using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Compra;
using EcommerceAPI.Infraestructura.Database.Entities.Cliente;
using EcommerceAPI.Infraestructura.Repositorios.Clientes;

namespace EcommerceAPI.Dominio.Services.Ecommerce.Clientes
{
    public class ClientesService : IClientesService
    {
        private readonly IClientesRepository _repositoryClientes;
        private readonly IMapper _mapper;
        public ClientesService(IClientesRepository repositoryClientes, IMapper mapper)
        {
            _repositoryClientes = repositoryClientes;
            _mapper = mapper;
        }
        public ClienteContract Actualizar(ClienteContract clienteContract)
        {
            ClienteEntity cliente = _repositoryClientes.ObtenerClientes(clienteContract.id_Cliente);
            if (cliente != null)
            {
                return _mapper.Map<ClienteContract>(_repositoryClientes.Actualizar(
                        _mapper.Map<ClienteEntity>(clienteContract)));
            }
            else
                throw new Exception($"El cliente con cedula: {clienteContract.Cedula}, no se encuentra ");

        }

        public ClienteContract Crear(ClienteContract clienteContract)
        {

            return _mapper.Map<ClienteContract>(_repositoryClientes.Crear(
                _mapper.Map<ClienteEntity>(clienteContract)));
        }

        public bool Eliminar(int id)
        {
            ClienteEntity cliente = _repositoryClientes.ObtenerClientes(id);
            if (cliente != null)
            {
                _repositoryClientes.Eliminar(_mapper.Map<ClienteEntity>(cliente));
                return true;
            }
            else
                return false;
        }

        public List<ClienteContract> ObtenerClientes()
        {
            return _mapper.Map<List<ClienteContract>>(_repositoryClientes.ObtenerClientes());
        }

        public ClienteContract ObtenerClientes(int id)
        {
            return _mapper.Map<ClienteContract>(_repositoryClientes.ObtenerClientes(id));
        }
    }
}
