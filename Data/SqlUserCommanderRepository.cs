using System.Collections.Generic;
using System.Linq;
using WebChat.Models;

namespace WebChat.Data
{
  public class SqlUserRepository : IUserRepository
  {
    private readonly UserContext _context;

    public SqlUserRepository(UserContext context)
    {
      _context = context;
    }

    public void CreateUser(User user)
    {
      _context.Add(user);
    }

    public void DeleteUser(User user)
    {
      _context.User.Remove(user);
    }

    public IEnumerable<User> GetAllUsers()
    {
      return _context.User.ToList();
    }

    public User GetUserByEmail(string email)
    {
      return _context.User.FirstOrDefault(user => user.Email == email);
    }

    public User GetUserById(int id)
    {
      return _context.User.FirstOrDefault(user => user.Id == id);
    }

    public bool SaveChanges()
    {
      return _context.SaveChanges() >= 0;
    }
  }
}
