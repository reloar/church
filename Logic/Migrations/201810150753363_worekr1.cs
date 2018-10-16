namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class worekr1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "Married", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "Married", c => c.Boolean(nullable: false));
        }
    }
}
