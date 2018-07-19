using PizzaStore.Library.Models;
using System;
using PizzaStore.Library.Enum;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PizzaStore.Tests
{
    public class PizzaTests
    {
        private Pizza sut;
        public PizzaTests()
        {
            sut = new Pizza();
        }
        
        [Fact]
        public void Test_PizzaCrust()
        {
            Assert.IsType<List<ECrust>>(sut.Crust);
        }

        [Fact]
        public void Test_PizzaCheese()
        {
            Assert.IsType<List<ECheese>>(sut.Cheeses);           
        }

        [Fact]
        public void Test_PizzaSauce()
        {
            Assert.IsType<List<ESauce>>(sut.Sauce);
        }

        [Fact]
        public void Test_PizzaToppings()
        {
            Assert.IsType<List<ETopping>>(sut.Toppings);
        }

        [Fact]
        public void Test_PizzaSize()
        {
            Assert.IsType<List<ESize>>(sut.Size);
        }

        [Fact]
        public void Test_NoMoreThan3Topping()
        {
            var expected = 3;

            sut.AddTopping(ETopping.Onion);
            sut.AddTopping(ETopping.Pepperoni);
            sut.AddTopping(ETopping.Chicken);

            Assert.True(expected >= sut.Toppings.Count);
        }

        [Fact]
        public void Test_NoMoreThan2Cheese()
        {
            var expected = 2;

            sut.AddCheese(ECheese.Mozarella);
            sut.AddCheese(ECheese.Chedder);

            Assert.True(expected >= sut.Cheeses.Count);
        }

        [Fact]
        public void Test_NoMoreThan1Sauce()
        {
            var expected = 1;

            sut.AddSauce(ESauce.Alfredo);

            Assert.True(expected >= sut.Sauce.Count);
        }

        [Fact]
        public void Test_PizzaCost()
        {
            Assert.IsType<decimal>(sut.Cost);
        }
    }

    
}
