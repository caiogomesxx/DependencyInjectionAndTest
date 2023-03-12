using DependencyInjenction.API.Interfaces;
using DependencyInjenction.API.Models;
using DependencyInjenction.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjenction.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        [HttpPost]
        public async Task<IActionResult> CadastrarCliente(Cliente cliente)
        {
            try
            {
                _clienteRepository.CadastrarCliente(cliente);
                return Created("Pedido cadastrado com sucesso", cliente);
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        [HttpGet]
        public async Task<IActionResult> BuscarCliente(int clienteId)
        {
            try
            {
                
                return Created("Pedido cadastrado com sucesso", _clienteRepository.BuscarCliente(clienteId));
            }
            catch (Exception er)
            {
                throw er;
            }
        }
    }
}
