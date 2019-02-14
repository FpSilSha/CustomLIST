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
        [TestMethod]
        public void ListMinusOperator_SingleValueRemoved_ValuesOfListRemoved()
        {
            SilvsList<int> myList = new SilvsList<int>();
            SilvsList<int> myList2 = new SilvsList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            myList2.Add(4);
            myList2.Add(5);
            myList2.Add(1);

            SilvsList<int> resultList = myList - myList2;
            SilvsList<int> expectedList = new SilvsList<int>();
            expectedList.Add(2);
            expectedList.Add(3);
            Assert.AreEqual(resultList[0], expectedList[0]);
            Assert.AreEqual(resultList[1], expectedList[1]);
        }
        [TestMethod]
        public void ListMinusOperator_MultiValuesRemoved_ValuesOfListRemoved()
        {
            SilvsList<int> myList = new SilvsList<int>();
            SilvsList<int> myList2 = new SilvsList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            myList2.Add(4);
            myList2.Add(2);
            myList2.Add(1);

            SilvsList<int> resultList = myList - myList2;
            
            
            Assert.AreEqual(resultList[0], 3);

        }
        [TestMethod]
        public void ListMinusOperator_MultiValuesRemoved_CountCorrect()
        {
            SilvsList<int> myList = new SilvsList<int>();
            SilvsList<int> myList2 = new SilvsList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            myList2.Add(4);
            myList2.Add(2);
            myList2.Add(1);

            SilvsList<int> resultList = myList - myList2;

            Assert.AreEqual(resultList.Count, 1);
        }
        [TestMethod]
        // If list has 3 values that are equal and the list instance is removing the same values only twice, the third should remain.
        public void ListMinusOperator_MultiValuesRemoved_OnlyCorrectAmountRemoved()
        {
            SilvsList<int> myList = new SilvsList<int>();
            SilvsList<int> myList2 = new SilvsList<int>();

            myList.Add(1);
            myList.Add(1);
            myList.Add(1);

            myList2.Add(4);
            myList2.Add(1);
            myList2.Add(1);

            SilvsList<int> resultList = myList - myList2;

            Assert.AreEqual(resultList[0], 1);
        }
        [TestMethod]
        public void ListAdd_MultiValuesAdded_ListBuildsAnotherArrayToHold()
        {
            SilvsList<int> myList = new SilvsList<int>();
            myList.Add(5);
            myList.Add(5);
            myList.Add(5);
            myList.Add(5);
            myList.Add(5);
            myList.Add(5);

            Assert.AreEqual(myList.Length, 8);
        }
        [TestMethod]
        public void ListAdd_CollectionsValue_ValuesAdded()
        {

            SilvsList<int> myList = new SilvsList<int>() { 2, 1, 3, 4 };
            int expectedResult = myList[3];
            int expectedResult2 = myList[0];
            Assert.AreEqual(expectedResult, 4);
            Assert.AreEqual(expectedResult2, 2);
        }
        [TestMethod]
        public void ListAdd_CollectionsValue_countIsProper()
        {

            SilvsList<int> myList = new SilvsList<int>() { 2, 1, 3, 4 };
            
            Assert.AreEqual(myList.Count, 4);
        
        }
        [TestMethod]
        public void ListAdd_StringValue_StringAdded()
        {
            SilvsList<string> myList = new SilvsList<string>();

            myList.Add("Hello");

            Assert.AreSame(myList[0], "hello");
        }
        [TestMethod]
        public void ListOperator_AddMultiValues_ValuesAddedToEnd()
        {
            SilvsList<int> myList = new SilvsList<int>();
            SilvsList<int> myList2 = new SilvsList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(5);

            myList2.Add(4);
            myList2.Add(7);
            myList2.Add(6);

            SilvsList<int> resultList = myList + myList2;

            Assert.AreEqual(resultList[0], 1);
            Assert.AreEqual(resultList[3], 4);

        }
        [TestMethod]
        public void ListAddOperator_AddMultiValues_CountIsProper()
        {
            SilvsList<int> myList = new SilvsList<int>();
            SilvsList<int> myList2 = new SilvsList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(5);

            myList2.Add(4);
            myList2.Add(7);
            myList2.Add(6);

            SilvsList<int> resultList = myList + myList2;

            Assert.AreEqual(resultList.Count, 6);
        }
        [TestMethod]
        public void ListAddOperator_AddMultiValues_LengthIncreases()
        {
            SilvsList<int> myList = new SilvsList<int>();
            SilvsList<int> myList2 = new SilvsList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(5);

            myList2.Add(4);
            myList2.Add(7);
            myList2.Add(6);

            SilvsList<int> resultList = myList + myList2;

            Assert.AreEqual(resultList.Length, 8);
        }





    }
}
