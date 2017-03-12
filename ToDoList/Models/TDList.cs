using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    [Table("ToDoList")]
    public class TDList
    {
        [Key]
        public int ListId { get; set; }
        public string Name { get; set; }

        public virtual List<ToDo> ToDoes { get; set; }
    }
}