using Food_Ordering_ApI.Models;

namespace Food_Ordering_ApI.Repositories
{
    public interface IAuthRepository
    {
        LoginResponseViewModel Login(LoginViewModel loginViewModel);
    }
}
