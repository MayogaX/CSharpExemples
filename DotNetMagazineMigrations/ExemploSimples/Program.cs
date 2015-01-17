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
            produto.Nome = "Estojo";
            ExemploContext db = new ExemploContext();
            db.Produtos.Add(produto);
            db.SaveChanges();
        }
    }
}
