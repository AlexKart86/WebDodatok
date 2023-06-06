using System.ComponentModel.DataAnnotations;

namespace Karpaty.Models
{
    public class Admin
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        public string UserPassword { get; set; } = null!;

    }
}
