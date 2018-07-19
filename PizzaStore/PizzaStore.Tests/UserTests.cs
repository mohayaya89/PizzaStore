using PizzaStore.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace PizzaStore.Tests
{
    public class UserTests
    {
        private static User sut;
        

        public UserTests()
        {
            sut = new User()
            {
                Name = "Ben Simmons",
                Email = "ben@franklin.com"
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
