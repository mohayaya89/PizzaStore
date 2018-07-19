
using PizzaStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace PizzaStore.Library.Models
{
    
    public class User 
    {
        [XmlArrayItem(ElementName = "OrderList")]
        public List<Order> Orders
        {
            get;
        }

        [XmlElement(ElementName = "EmailAddress")]
        public string Email
        {
            get;
            set;
        }

        [XmlAttribute(AttributeName = "MyName")]
        public string Name
        {
            get;
            set;
        }

        public User()
        {
            Orders = new List<Order>();
        }

        public void CancelOrder()
        {
            Orders.Remove(Orders.LastOrDefault());
        }

        public bool PlaceOrder()
        {
            try
            {
                Orders.Add(new Order());
                SaveUserData();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Order> ViewHistory()
        {
            return Orders.AsEnumerable<Order>().ToList();
        }

        private void SaveUserData()
        {     
            var file = new FileData();
            file.SaveToFile<User>(@"./user.xml", this);
        }
   
    }
}