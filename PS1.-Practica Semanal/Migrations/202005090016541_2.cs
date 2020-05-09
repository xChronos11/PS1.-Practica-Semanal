namespace PS1._Practica_Semanal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "Platform", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "Platform", c => c.Int(nullable: false));
        }
    }
}
