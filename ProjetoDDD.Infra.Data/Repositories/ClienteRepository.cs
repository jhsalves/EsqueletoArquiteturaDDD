using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public override void Update(Cliente cliente)
        {
            var clienteBase = GetById(cliente.ClienteId);
            Db.Entry(clienteBase).CurrentValues.SetValues(cliente);
            base.Update(clienteBase);
        }
    }
}
