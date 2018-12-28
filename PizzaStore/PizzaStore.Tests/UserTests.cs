using PizzaStore.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using PizzaStore.Data;

namespace PizzaStore.Tests
{
    public class UserTests
    {
        public User sut;
        private  EntityData entity = new EntityData();
         

        public UserTests()
        {
            sut = new User()
            {
                Name = "Ben Simmons",
                Email = "ben@franklin.com",
                //Phone = 571-444-5555,
                //Address = "11730 Plaza America Dr #205, Reston, VA 20190"
            };
        }

        [Fact]
        public void Test_UserEmail()
        {
            Assert.IsType<string>(sut.Email);
        }

        [Fact]
        public void Test_UserName()
        {
            Assert.IsType<string>(sut.Name);
        }

        [Fact]
        public void Test_User()
        {
            Assert.NotNull(sut.Email);
            Assert.NotNull(sut.Name);
        }

        [Fact]
        public void Test_UserPlaceOrder()
        {
            Assert.True(sut.PlaceOrder());
        }

        [Fact]
        public void Test_SaveUser()
        {
            sut.PlaceOrder();
            entity.Save(sut);

            //var exp = entity.Read("ben@franklin.com");

            //Assert.True(exp.Orders.Count == 1);
           
            Assert.True(1 <= entity.GetAll().Count);
        }

        [Fact]
        public void Test_WriteUser()
        {

        }

        [Fact]
        public void Test_UserViewHistory()
        {
            Assert.Equal(0, sut.ViewHistory().Count<Order>());
        }

        [Fact]
        public void Test_UserCancelOrder()
        {
            sut.CancelOrder();
            Assert.Equal(0, sut.ViewHistory().Count<Order>());
        }
    }
}
