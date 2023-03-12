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
    public class ClienteRepositoryFake : IClienteRepository
    {
        public Cliente BuscarCliente(int clienteId)
        {
            try
            {
                return new Cliente 
                {
                    ClienteId = 1,
                    Email = "teste@gmail.com",
                    Nome = "caio",
                    Telefone ="3199999999"
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ClienteExiste(int clienteId)
        {
            return true;
        }
        public bool CadastrarCliente(Cliente cliente)
        {
            return true;
        }
    }
}
