using DependencyInjenction.API.Context;
using DependencyInjenction.API.Interfaces;
using DependencyInjenction.API.Models;

namespace DependencyInjenction.API.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        protected readonly ContextApi _context;
        public ClienteRepository(ContextApi context)
        {
            _context = context;
        }

        public bool CadastrarCliente(Cliente cliente)
        {
            try
            {
                _context.Cliente.Add(cliente);

                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ClienteExiste(int clienteId)
        {
            try
            {
                if (_context.Cliente.Find(clienteId) is not null)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Cliente BuscarCliente(int clienteId)
        {
            try
            {
                return _context.Cliente.Find(clienteId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
