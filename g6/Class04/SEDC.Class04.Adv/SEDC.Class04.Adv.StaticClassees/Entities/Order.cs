namespace SEDC.Class04.Adv.StaticClassees.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public string Description { get; set; }
        public OrderStatus Status { get; set; }

        public Order()
        {
            Status = OrderStatus.Processing;
        }

        public Order(int id, string title, string description, OrderStatus orderStatus)
        {
            Id = id;
            Title = title;
            Description = description;
            Status = orderStatus;
        }

        public string Print()
        {
            return $"{TextHelper.CapitalFirstLetter(Title)} - {Description}";
        }
    }

    public enum OrderStatus
    {
        Processing = 0,
        Delivered,
        DeliveryInProgress,
        CouldNotDeliver
    }
}