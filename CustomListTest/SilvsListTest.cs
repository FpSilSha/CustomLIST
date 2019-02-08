using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTest
{
    [TestClass]
    public class SilvsListTest
    {
            [TestMethod]
            public void TestMethod1()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>();
                int value = 3;
                int expectedResult = 1;
                //Act
                myList.Add(value);

                //Assert
                Assert.AreEqual(expectedResult, myList.Count);
            }
            [TestMethod]
            public void TestMethod2()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>();
                int value = 3;
                int expectedResult = 3;
                //Act
                myList.Add(value);

                //Assert
                Assert.AreEqual(expectedResult, myList[0]);
            }
            [TestMethod]
            public void TestMethod3()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>();
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
            public void TestMethod4()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>();
                int value = 3;
                int value1 = 5;
                int expectedResult = 5;
                //Act
                myList.Add(value);
                myList.Add(value1);

                //Assert
                Assert.AreEqual(expectedResult, myList[1]);
            }
    }
}
