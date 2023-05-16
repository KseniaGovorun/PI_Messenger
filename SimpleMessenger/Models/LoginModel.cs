using System.ComponentModel.DataAnnotations;

namespace SimpleMessenger.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email не вказано")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пароль не вказано")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}