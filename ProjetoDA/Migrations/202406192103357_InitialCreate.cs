namespace ProjetoDA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.estudantes",
                c => new
                    {
                        Idestudante = c.Int(nullable: false, identity: true),
                        Id = c.String(),
                        Nome = c.String(),
                        NIF = c.String(),
                        Saldo = c.Int(nullable: false),
                        Nestudante = c.String(),
                    })
                .PrimaryKey(t => t.Idestudante);
            
            CreateTable(
                "dbo.extras",
                c => new
                    {
                        Idextras = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Preco = c.String(),
                        Ativo = c.String(),
                    })
                .PrimaryKey(t => t.Idextras);
            
            CreateTable(
                "dbo.faturas",
                c => new
                    {
                        Idfatura = c.Int(nullable: false, identity: true),
                        total = c.Double(nullable: false),
                        DataHora = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Idfatura);
            
            CreateTable(
                "dbo.funcionarios",
                c => new
                    {
                        Idfuncionario = c.Int(nullable: false, identity: true),
                        Id = c.String(),
                        Nome = c.String(),
                        NIF = c.String(),
                        Username = c.String(),
                    })
                .PrimaryKey(t => t.Idfuncionario);
            
            CreateTable(
                "dbo.menus",
                c => new
                    {
                        Idmenu = c.Int(nullable: false, identity: true),
                        DataHora = c.DateTime(nullable: false),
                        QtdDisponivel = c.Int(nullable: false),
                        Precoestudante = c.Double(nullable: false),
                        PrecoProfessor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Idmenu);
            
            CreateTable(
                "dbo.multas",
                c => new
                    {
                        Idmenu = c.Int(nullable: false, identity: true),
                        Valor = c.Int(nullable: false),
                        NumHoras = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Idmenu);
            
            CreateTable(
                "dbo.pratoes",
                c => new
                    {
                        Idprato = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Tipo = c.String(),
                        Ativo = c.String(),
                    })
                .PrimaryKey(t => t.Idprato);
            
            CreateTable(
                "dbo.professors",
                c => new
                    {
                        Idprofessor = c.Int(nullable: false, identity: true),
                        Id = c.String(),
                        Nome = c.String(),
                        NIF = c.String(),
                        Saldo = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Idprofessor);
            
            CreateTable(
                "dbo.reservas",
                c => new
                    {
                        Idreserva = c.Int(nullable: false, identity: true),
                        extras_Idextras = c.Int(),
                        menu_Idmenu = c.Int(),
                        multa_Idmenu = c.Int(),
                        prato_Idprato = c.Int(),
                    })
                .PrimaryKey(t => t.Idreserva)
                .ForeignKey("dbo.extras", t => t.extras_Idextras)
                .ForeignKey("dbo.menus", t => t.menu_Idmenu)
                .ForeignKey("dbo.multas", t => t.multa_Idmenu)
                .ForeignKey("dbo.pratoes", t => t.prato_Idprato)
                .Index(t => t.extras_Idextras)
                .Index(t => t.menu_Idmenu)
                .Index(t => t.multa_Idmenu)
                .Index(t => t.prato_Idprato);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.reservas", "prato_Idprato", "dbo.pratoes");
            DropForeignKey("dbo.reservas", "multa_Idmenu", "dbo.multas");
            DropForeignKey("dbo.reservas", "menu_Idmenu", "dbo.menus");
            DropForeignKey("dbo.reservas", "extras_Idextras", "dbo.extras");
            DropIndex("dbo.reservas", new[] { "prato_Idprato" });
            DropIndex("dbo.reservas", new[] { "multa_Idmenu" });
            DropIndex("dbo.reservas", new[] { "menu_Idmenu" });
            DropIndex("dbo.reservas", new[] { "extras_Idextras" });
            DropTable("dbo.reservas");
            DropTable("dbo.professors");
            DropTable("dbo.pratoes");
            DropTable("dbo.multas");
            DropTable("dbo.menus");
            DropTable("dbo.funcionarios");
            DropTable("dbo.faturas");
            DropTable("dbo.extras");
            DropTable("dbo.estudantes");
        }
    }
}
