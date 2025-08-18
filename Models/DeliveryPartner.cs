using System.ComponentModel.DataAnnotations;

namespace Food_Ordering_ApI.Models
{
    public class DeliveryPartner
    {
        [Key]
        public int DeliveryPartnerId { get; set; }

        [Required(ErrorMessage ="Partner Name is Required")]
        public string Name { get; set; }

        // Navigation property: One delivery partner can deliver many orders
        //public ICollection<Order>? Orders { get; set; }
    }
}
