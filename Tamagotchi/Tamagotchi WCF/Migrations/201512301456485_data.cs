namespace Tamagotchi_WCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tamagotchis", "AccesGranted", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tamagotchis", "LastAcces", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tamagotchis", "LastAcces");
            DropColumn("dbo.Tamagotchis", "AccesGranted");
        }
    }
}
