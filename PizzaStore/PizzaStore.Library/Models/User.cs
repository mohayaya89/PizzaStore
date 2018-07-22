using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using PizzaStore.Library.Abstracts;

namespace PizzaStore.Library.Models
{
    
    public class User : A_ID
    {
        [XmlArrayItem(ElementName = "OrderList")]
        public List<Order> Orders
        {
            get;
            set;
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

        [XmlElement(ElementName = "PhoneNumber")]
        public double Phone
        {
            get;
            set;
        }
        [XmlElement(ElementName = "Address")]
        public string Address
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
                Orders.Add(new Order()
                {
                    OrderDate = new DateTime()
                });
                //SaveUserData();
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

        //private void SaveUserData()
        //{     
        //    var file = new FileData();
        //    file.SaveToFile<User>(@"./user.xml", this);
        //}
   
    }
}