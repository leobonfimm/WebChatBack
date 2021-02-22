using System.Collections.Generic;
using WebChat.Models;

namespace WebChat.Data
{
    public interface IUserRepository
    {
      bool SaveChanges();

      IEnumerable<User> GetAllUsers();
      User GetUserById(int id);
      User GetUserByEmail(string email);
      void CreateUser(User user);
      void DeleteUser(User user);
    }
}
