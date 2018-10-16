namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FromEmail = c.String(),
                        Body = c.String(),
                        FullName = c.String(),
                        PhoneNumber = c.String(),
                        To = c.String(),
                        Subject = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
