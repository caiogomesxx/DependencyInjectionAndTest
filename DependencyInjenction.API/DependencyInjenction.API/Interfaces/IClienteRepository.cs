using DependencyInjenction.API.Models;

namespace DependencyInjenction.API.Interfaces
{
    public interface IClienteRepository
    {
        bool CadastrarCliente(Cliente cliente);
        bool ClienteExiste(int clienteId);
        Cliente BuscarCliente(int clienteId);
    }
}
