using System.ComponentModel.DataAnnotations;

namespace WebChat.Models
{
  public class User
  {
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }
  }
}
