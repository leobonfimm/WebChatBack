using System.ComponentModel.DataAnnotations;

namespace WebChat.Dtos
{
    public class UserCreateDto
    {
      [Required]
      [MaxLength(100)]
      public string Name { get; set; }

      [Required]
      [EmailAddress]
      public string Email { get; set; }
    }
}
