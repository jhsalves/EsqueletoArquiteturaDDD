using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string produto)
        {
            return Db.Produtos.Where(x => x.Nome == produto);
        }

        public override void Update(Produto produto)
        {
            var produtoBase = GetById(produto.ProdutoId);
            Db.Entry(produtoBase).CurrentValues.SetValues(produto);
            base.Update(produtoBase);
        }
    }
}
