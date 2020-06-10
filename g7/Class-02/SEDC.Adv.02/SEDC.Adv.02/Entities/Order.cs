using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._02.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public OrderStatus Status { get; set; }

        // new Order(); \/ This method is called
        // If we don't have an empty constrcutor, but have another constractor with parameters then the code will give an error when new Order() is typed
        // If there is NO constructors on a class, then the empty constructor is default
        public Order()
        {

        }
        // new Order(1, "stuff", "stuff", OrderStatus.Delivered); \/ This method is called
        public Order(int id, string title, string desc, OrderStatus status)
        {
            Id = id;
            Title = title;
            Description = desc;
            Status = status;
        }
        public string Print()
        {
            return $"{TextHelper.CapitalFirstLetter(Title)} - {Description}";
        }
    }

    public enum OrderStatus
    {
        Processing,
        Delivered,
        DeliveryInProgress,
        CouldNotBeDelivered
    }
}
