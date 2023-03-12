using DependencyInjenction.API.Interfaces;
using DependencyInjenction.API.Models;
using DependencyInjenction.API.Repository;

namespace DependencyInjenction.API.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IPedidoRepository _pedidoRepository;
        public PedidoService(IClienteRepository clienteRepository, IPedidoRepository pedidoRepository)
        {
            _clienteRepository = clienteRepository;
            _pedidoRepository = pedidoRepository;
        }
        public bool CadastrarPedido(Pedido pedido)
        {
            if (_clienteRepository.ClienteExiste(pedido.IdCliente))
            {
                _pedidoRepository.CadastrarPedido(pedido);
                return true;
            }
            else
                return false;
        }
        public Pedido BuscarPedido(int pedidoId)
        {
            try
            {
                var pedido = _pedidoRepository.BuscarPedido(pedidoId);
                if (pedido is not null)
                {
                    pedido.Cliente = new Cliente();
                    pedido.Cliente = _clienteRepository.BuscarCliente(pedido.IdCliente);
                }
                return pedido;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
