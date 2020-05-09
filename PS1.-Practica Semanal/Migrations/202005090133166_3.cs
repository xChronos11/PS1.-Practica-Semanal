namespace PS1._Practica_Semanal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "imagen", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "imagen");
        }
    }
}
