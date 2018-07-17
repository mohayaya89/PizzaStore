using PizzaStore.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace PizzaStore.Tests
{
    public class OrderTests
    {
        private Order sut;

        public OrderTests()
        {
            sut = new Order();
        }

        #region Order Data and State Tests

        [Fact]
        public void Test_Order_Pizzas()
        {
            var expected = 0;

            Assert.IsType<List<Pizza>>(sut.Pizzas);
            Assert.True(expected <= sut.Pizzas.Count);
        }

        [Fact]
        public void Test_Order_Cost()
        {
            var expected = 0;

            Assert.IsType<decimal>(sut.Cost);
            Assert.True(expected <= sut.Cost);
        }

        [Fact]
        public void Test_Order_Date()
        {
            var expected = DateTime.Now;

            Assert.IsType<DateTime>(sut.OrderDate);
            Assert.True(expected > sut.OrderDate);
        }

        #endregion

        #region Order Behavior Tests

        [Theory]
        [InlineData(typeof(Pizza))]
        public void Test_Order_CreatePizza(Type type)
        {
            var expected = type;

            Assert.True(expected == sut.CreatePizza().GetType());
        }

        [Fact]
        public void Test_Order_AddToOrder()
        {
            var expected = sut.CreatePizza();
            var actual = sut.Pizzas;

            sut.AddToOrder(expected);

            Assert.Same(expected, actual.Last());
        }

        [Fact]
        public void Test_Order_ComputeCost()
        {
            var pizza = sut.CreatePizza();
            var expected = pizza.Cost;

            sut.AddToOrder(pizza);

            Assert.Equal(expected, sut.ComputeCost());
        }

        #endregion
    }
}
