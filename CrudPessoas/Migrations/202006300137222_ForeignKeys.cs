namespace CrudPessoas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeys : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.GastoModels", newName: "GastoModel");
            RenameTable(name: "dbo.PessoaModels", newName: "PessoaModel");
            RenameTable(name: "dbo.LoginModels", newName: "LoginModel");
            DropForeignKey("dbo.GastoModeld", "Pessoa_Id", "dbo.PessoaModels");
            DropForeignKey("dbo.LoginModeld", "Pessoa_Id", "dbo.PessoaModels");
            DropIndex("dbo.GastoModel", new[] { "Pessoa_Id" });
            DropIndex("dbo.LoginModel", new[] { "Pessoa_Id" });
            RenameColumn(table: "dbo.GastoModel", name: "Pessoa_Id", newName: "idPessoa");
            RenameColumn(table: "dbo.LoginModel", name: "Pessoa_Id", newName: "IdPessoa");
            AlterColumn("dbo.GastoModel", "Descricao", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.GastoModel", "idPessoa", c => c.Int(nullable: false));
            AlterColumn("dbo.PessoaModel", "Nome", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.PessoaModel", "CPF", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.LoginModel", "Email", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.LoginModel", "Senha", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.LoginModel", "IdPessoa", c => c.Int(nullable: false));
            CreateIndex("dbo.GastoModel", "idPessoa");
            CreateIndex("dbo.LoginModel", "IdPessoa");
            AddForeignKey("dbo.GastoModel", "idPessoa", "dbo.PessoaModel", "Id", cascadeDelete: true);
            AddForeignKey("dbo.LoginModel", "IdPessoa", "dbo.PessoaModel", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LoginModel", "IdPessoa", "dbo.PessoaModel");
            DropForeignKey("dbo.GastoModel", "idPessoa", "dbo.PessoaModel");
            DropIndex("dbo.LoginModel", new[] { "IdPessoa" });
            DropIndex("dbo.GastoModel", new[] { "idPessoa" });
            AlterColumn("dbo.LoginModel", "IdPessoa", c => c.Int());
            AlterColumn("dbo.LoginModel", "Senha", c => c.String());
            AlterColumn("dbo.LoginModel", "Email", c => c.String());
            AlterColumn("dbo.PessoaModel", "CPF", c => c.String());
            AlterColumn("dbo.PessoaModel", "Nome", c => c.String());
            AlterColumn("dbo.GastoModel", "idPessoa", c => c.Int());
            AlterColumn("dbo.GastoModel", "Descricao", c => c.String());
            RenameColumn(table: "dbo.LoginModel", name: "IdPessoa", newName: "Pessoa_Id");
            RenameColumn(table: "dbo.GastoModel", name: "idPessoa", newName: "Pessoa_Id");
            CreateIndex("dbo.LoginModel", "Pessoa_Id");
            CreateIndex("dbo.GastoModel", "Pessoa_Id");
            AddForeignKey("dbo.LoginModels", "Pessoa_Id", "dbo.PessoaModels", "Id");
            AddForeignKey("dbo.GastoModels", "Pessoa_Id", "dbo.PessoaModels", "Id");
            RenameTable(name: "dbo.LoginModel", newName: "LoginModels");
            RenameTable(name: "dbo.PessoaModel", newName: "PessoaModels");
            RenameTable(name: "dbo.GastoModel", newName: "GastoModels");
        }
    }
}
