using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food_Ordering_ApI.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }

        // Foreign Key → Order
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order ?Order { get; set; }

        // Foreign Key → MenuItem
        [ForeignKey("MenuItem")]
        public int MenuItemId { get; set; }
        public virtual MenuItem? MenuItem { get; set; }

        public int Quantity { get; set; }

      
        public decimal UnitPrice { get; set; }

        
        public decimal Total => UnitPrice * Quantity;
    }
}
