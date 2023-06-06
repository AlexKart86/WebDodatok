using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Karpaty.ViewModels
{
    public class LoginModel
    {
        [Required]
        [DisplayName("Логін")]
        public string UserName { get; set; } = null!;

        [Required]
        [DisplayName("Пароль")]
        public string UserPassword { get; set; } = null!;
    }
}
