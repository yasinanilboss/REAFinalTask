﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace REAFinalTask.DataAccess.Abstract
{
    public interface IRepo<T>
    {
        public int Add(T ent);
        public int Update(T ent);
        public int Delete(T ent);
        List<T> ListAll(Expression<Func<T, bool>> filter = null);
        T GetById(int id);
    }
}
