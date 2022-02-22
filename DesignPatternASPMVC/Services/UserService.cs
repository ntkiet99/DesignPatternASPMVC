using DesignPatternASPMVC.Data;
using DesignPatternASPMVC.Interfaces;
using DesignPatternASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternASPMVC.Services
{
    public class UserService : IUserService
    {
        private DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }
        public void Create(User model)
        {
            var entity = new User();
            entity.Username = model.Username;
            entity.Password = model.Password;

            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(User model)
        {
            var entity = _context.Users.Where(x => x.Id == model.Id).FirstOrDefault();
            if (entity == default)
                throw new Exception("Không tìm thấy dữ liệu.");

            _context.Users.Remove(entity);
            _context.SaveChanges();
        }

        public List<User> Get()
        {
            return _context.Users.ToList();   
        }

        public User GetById(int id)
        {
            return _context.Users.Where(x => x.Id == id).FirstOrDefault();    
        }

        public void Update(User model)
        {
            var entity = _context.Users.Where(x => x.Id == model.Id).FirstOrDefault();
            if (entity == default)
                throw new Exception("Không tìm thấy dữ liệu.");

            entity.Username = model.Username;
            entity.Password = model.Password;
            _context.SaveChanges();
        }
    }
}