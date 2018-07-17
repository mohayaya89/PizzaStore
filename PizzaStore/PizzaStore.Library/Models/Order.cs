﻿using PizzaStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaStore.Library.Models
{
    public class Order
    {
        #region Order Properties

        public List<Pizza> Pizzas
        {
            get;
            set;
        }

        public decimal Cost
        {
            get;
            set;
        }

        public DateTime OrderDate
        {
            get;
            set;
        }

        #endregion

        public Order()
        {
            Pizzas = new List<Pizza>();
        }

        #region Order Methods

        public void AddToOrder(Pizza pizza)
        {
            Pizzas.Add(pizza);
        }

        public decimal ComputeCost()
        {
            var sum = decimal.Zero;

            foreach (var pizza in Pizzas)
            {
                if (sum < 1000)
                {
                    sum += pizza.Cost;
                }
            }

            return sum;
        }

        public Pizza CreatePizza()
        {
            return new Pizza();
        }

        #endregion
    }
}
