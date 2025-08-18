namespace Food_Ordering_ApI.Models
{
    public class LoginResponseViewModel
    {
        public bool IsSuccess { get; set; }

        public User User { get; set; }
        public string Token { get; set; }

        public string Message { get; set; }
    }
}
