using DarsOnline.Data.IRepositories;
using DarsOnline.Domain.Entities;
using DarsOnline.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DarsOnline.Service.Services
{

    public class UserService : IUserService
    {
        private IGenericRepository<User> userRepository;
        public UserService(IGenericRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }
        public User Create(User user)
        {
            return userRepository.Create(user);
        }

        public bool Delete(Expression<Func<User, bool>> predicate)
        {
            return userRepository.Delete(predicate);
        }

        public User Get(Expression<Func<User, bool>> predicate)
        {
            return userRepository.Get(predicate);
        }

        public IQueryable<User> GetAll(Expression<Func<User, bool>> predicate = null)
        {
            return userRepository.GetAll(predicate);
        }

        public User Update(int Id, User user)
        {
            return userRepository.Update(Id, user);
        }
    }
}
