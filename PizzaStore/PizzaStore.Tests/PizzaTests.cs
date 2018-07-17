using PizzaStore.Library.Models;
using System;
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
            sut = new Pizza()
            {
                Crust = new Crust(),
                Cheeses = new List<Cheese>(),
                Sauce = new Sauce(),
                Toppings = new List<Topping>(),
                Size = new Size()
            };
        }
        
        [Fact]
        public void Test_PizzaCrust()
        {
            Assert.IsType<Crust>(sut.Crust);
        }

        [Fact]
        public void Test_PizzaCheese()
        {
            Assert.IsType<List<Cheese>>(sut.Cheeses);
        }

        [Fact]
        public void Test_PizzaSauce()
        {
            Assert.IsType<Sauce>(sut.Sauce);
        }

        [Fact]
        public void Test_PizzaToppings()
        {
            Assert.IsType<List<Topping>>(sut.Toppings);
        }

        [Fact]
        public void Test_PizzaSize()
        {
            Assert.IsType<Size>(sut.Size);
        }

        [Fact]
        public void Test_PizzaCost()
        {
            Assert.IsType<decimal>(sut.Cost);
        }
    }

    
}
