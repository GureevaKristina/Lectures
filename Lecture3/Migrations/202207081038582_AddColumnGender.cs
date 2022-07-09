//namespace Lecture3.Migrations
//{
//    using System;
//    using System.Data.Entity.Migrations;
    
//    public partial class AddColumnGender : DbMigration
//    {
//        public override void Up()
//        {
//            CreateTable(
//                "dbo.People",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Age = c.Int(nullable: false),
//                        Name = c.String(),
//                        Gender = c.String(),
//                    })
//                .PrimaryKey(t => t.Id);
            
//        }
        
//        public override void Down()
//        {
//            DropTable("dbo.People");
//        }
//    }
//}
