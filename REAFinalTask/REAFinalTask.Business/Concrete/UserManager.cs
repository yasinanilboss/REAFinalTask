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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public int AddUser(User user)
        {
            return _userDal.Add(user);
        }

        public int DeleteUser(User user)
        {
            return _userDal.Delete(user);
        }

        public User GetById(int id)
        {
            return _userDal.GetById(id);
        }

        public List<User> ListAllUser(Expression<Func<User, bool>> filter = null)
        {
            return _userDal.ListAll();
        }

        public int UpdateUser(User user)
        {
            return _userDal.Update(user);
        }
    }
}
