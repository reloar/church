namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class worekr : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Workers", "MarriageAnniversary", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Members", "WeddingAnniversary", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "WeddingAnniversary", c => c.String());
            AlterColumn("dbo.Workers", "MarriageAnniversary", c => c.String());
        }
    }
}
