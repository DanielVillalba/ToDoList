namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingtheToDomodel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ToDo", "ListId", "dbo.ToDoList");
            DropIndex("dbo.ToDo", new[] { "ListId" });
            RenameColumn(table: "dbo.ToDo", name: "ListId", newName: "TDList_ListId");
            AlterColumn("dbo.ToDo", "TDList_ListId", c => c.Int());
            CreateIndex("dbo.ToDo", "TDList_ListId");
            AddForeignKey("dbo.ToDo", "TDList_ListId", "dbo.ToDoList", "ListId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToDo", "TDList_ListId", "dbo.ToDoList");
            DropIndex("dbo.ToDo", new[] { "TDList_ListId" });
            AlterColumn("dbo.ToDo", "TDList_ListId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.ToDo", name: "TDList_ListId", newName: "ListId");
            CreateIndex("dbo.ToDo", "ListId");
            AddForeignKey("dbo.ToDo", "ListId", "dbo.ToDoList", "ListId", cascadeDelete: true);
        }
    }
}
