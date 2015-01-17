namespace ExemploSimples.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionaCategoria : DbMigration
    {
        public override void Up()
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
            CreateIndex("dbo.Produtoes", "Categoria_CategoriaId");
            AddForeignKey("dbo.Produtoes", "Categoria_CategoriaId", "dbo.Categorias", "CategoriaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtoes", "Categoria_CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Produtoes", new[] { "Categoria_CategoriaId" });
            DropColumn("dbo.Produtoes", "Categoria_CategoriaId");
            DropTable("dbo.Categorias");
        }
    }
}
