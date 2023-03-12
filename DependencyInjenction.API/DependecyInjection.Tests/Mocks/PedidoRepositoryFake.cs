using DependencyInjenction.API.Interfaces;
using DependencyInjenction.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjection.Tests.Mocks
{
    public class PedidoRepositoryFake : IPedidoRepository
    {
        public PedidoRepositoryFake() 
        { }
        public bool CadastrarPedido(Pedido pedido)
        {
            return true;
        }
        public Pedido BuscarPedido(int PedidoId)
        {
            return new Pedido
            {
                PedidoId = 1,
                Produto = "Tenis",
                Preco = 179.90m,
                IdCliente = 1
            };
        }
    }
}
