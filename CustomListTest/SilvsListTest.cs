using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class SilvsListTest
    {
        [TestMethod]
        public void ListAdd_AnyValue_CountIncreases()
        {
            //Arrange
            SilvsList<int> myList = new SilvsList<int>();
            int value = 3;
            int expectedResult = 1;
            //Act
            myList.Add(value);

            //Assert
            Assert.AreEqual(expectedResult, myList.Count);
        }
        [TestMethod]
        public void ListAdd_AnyValue_ValueAdded()
        {
            //Arrange
            SilvsList<int> myList = new SilvsList<int>();
            int value = 3;
            int expectedResult = 3;
            //Act
            myList.Add(value);

            //Assert
            Assert.AreEqual(expectedResult, myList[0]);
        }
        [TestMethod]
        public void ListAdd_TwoValues_ValueAtZeroIsFirstValue()
        {
            //Arrange
            SilvsList<int> myList = new SilvsList<int>();
            int value = 3;
            int value1 = 5;
            int expectedResult = 3;
            //Act
            myList.Add(value);
            myList.Add(value1);

            //Assert
            Assert.AreEqual(expectedResult, myList[0]);
        }
        [TestMethod]
        public void ListAdd_TwoValues_ValueAtOneIsSecondValue()
        {
            //Arrange
            SilvsList<int> myList = new SilvsList<int>();
            int value = 3;
            int value1 = 5;
            int expectedResult = 5;
            //Act
            myList.Add(value);
            myList.Add(value1);

            //Assert
            Assert.AreEqual(expectedResult, myList[1]);
        }
        [TestMethod]
        public void ListAdd_TwoValues_CountIncreased()
        {
            SilvsList<int> myList = new SilvsList<int>();

            myList.Add(2);
            myList.Add(4);

            int expectedValue = 2;

            Assert.AreEqual(expectedValue, myList.Count);         
        }
        [TestMethod]

        public void ListRemove_SingleValue_CountDecreases()
        {
            SilvsList<int> myList = new SilvsList<int>();

            myList.Add(2);
            myList.Add(3);
            myList.Remove(3);

            int expectedValue = 1;

            Assert.AreEqual(expectedValue, myList.Count);

        }
        [TestMethod]
        public void ListRemove_SingleValue_ItemRemoved()
        {
            SilvsList<int> myList = new SilvsList<int>();

            myList.Add(2);
            myList.Add(5);
            myList.Remove(5);



            Assert.AreEqual(myList, 2);
        }
        [TestMethod]
        public void ListRemove_SingleValue_ListEmpty()
        {
            SilvsList<int> myList = new SilvsList<int>();
            myList.Add(5);
            myList.Remove(5);

            Assert.AreEqual(0, myList.Count);

        }
        [TestMethod]
        public void ListRemove_SingleValue_ListShifts()
        {
            SilvsList<int> myList = new SilvsList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Remove(1);

            Assert.AreEqual(2, myList[0]);

        }
        [TestMethod]
        public void ListRemove_SingleValue_ListAdjustNextValuesAfterRemoveToPrevious()
        {
            SilvsList<int> myList = new SilvsList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Remove(2);

            Assert.AreEqual(1, myList[0]);
            Assert.AreEqual(3, myList[1]);

        }
        [TestMethod]
        public void ListRemove_SingleValue_OnlyFirstInstanceRemoved()
        {
            SilvsList<int> myList = new SilvsList<int>();
            myList.Add(5);
            myList.Add(5);
            myList.Add(5);
            myList.Remove(5);

            Assert.AreEqual(5, myList[1]);
        }
        //[TestMethod]
        //public void ListAdd_CollectionsValue_ValuesAdded()
        //{

        //    SilvsList<int> myList = new SilvsList<int>() { 2, 1, 3, 4 };
        //    int expectedResult = myList[3];
        //    Assert.AreEqual(expectedResult, 4);
        //}

    }
}
