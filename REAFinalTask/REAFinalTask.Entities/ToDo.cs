using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REAFinalTask.Entities
{
    public class ToDo
    {
        public int ToDoId { get; set; }
        public string ToDoOwner { get; set; }
        public string ToDoTitle { get; set; }
        public string ToDoDescription { get; set; }
        public ToDoStatus ToDoStatusEnum { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }

    public enum ToDoStatus
    {
        Created = 0,
        InProgress = 1,
        Done = 2
    }
}
