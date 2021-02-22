using System.ComponentModel.DataAnnotations;

namespace WebChat.Dtos
{
    public class CommandCreateDto
    {
      [Required]
      [MaxLength(250)]
      public string HowTo { get; set; }

      [Required]
      public string Line { get; set; }

      [Required]
      public string Platform { get; set; }
    }
}
