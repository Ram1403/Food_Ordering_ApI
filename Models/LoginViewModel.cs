
using System.ComponentModel.DataAnnotations;

namespace Food_Ordering_ApI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "User Name is Required")]
        public string User_Name { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is Required")]

        public string Password { get; set; }
    }
}
