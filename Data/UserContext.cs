using Microsoft.EntityFrameworkCore;
using WebChat.Models;

namespace WebChat.Data
{
    public class UserContext : DbContext
    {
      public UserContext(DbContextOptions<UserContext> opt) : base(opt)
      {

      }

      public DbSet<User> User { get; set; }
    }
}
