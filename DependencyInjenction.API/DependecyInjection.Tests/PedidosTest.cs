using DependecyInjection.Tests.Mocks;
using DependencyInjenction.API.Interfaces;
using DependencyInjenction.API.Models;
using DependencyInjenction.API.Services;

namespace DependecyInjection.Tests
{
    public class PedidosTest
    {
        [Fact]
        public void SucessTestPedidos()
        {
            IClienteRepository clienteRepositoryFake = new ClienteRepositoryFake();
            IPedidoRepository pedidoRepositoryFake = new PedidoRepositoryFake();
            Pedido pedidoGerado = new PedidoService(clienteRepositoryFake, pedidoRepositoryFake).BuscarPedido(1);
            
            Pedido pedido = new Pedido()
            {
                PedidoId = 1,
                Produto = "Tenis",
                Preco = 179.90m,
                IdCliente = 1,
                Cliente = new Cliente
                {
                    ClienteId = 1,
                    Email = "teste@gmail.com",
                    Nome = "caio",
                    Telefone = "3199999999"
                }

            };
            Assert.Equivalent(pedido.IdCliente,pedidoGerado.IdCliente);
             
        }
        [Fact]
        public void FailTestPedidos()
        {
            IClienteRepository clienteRepositoryFake = new ClienteRepositoryFake();
            IPedidoRepository pedidoRepositoryFake = new PedidoRepositoryFake();
            Pedido pedidoGerado = new PedidoService(clienteRepositoryFake, pedidoRepositoryFake).BuscarPedido(1);
            Pedido pedido = new Pedido()
            {
                PedidoId = 2,
                Produto = "Tenis",
                Preco = 179.90m,
                IdCliente = 1,
                Cliente = new Cliente
                {
                    ClienteId = 1,
                    Email = "teste@gmail.com",
                    Nome = "caio",
                    Telefone = "3199999999"
                }

            };
            Assert.NotEqual(pedidoGerado, pedido);


        }
    }
}