using System.ComponentModel.DataAnnotations;

namespace ExoAPI.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-mail Requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha requerida")]
        public string Senha { get; set; }
    }
}
