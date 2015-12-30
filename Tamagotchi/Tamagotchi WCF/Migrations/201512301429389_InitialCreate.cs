namespace Tamagotchi_WCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tamagotchis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        Hunger = c.Int(nullable: false),
                        Sleep = c.Int(nullable: false),
                        Boredom = c.Int(nullable: false),
                        Health = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tamagotchis");
        }
    }
}
