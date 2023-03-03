using System.ComponentModel.DataAnnotations;

namespace AgricultureUI.Models
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage ="Lütfen Kullanıcı Adını giriniz")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Lütfen mailinizi giriniz")]
        public string mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi giriniz")]
        public string password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("password", ErrorMessage ="Lütfen iki şifrenin de aynı oldugundan emin olunuz")]
        public string passwordConfirm { get; set; }

    }
}
