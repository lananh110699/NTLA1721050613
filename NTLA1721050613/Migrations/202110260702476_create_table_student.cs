namespace NTLA1721050613.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_student : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 20, unicode: false),
                        PersonName = c.String(nullable: false, maxLength: 50),
                        University = c.String(maxLength: 50),
                        Address = c.String(maxLength: 50),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Person");
        }
    }
}
