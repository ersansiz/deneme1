using System.ComponentModel.DataAnnotations;

namespace deneme12.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Kullanıcı adı boş olamaz")]
        public string UserName { get; set;}
        [Required(ErrorMessage = "şifre boş olamaz")]
        public string Password { get; set;}
        public bool RememberMe { get; set;}
    }
}
