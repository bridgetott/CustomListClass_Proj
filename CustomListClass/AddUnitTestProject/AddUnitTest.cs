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
            actual = bridgetsList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_FivePositiveNumbers_CapacityEight()
        {
            //arrange
            BridgetsList<int> bridgetsList = new BridgetsList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 8;
            int actual;

            //act
            bridgetsList.Add(value1);
            bridgetsList.Add(value2);
            bridgetsList.Add(value3);
            bridgetsList.Add(value4);
            bridgetsList.Add(value5);
            actual = bridgetsList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddOneValue_CheckZeroIndex()
        {
            //arrange
            BridgetsList<int> bridgetsList = new BridgetsList<int>();
            int value1 = 1;
            
            int expected = 1;
            int actual;

            //act
            bridgetsList.Add(value1);
           
            actual = bridgetsList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddSecondValue_CheckZeroIndexToStayTheSame()
        {
            //arrange
            BridgetsList<int> bridgetsList = new BridgetsList<int>();
            int value1 = 1;
            int value2 = 2;

            int expected = 1;
            int actual;

            //act
            bridgetsList.Add(value1);
            bridgetsList.Add(value2);

            actual = bridgetsList[0];
            
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddSecondValue_CheckOneIndexToStayTheSame()
        {
            //arrange
            BridgetsList<int> bridgetsList = new BridgetsList<int>();
            int value1 = 1;
            int value2 = 2;

            int expected = 2;
            int actual;

            //act
            bridgetsList.Add(value1);
            bridgetsList.Add(value2);

            actual = bridgetsList[1];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_CheckListCapacity_CapacityFour()
        {
            //arrange
            BridgetsList<int> bridgetsList = new BridgetsList<int>();            

            int expected = 4;
            int actual;

            //act
           
            actual = bridgetsList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
