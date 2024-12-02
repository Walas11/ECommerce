using EcommerceAPI.Dominio.Services.Ecommerce.Clientes;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClientesService _clientesService;

        public ClienteController(IClientesService clientesService)
        {
            _clientesService = clientesService;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(_clientesService.ObtenerClientes());
        }
    }
}
