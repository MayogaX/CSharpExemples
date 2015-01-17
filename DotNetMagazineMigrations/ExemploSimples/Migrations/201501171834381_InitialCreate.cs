namespace ExemploSimples.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100),
                        valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProdutoId);
            Sql("UPDATE dbo.Produtoes SET valor = 10 WHERE valor IS NULL");
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtoes");
        }
    }
}
