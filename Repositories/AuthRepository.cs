using Food_Ordering_ApI.Data;
using Food_Ordering_ApI.Migrations;
using Food_Ordering_ApI.Models;
using Microsoft.EntityFrameworkCore;
namespace Food_Ordering_ApI.Repositories
{
    public class AuthRepository: IAuthRepository
    {
        private readonly Food_AppDbContext _context;
        
        public AuthRepository(Food_AppDbContext context)
        {
            _context = context;
        }
        LoginResponseViewModel IAuthRepository.Login(LoginViewModel login)
        {
            var users = _context.Users
        .Include(u => u.UserRole)
        .FirstOrDefault(u => u.UserName.Equals(login.User_Name) && u.Password == login.Password);
            LoginResponseViewModel response = new LoginResponseViewModel();
            if (users != null)
            {
                response = new LoginResponseViewModel { IsSuccess = true, User = users, Token = "", Message = "login sucessfull" };
                return response;
            }
            response = new LoginResponseViewModel { IsSuccess = false, User = null, Token = "", Message = "Login usucess plese provide valid credintials" };
            return response;
        }

    }
}
