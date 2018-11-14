namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbchanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sermons", "VideoLink", c => c.String());
            DropColumn("dbo.Sermons", "SermonvideoUrl");
            DropColumn("dbo.Sermons", "SermonvideoThumbnail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sermons", "SermonvideoThumbnail", c => c.String());
            AddColumn("dbo.Sermons", "SermonvideoUrl", c => c.String());
            DropColumn("dbo.Sermons", "VideoLink");
        }
    }
}
