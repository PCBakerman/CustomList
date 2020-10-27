using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListUnitTestStarter;
using System.Collections.Generic;

namespace CustomListTests
{
    [TestClass]
    public class CustomListUnitTests
    {
        [TestMethod]
        public void Add_AddItemToEmptyList_ItemGoesToIndexZero()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 10;
            int actual;

            // Act
            testList.Add(item);
            actual = testList[0]; // error expected until "indexer property" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Add_AddItemToEmptyList_CountIncrementsToOne()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 1;
            int actual; 

            // Act
            testList.Add(item);
            actual = testList.Count; // error expected until "Count" is added to class
             
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddItem_IndexZeroRemainsUnchanged()
        {
            List<int> testList = new List<int>();
            int firstItem = 3;
            int item = 10;
            int expected = 3;
            int actual; 

            // Act
            testList.Add(firstItem);
            testList.Add(item);
            actual = testList[0]; // error expected until "Count" is added to class
            // Assert
            Assert.AreEqual(expected, actual);
            



        }
        [TestMethod]
        public void AddMultipulToListAndCountItems()
        {
            //Arrange
            Random random = new Random();
            CustomList<int> TestList = new CustomList<int>();
            int ExpectedCount = random.Next(1, 10);
            int actual;


            //Act
            for (int i = 0; i < ExpectedCount; i++)
            {
                TestList.Add(0);

            }

            actual = TestList.Count;
            //Assert
            Assert.AreEqual(actual, ExpectedCount);

        }
        [TestMethod]
        public void CapacityStartsAtFour()
        {   
            //Arrange 
            CustomList<int> TestList = new CustomList<int>();
            int ExpectedCapcity = 4;
            
            //Act
            int actual = TestList.Capacity;
            
            //Assert
            Assert.AreEqual(actual, ExpectedCapcity);
        }
        [TestMethod] 
        public void CapacityDoublesWhenReached()
        {
            //Arrange 

            CustomList<int> TestList = new CustomList<int>();
            int ExpectedCapcity = 8;
            int actual;


            //Act

            TestList.Add(0);
            TestList.Add(0);
            TestList.Add(0);
            TestList.Add(0);
            actual = TestList.Capacity;

            //Assert
            Assert.AreEqual(actual, ExpectedCapcity);


        }

        // what if i .Add to a list that has a couple things in it already (position of item)?
        // what if i .Add to a list that has a couple things in it already (value of Count)?
        // how does the Capacity change as you add things? (starts at 4, and doubles)

        // REMOVE TESTS:
    }
}
