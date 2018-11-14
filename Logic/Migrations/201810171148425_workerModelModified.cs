namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class workerModelModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Workers", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Workers", "SOM", c => c.String());
            AddColumn("dbo.Workers", "SOD", c => c.String());
            AddColumn("dbo.Workers", "BC", c => c.String());
            AddColumn("dbo.Workers", "SOMYear", c => c.DateTime(nullable: false));
            AddColumn("dbo.Workers", "SODYear", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Workers", "SODYear");
            DropColumn("dbo.Workers", "SOMYear");
            DropColumn("dbo.Workers", "BC");
            DropColumn("dbo.Workers", "SOD");
            DropColumn("dbo.Workers", "SOM");
            DropColumn("dbo.Workers", "BirthDate");
        }
    }
}
