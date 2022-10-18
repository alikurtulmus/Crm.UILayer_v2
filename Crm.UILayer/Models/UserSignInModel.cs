using System.ComponentModel.DataAnnotations;

namespace Crm.UILayer.Models
{
    public class UserSignInModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını boş geçmeyiniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi boş geçmeyiniz")]
        public string Password { get; set; }
    }
}
