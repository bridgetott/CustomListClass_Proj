using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace AddUnitTestProject
{
    [TestClass]
    public class RemoveUnitTest
    {
        [TestMethod]

        public void Remove_ThreePositiveNumbers_CountTwo() 
        {
            //arrange
            BridgetsList<int> bridgetsList = new BridgetsList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 2;
            int actual;

            //act
            bridgetsList.Add(value1);
            bridgetsList.Add(value2);
            bridgetsList.Add(value3);
            bridgetsList.Add(value4);
            bridgetsList.Add(value5);
            bridgetsList.Remove(value3);
            bridgetsList.Remove(value4);
            bridgetsList.Remove(value5);


            actual = bridgetsList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Remove_ValueFour_ThreeIndexFive()
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
            bridgetsList.Remove(value4)
            

            actual = bridgetsList[3];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Remove_ThreePositiveNumbers_ZeroIndexFour()
        {
            //arrange
            BridgetsList<int> bridgetsList = new BridgetsList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 4;
            int actual;

            //act
            bridgetsList.Add(value1);
            bridgetsList.Add(value2);
            bridgetsList.Add(value3);
            bridgetsList.Add(value4);
            bridgetsList.Add(value5);
            bridgetsList.Remove(value1);
            bridgetsList.Remove(value2);
            bridgetsList.Remove(value3);

            actual = bridgetsList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Remove_ValueSix_ZeroIndexOne()
        {
            //arrange
            BridgetsList<int> bridgetsList = new BridgetsList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int expected = 1;
            int actual;

            //act
            bridgetsList.Add(value1);
            bridgetsList.Add(value2);
            bridgetsList.Add(value3);
            bridgetsList.Add(value4);
            bridgetsList.Add(value5);
            bridgetsList.Remove(value6);
    

            actual = bridgetsList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Remove_ValueFourWhenInTheListMultipleTimes_FourIndexFour()
        {
            //arrange
            BridgetsList<int> bridgetsList = new BridgetsList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;            
            int expected = 1;
            int actual;

            //act
            bridgetsList.Add(value1);
            bridgetsList.Add(value2);
            bridgetsList.Add(value3);
            bridgetsList.Add(value4);
            bridgetsList.Add(value5);
            bridgetsList.Add(value4);
            bridgetsList.Remove(value4);
            


            actual = bridgetsList[4];

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
