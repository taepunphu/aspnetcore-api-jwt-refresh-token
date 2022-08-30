using System.ComponentModel.DataAnnotations;

namespace aspnetcore_api_jwt_refresh_token.Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}