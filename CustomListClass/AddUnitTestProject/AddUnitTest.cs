using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace AddUnitTestProject
{
    [TestClass]
    public class AddUnitTest
    {
        [TestMethod]
        public void Add_FivePositiveNumbers_CountFive()
        {
            //arrange
            BridgetsList<int> bridgetsList = new BridgetsList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 5;
            int actual;
            //act
            bridgetsList.Add(value1);
            bridgetsList.Add(value2);
            bridgetsList.Add(value3);
            bridgetsList.Add(value4);
            bridgetsList.Add(value5);
            actual = bridgetsList.count;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ThreePositiveNumbers_CapacityNine()
        {
            //arrange
            BridgetsList<int> bridgetsList = new BridgetsList<int>();

            int expected =
            int actual;
            //act

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //public void Add_FivePositiveNumbers_CountFive()
        //{
        //    //arrange
        //    BridgetsList<int> bridgetsList = new BridgetsList<int>();
        //    int value1 = 1;
        //    int value2 = 2;
        //    int value3 = 3;
        //    int expected = 3;
        //    int actual;
        //    //act
        //    bridgetsList.Add(value1);
        //    bridgetsList.Add(value2);git
        //    bridgetsList.Add(value3);
        //    actual = bridgetsList.count;
        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
