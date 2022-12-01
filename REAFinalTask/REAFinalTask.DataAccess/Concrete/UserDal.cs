using REAFinalTask.DataAccess.Abstract;
using REAFinalTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REAFinalTask.DataAccess.Concrete
{
    public class UserDal : Repo<User>, IUserDal
    {
    }
}
