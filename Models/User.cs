using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food_Ordering_ApI.Models
{
    
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="User name is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="email")]
        [EmailAddress(ErrorMessage ="plese enter valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage ="password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }  

        [ForeignKey("UserRole")]
        public int UserRole_Id { get; set; }
        public virtual UserRole? UserRole {get;set;}

       
        //public ICollection<Order> ?Orders { get; set; }
    }
}
