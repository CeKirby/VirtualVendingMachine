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
        public void RefundEvenDollors()
        {
            VendingMachine returnMoney = new VendingMachine();
            string expectedReturn = "Your Change Is 3 Dollar(s) For a Total of $3.";
            Assert.AreEqual(expectedReturn, returnMoney.FinishTransaction(3));
        }
        [TestMethod]
        public void RefundDollorsQuarters()
        {
            VendingMachine returnMoney = new VendingMachine();
            string expectedReturn = "Your Change Is 4 Dollar(s) 3 Quarter(s) For a Total of $4.75.";
            Assert.AreEqual(expectedReturn, returnMoney.FinishTransaction(4.75m));
        }
        [TestMethod]
        public void RefundDollorsQuartersDimes()
        {
            VendingMachine returnMoney = new VendingMachine();
            string expectedReturn = "Your Change Is 2 Dollar(s) 2 Quarter(s) and 1 Dime(s) For a Total of $2.60.";
            Assert.AreEqual(expectedReturn, returnMoney.FinishTransaction(2.60m));
        }
        [TestMethod]
        public void RefundDollorsQuartersDimesNickles()
        {
            VendingMachine returnMoney = new VendingMachine();
            string expectedReturn = "Your Change Is 6 Dollar(s) 3 Quarter(s), 1 Dime(s) and 1 Nickel(s) For a Total of $6.90.";
            Assert.AreEqual(expectedReturn, returnMoney.FinishTransaction(6.90m));
        }
    }
}
