namespace CrudPessoas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migra : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LoginModel", "IdPessoa", "dbo.PessoaModel");
            DropIndex("dbo.LoginModel", new[] { "IdPessoa" });
            DropTable("dbo.LoginModel");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.LoginModel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 100, unicode: false),
                        IdPessoa = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.LoginModel", "IdPessoa");
            AddForeignKey("dbo.LoginModel", "IdPessoa", "dbo.PessoaModel", "Id", cascadeDelete: true);
        }
    }
}
