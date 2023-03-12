using DependencyInjenction.API.Models;

namespace DependencyInjenction.API.Interfaces
{
    public interface IPedidoService
    {
        bool CadastrarPedido(Pedido pedido);
        Pedido BuscarPedido(int pedidoId);
    }
}
