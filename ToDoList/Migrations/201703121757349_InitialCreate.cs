namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToDoList",
                c => new
                    {
                        ListId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ListId);
            
            CreateTable(
                "dbo.ToDo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        IsDone = c.Boolean(nullable: false),
                        ListId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ToDoList", t => t.ListId, cascadeDelete: true)
                .Index(t => t.ListId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToDo", "ListId", "dbo.ToDoList");
            DropIndex("dbo.ToDo", new[] { "ListId" });
            DropTable("dbo.ToDo");
            DropTable("dbo.ToDoList");
        }
    }
}
