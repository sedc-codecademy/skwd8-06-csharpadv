using System;
using System.Collections.Generic;
using System.Text;

namespace Static.Entities
{
    public class Order //static 
    {
        public Order()
        {
            Status = OrderStatus.Proccessing;
        }
        public Order(int id, string title, string description, OrderStatus status)
        {
            Id = id;
            Title = title;
            Description = description;
            Status = status;
        }
        private int _id;
        public int Id
        {
            get { return _id; }
            set { if (value > 0) //value == null
                {
                    _id = value;
                }}
        }
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public OrderStatus Status { get; set; }
        public string Print()
        {
            return $"{TextHelper.CapitalFirstLetter(Title)} - {Description}";
        }

        public static bool IsOrderValid(Order order)
        {
            if (order.Id <= 0 && (order.Title == "" || order.Title == null))
                return false;
            return true;
        }

        //public void setId() {
        //    id = 5;
        //}

    }
}
