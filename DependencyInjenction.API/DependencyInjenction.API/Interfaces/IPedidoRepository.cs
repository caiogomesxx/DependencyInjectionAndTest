﻿using DependencyInjenction.API.Models;

namespace DependencyInjenction.API.Interfaces
{
    public interface IPedidoRepository
    {
        bool CadastrarPedido(Pedido pedido);
        Pedido BuscarPedido(int PedidoId);
    }
}
