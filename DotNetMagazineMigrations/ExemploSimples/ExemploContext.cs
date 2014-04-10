using System.Data.Entity;

namespace ExemploSimples
{
    public class ExemploContext: DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}
