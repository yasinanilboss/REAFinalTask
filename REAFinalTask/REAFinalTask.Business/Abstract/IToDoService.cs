using REAFinalTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace REAFinalTask.Business.Abstract
{
    public interface IToDoService
    {
        public int AddToDo(ToDo todo);
        public int UpdateToDo(ToDo todo);
        public int DeleteToDo(ToDo todo);
        List<ToDo> ListAllToDo(Expression<Func<ToDo, bool>> filter = null);
        ToDo GetById(int id);
    }
}
