using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food_Ordering_ApI.Models
{
    public enum PaymentMode
    {
        Cash,
        UPI
    }
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        
        public decimal SubTotal { get; set; }

      
        public decimal DiscountApplied { get; set; }

        
        public decimal FinalTotal { get; set; }

        [Required]
        public PaymentMode PaymentMode { get; set; }

        // Foreign Key → Delivery Partner
        [ForeignKey("DeliveryPartner")]
        public int DeliveryPartnerId { get; set; }
        public virtual DeliveryPartner ?DeliveryPartner { get; set; }

    
        public virtual ICollection<OrderItem> Items { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public User? Customer { get; set; }
    }
}
