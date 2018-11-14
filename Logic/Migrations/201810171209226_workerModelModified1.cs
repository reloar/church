namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class workerModelModified1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sermons", "SermonvideoUrl", c => c.String());
            AddColumn("dbo.Sermons", "SermonvideoThumbnail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sermons", "SermonvideoThumbnail");
            DropColumn("dbo.Sermons", "SermonvideoUrl");
        }
    }
}
