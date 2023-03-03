using System.ComponentModel.DataAnnotations;

namespace AgricultureUI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage ="Lütfen şifrenizi giriniz")]
        public string password { get; set; }
    }
}
