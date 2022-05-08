using DarsOnline.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DarsOnline.Service.Interfaces
{
    public interface IUserService
    {
        User Create(User user);
        User Get(Expression<Func<User, bool>> predicate);

        IQueryable<User> GetAll(Expression<Func<User, bool>> predicate = null);
        bool Delete(Expression<Func<User, bool>> predicate);
        User Update(int Id, User user);
    }
}
