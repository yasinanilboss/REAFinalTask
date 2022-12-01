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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public int AddComment(Comment comment)
        {
            return _commentDal.Add(comment);
        }

        public int DeleteComment(Comment comment)
        {
            return _commentDal.Delete(comment); 
        }

        public Comment GetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> ListAllComment(Expression<Func<Comment, bool>> filter = null)
        {
            return _commentDal.ListAll();
        }

        public int UpdateComment(Comment comment)
        {
            return _commentDal.Update(comment);
        }
    }
}
