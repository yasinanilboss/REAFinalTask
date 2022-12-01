using REAFinalTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace REAFinalTask.Business.Abstract
{
    public interface ICommentService
    {
        public int AddComment(Comment comment);
        public int UpdateComment(Comment comment);
        public int DeleteComment(Comment comment);
        List<Comment> ListAllComment(Expression<Func<Comment, bool>> filter = null);
        Comment GetById(int id);

    }
}
