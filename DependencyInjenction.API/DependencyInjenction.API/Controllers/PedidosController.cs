using DependencyInjenction.API.Interfaces;
using DependencyInjenction.API.Models;
using DependencyInjenction.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjenction.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;

        public PedidosController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }
        [HttpPost]
        public async Task<IActionResult> CadastrarPedido(Pedido pedido)
        {
            try
            {
                _pedidoService.CadastrarPedido(pedido);                
                return Created("Pedido cadastrado com sucesso", pedido);
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        [HttpGet]
        public async Task<IActionResult> BuscarPedido(int pedidoId)
        {
            try
            {
                return Ok(_pedidoService.BuscarPedido(pedidoId));
            }
            catch (Exception er)
            {
                throw er;
            }
        }
    }
}
