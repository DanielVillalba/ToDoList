namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class goingbacktotheIDrelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ToDo", "TDList_ListId", "dbo.ToDoList");
            DropIndex("dbo.ToDo", new[] { "TDList_ListId" });
            RenameColumn(table: "dbo.ToDo", name: "TDList_ListId", newName: "ListId");
            AlterColumn("dbo.ToDo", "ListId", c => c.Int(nullable: false));
            CreateIndex("dbo.ToDo", "ListId");
            AddForeignKey("dbo.ToDo", "ListId", "dbo.ToDoList", "ListId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToDo", "ListId", "dbo.ToDoList");
            DropIndex("dbo.ToDo", new[] { "ListId" });
            AlterColumn("dbo.ToDo", "ListId", c => c.Int());
            RenameColumn(table: "dbo.ToDo", name: "ListId", newName: "TDList_ListId");
            CreateIndex("dbo.ToDo", "TDList_ListId");
            AddForeignKey("dbo.ToDo", "TDList_ListId", "dbo.ToDoList", "ListId");
        }
    }
}
