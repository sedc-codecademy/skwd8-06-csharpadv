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
