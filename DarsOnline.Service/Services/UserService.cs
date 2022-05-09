using AutoMapper;
using DarsOnline.Data.IRepositories;
using DarsOnline.Domain.Entities;
using DarsOnline.Service.DTOs;
using DarsOnline.Service.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace DarsOnline.Service.Services
{

    public class UserService : IUserService
    {
        private IGenericRepository<User> userRepository;
        private IMapper mapper;
        public UserService(IGenericRepository<User> userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public User Create(UserForCreationDto userDto)
        {
            var mappedUser = mapper.Map<User>(userDto);

            return userRepository.Create(mappedUser);
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
