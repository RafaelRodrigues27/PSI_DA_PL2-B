namespace ProjetoDA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.extras", "Preco", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.extras", "Ativo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.extras", "Ativo", c => c.String());
            AlterColumn("dbo.extras", "Preco", c => c.String());
        }
    }
}
