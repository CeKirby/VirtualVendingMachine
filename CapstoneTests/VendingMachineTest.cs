using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTests
{
    [TestClass]
    public class VendingMachineTest
    {
        [TestMethod]
        public void AddMoney()
        {
            VendingMachine addMoney = new VendingMachine();
            decimal expectedReturn = 2m;
            Assert.AreEqual(expectedReturn, addMoney.FeedMoney(2));
        }
        [TestMethod]
        public void ReturnMoney()
        {
            VendingMachine returnMoney = new VendingMachine();
            decimal expectedReturn = 3m;
            Assert.AreEqual(expectedReturn,returnMoney.ReturnMoney(3m));
        }
    }
}
