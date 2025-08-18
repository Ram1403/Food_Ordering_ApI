using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food_Ordering_ApI.Models
{
    public class Discount
    {
        [Key]
        public int DiscountId { get; set; }

        [Required(ErrorMessage ="Description is required")]
        public string Description { get; set; }

     
        public decimal Threshold { get; set; }   // e.g. ₹500

        
        public decimal FlatDiscount { get; set; } // e.g. ₹50
    }
}
