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
            Assert.IsType<List<Crust>>(sut.Crust);
        }

        [Fact]
        public void Test_PizzaCheese()
        {
            Assert.IsType<List<Cheese>>(sut.Cheeses);           
        }

        [Fact]
        public void Test_PizzaSauce()
        {
            Assert.IsType<List<Sauce>>(sut.Sauce);
        }

        [Fact]
        public void Test_PizzaToppings()
        {
            Assert.IsType<List<Topping>>(sut.Toppings);
        }

        [Fact]
        public void Test_PizzaSize()
        {
            Assert.IsType<List<Size>>(sut.Size);
        }

        [Fact]
        public void Test_PizzaCost()
        {
            Assert.IsType<decimal>(sut.Cost);
        }

        [Fact]
        public void Test_MustHaveExactly1Crust()
        {
            var expected = 1;

            sut.AddCrust(ECrust.Neopolitan);

            Assert.True(expected == sut.Crust.Count);
        }

        [Fact]
        public void Test_NoMoreThan1Sauce()
        {
            var expected = 1;

            sut.AddSauce(ESauce.Alfredo);

            Assert.True(expected >= sut.Sauce.Count);
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
        public void Test_NoMoreThan3Topping()
        {
            var expected = 3;

            sut.AddTopping(ETopping.Onion);
            sut.AddTopping(ETopping.Pepperoni);
            sut.AddTopping(ETopping.Chicken);

            Assert.True(expected >= sut.Toppings.Count);
        }
        
    }
 
}
