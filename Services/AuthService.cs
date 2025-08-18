using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Food_Ordering_ApI.Models;
using Food_Ordering_ApI.Repositories;
using Microsoft.IdentityModel.Tokens;
namespace Food_Ordering_ApI.Services
{
    public class AuthService: IAuthService
    {
        private readonly IAuthRepository _repos;
        private readonly IConfiguration _config;
        public AuthService(IAuthRepository repos, IConfiguration config)
        {
            _repos = repos;
            _config = config;
        }
        LoginResponseViewModel IAuthService.Login(LoginViewModel login)
        {
            var response = _repos.Login(login);
            if (response.IsSuccess)
            {
                response.Token = GenerateToken(response.User);
                return response;
            }
            return response;
        }



        public string GenerateToken(User user)
        {
            var secretKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_config["JwtSettings:SecretKey"])); // no space after :

            var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
        new Claim(ClaimTypes.Name, user.UserName),
        new Claim(ClaimTypes.Email, user.Email),
        new Claim(ClaimTypes.Role, user.UserRole.role.ToString()),
        new Claim("MyClaim", user.Email)
    };

            var tokenOptions = new JwtSecurityToken(
                issuer: _config["JwtSettings:Issuer"],     // no space
                audience: _config["JwtSettings:Audience"], // no space
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: signingCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }
    }
}
