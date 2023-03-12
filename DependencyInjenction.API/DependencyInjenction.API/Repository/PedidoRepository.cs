using DependencyInjenction.API.Context;
using DependencyInjenction.API.Interfaces;
using DependencyInjenction.API.Models;

namespace DependencyInjenction.API.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        protected readonly ContextApi _context;
        public PedidoRepository(ContextApi context)
        {
            _context = context;
        }

        public bool CadastrarPedido(Pedido pedido)
        {
            try
            {
                _context.Pedido.Add(pedido);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Pedido BuscarPedido(int PedidoId)
        {
            try
            {
                var pedido = _context.Pedido.Find(PedidoId);
                return new Pedido() 
                {
                    PedidoId = pedido.PedidoId,
                    Produto = pedido.Produto,
                    Preco = pedido.Preco,
                    IdCliente = pedido.IdCliente,
                    Cliente = pedido.Cliente
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
