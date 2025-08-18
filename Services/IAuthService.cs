using Food_Ordering_ApI.Models;

namespace Food_Ordering_ApI.Services
{
    public interface IAuthService
    {
        LoginResponseViewModel Login(LoginViewModel loginViewModel);
    }
}
