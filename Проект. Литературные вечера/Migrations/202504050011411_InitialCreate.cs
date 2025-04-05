namespace Проект.Литературные_вечера.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.events",
                c => new
                    {
                        event_id = c.Int(nullable: false, identity: true),
                        title = c.String(nullable: false, maxLength: 100),
                        description = c.String(maxLength: 500),
                        date = c.DateTime(nullable: false),
                        time = c.Time(nullable: false, precision: 6),
                        category = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.event_id);
            
        }
        
        public override void Down()
        {
            DropTable("public.events");
        }
    }
}
