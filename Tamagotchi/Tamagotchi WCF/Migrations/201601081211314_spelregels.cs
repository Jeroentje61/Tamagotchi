namespace Tamagotchi_WCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class spelregels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tamagotchis", "Alive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tamagotchis", "Crazy", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tamagotchis", "Munchies", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tamagotchis", "TopAtleet", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tamagotchis", "TopAtleet");
            DropColumn("dbo.Tamagotchis", "Munchies");
            DropColumn("dbo.Tamagotchis", "Crazy");
            DropColumn("dbo.Tamagotchis", "Alive");
        }
    }
}
