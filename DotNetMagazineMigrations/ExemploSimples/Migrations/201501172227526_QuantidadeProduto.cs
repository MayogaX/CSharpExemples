namespace ExemploSimples.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuantidadeProduto : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Produtoes", "Categoria_CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Produtoes", new[] { "Categoria_CategoriaId" });
            AddColumn("dbo.Produtoes", "Quantidade", c => c.Int(nullable: false));
            DropColumn("dbo.Produtoes", "Categoria_CategoriaId");
            DropTable("dbo.Categorias");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
            AddColumn("dbo.Produtoes", "Categoria_CategoriaId", c => c.Int());
            DropColumn("dbo.Produtoes", "Quantidade");
            CreateIndex("dbo.Produtoes", "Categoria_CategoriaId");
            AddForeignKey("dbo.Produtoes", "Categoria_CategoriaId", "dbo.Categorias", "CategoriaId");
        }
    }
}
