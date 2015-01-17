using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.Nome = "Caderno";
            ExemploContext db = new ExemploContext();
            db.Produtos.Add(produto);
            Categoria categoria = new Categoria();
            categoria.Nome = "Escritório";
            categoria.Produtos = new List<Produto>();
            categoria.Produtos.Add(produto);
            db.Categorias.Add(categoria);
            db.SaveChanges();
        }
    }
}
