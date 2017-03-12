using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDoList.Models;

namespace ToDoList.Context
{
    public class ToDoContext : DbContext
    {
        public DbSet<TDList> ToDoLists { get; set; }
        public DbSet<ToDo> ToDos { get; set; }
    }
}