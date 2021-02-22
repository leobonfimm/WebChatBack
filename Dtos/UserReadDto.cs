using System.ComponentModel.DataAnnotations;

namespace WebChat.Dtos
{
    public class UserReadDto
    {
      public int Id { get; set; }

      public string Name { get; set; }

      [EmailAddress]
      public string Email { get; set; }
    }
}
