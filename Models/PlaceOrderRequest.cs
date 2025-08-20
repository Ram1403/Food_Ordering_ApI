namespace Food_Ordering_ApI.Models
{
    public class PlaceOrderRequest
    {
        public int CustomerId { get; set; }  
        public PaymentMode PaymentMode { get; set; }

        public List<OrderItemRequest> ?Items { get; set; }
    }
}
