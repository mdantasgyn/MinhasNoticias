using System.ComponentModel.DataAnnotations;

namespace MinhasNoticias.Application.Requests.Identity
{
    public class TokenRequest
    {
        [Required(ErrorMessage ="O Email é obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatória!")]
        public string Password { get; set; }
    }
}