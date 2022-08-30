using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetcore_api_jwt_refresh_token.Entities;
using aspnetcore_api_jwt_refresh_token.Models;

namespace aspnetcore_api_jwt_refresh_token.Services
{
    public interface IUserService
    {
        Task<AuthenticateResponse> Authenticate(AuthenticateRequest model, string ipAddress);
        Task<AuthenticateResponse> RefreshToken(string token, string ipAddress);
        Task<bool> RevokeToken(string token, string ipAddress);
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(int id);
    }
}