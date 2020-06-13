using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace SEDC.StaticClassesAndPolymorphism.Models
{
    //This enum can be in separate file
    public enum OrderStatus
    {
        Processing, 
        Fullfiled,
        DeliveryInProgress,
        CouldNotDeliver
    }

    public class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public OrderStatus Status { get; set; }

        public Order()
        {

        }
        public Order(int id, string title, string description, OrderStatus orderStatus)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Status = orderStatus;
        }

        public string Print()
        {
            return $"{TextHelper.CapitalFirstLetter(Title)} - {Description}";
        }

    }
}
