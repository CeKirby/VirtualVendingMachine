using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTests
{
    [TestClass]
    public class ProgramTest
    {// Infinite loop needs to be fixed 
     //[TestMethod]
     //public void Start()
     //{
     //    Program start = new Program();
     //    bool expectedReturn = true;
     //    Assert.AreEqual(expectedReturn, start.MainMenu());
     //}

        [TestMethod]
        public void ItemExists()
        {
            Item isItThere = new Item("A1");
            string expectedResult = "A1";
            Assert.AreEqual(expectedResult, isItThere.ItemID);
        }
        [TestMethod]
        public void ItemExists2()
        {
            Item isItThere = new Item("D4");
            string expectedResult = "D4";
            Assert.AreEqual(expectedResult, isItThere.ItemID);
        }
        [TestMethod]
        public void ItemDoesntExists()
        {
            Item isItThere = new Item("");
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, isItThere.ItemExists("A4"));
        }
        [TestMethod]
        public void ItemDoesntExists2()
        {
            Item isItThere = new Item("");
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, isItThere.ItemExists("a4"));
        }
        [TestMethod]
        public void ItemDoesntExists3()
        {
            Item isItThere = new Item("");
            bool expectedResult = false;
            Assert.AreEqual(expectedResult, isItThere.ItemExists("A45"));
        }




        //only methods in program and menu that arent void is main menu so this is the only test for both classes 
    }
}
