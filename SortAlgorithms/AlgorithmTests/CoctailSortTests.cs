﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Tests
{
    [TestClass()]
    public class CoctailSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            // Arrange
            var coctail = new CoctailSort<int>();

            var rnd = new Random();
            var items = new List<int>();

            for (var i = 0; i < 10000; i++)
            {
                items.Add(rnd.Next(0, 100));
            }

            coctail.Items.AddRange(items);
            var sorted = items.OrderBy(x => x).ToArray();

            // Act 
            coctail.Sort();


            // Assert
            for (var i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], coctail.Items[i]);
            }
        }
    }
}