using DesignPatternASPMVC.Models;
using System.Collections.Generic;

namespace DesignPatternASPMVC.Interfaces
{
    public interface IUserService
    {
        List<User> Get();
        User GetById(int id);
        void Create(User model);
        void Update(User model);
        void Delete(User model);
    }
}
