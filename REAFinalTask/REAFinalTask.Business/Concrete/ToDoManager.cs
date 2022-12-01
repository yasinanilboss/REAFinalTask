using REAFinalTask.Business.Abstract;
using REAFinalTask.DataAccess.Abstract;
using REAFinalTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace REAFinalTask.Business.Concrete
{
    public class ToDoManager : IToDoService
    {
        IToDoDal _todoDal;

        public ToDoManager(IToDoDal todoDal)
        {
            _todoDal = todoDal;
        }

        public int AddToDo(ToDo todo)
        {
            return _todoDal.Add(todo);
        }

        public int DeleteToDo(ToDo todo)
        {
            return _todoDal.Delete(todo);
        }

        public ToDo GetById(int id)
        {
            return _todoDal.GetById(id);
        }

        public List<ToDo> ListAllToDo(Expression<Func<ToDo, bool>> filter = null)
        {
            return _todoDal.ListAll();
        }

        public int UpdateToDo(ToDo todo)
        {
            return _todoDal.Update(todo);
        }
    }
}
