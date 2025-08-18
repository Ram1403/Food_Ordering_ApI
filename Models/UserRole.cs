using System.ComponentModel.DataAnnotations;

namespace Food_Ordering_ApI.Models
{
    public enum Role { ADMIN, CUSTOMER };
    
    public class UserRole
    {

        [Key]
        public int UserRole_Id { get; set; }
        [Required]
        public Role role { get; set; }

        public virtual IEnumerable<User>? User { get; set; }

    }
}
