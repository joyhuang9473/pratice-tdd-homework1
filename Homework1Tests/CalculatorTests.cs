using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private List<Item> _itemList;

        public CalculatorTests()
        {
            this._itemList = new List<Item>
            {
                new Item { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 },
                new Item { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 },
                new Item { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 },
                new Item { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 },
                new Item { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 },
                new Item { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 },
                new Item { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 },
                new Item { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 },
                new Item { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 },
                new Item { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 },
                new Item { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 }
            };
        }

        [TestMethod()]
        public void Verify_collection_of_summations_per_three_item_costs()
        {
            // arrange
            var target = new Calculator();
            var expected = new List<int>() { 6, 15, 24, 21 };

            // act
            var actual = target.CollectSummation(this._itemList, "Cost", 3);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Verify_collection_of_summations_per_four_item_revenues()
        {
            // arrange
            var target = new Calculator();
            var expected = new List<int>() { 50, 66, 60 };

            // act
            var actual = target.CollectSummation(this._itemList, "Revenue", 4);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}