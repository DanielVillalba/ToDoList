namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsingjustonetableinEF : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ToDo", "ListId", "dbo.ToDoList");
            DropIndex("dbo.ToDo", new[] { "ListId" });
            AddColumn("dbo.ToDoList", "Description", c => c.String());
            AddColumn("dbo.ToDoList", "IsDone", c => c.Boolean(nullable: false));
            DropTable("dbo.ToDo");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ToDo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        IsDone = c.Boolean(nullable: false),
                        ListId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.ToDoList", "IsDone");
            DropColumn("dbo.ToDoList", "Description");
            CreateIndex("dbo.ToDo", "ListId");
            AddForeignKey("dbo.ToDo", "ListId", "dbo.ToDoList", "ListId", cascadeDelete: true);
        }
    }
}
