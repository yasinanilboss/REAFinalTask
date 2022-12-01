using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REAFinalTask.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentOwner { get; set; }
        public string CommentDescription { get; set; }


        [ForeignKey("ToDo")]
        public int ToDoId { get; set; }
        public ToDo ToDo { get; set; }
    }

}

