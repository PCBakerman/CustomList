using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListUnitTestStarter;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace CustomListTests
{
    //MethodBeingTested_WhatWeAreDoingInsideThatMethod_WhatWeExpectTheResultToBe
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
        //MethodBeingTested_WhatWeAreDoingInsideThatMethod_WhatWeExpectTheResultToBe
        [TestMethod]
        public void Add_AddTwoItem_IndexZeroRemainsUnchanged()
        {
            CustomList<int> testList = new CustomList<int>();
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
        //MethodBeingTested_WhatWeAreDoingInsideThatMethod_WhatWeExpectTheResultToBe
        [TestMethod]
        public void Add_AddSeveralItems_CountEqualsNumbersOfItemsAdded()
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
        //MethodBeingTested_WhatWeAreDoingInsideThatMethod_WhatWeExpectTheResultToBe
        [TestMethod]
        public void Constructor_InitalizeList_CapacityStartsAtFour()
        {   
            //Arrange 
            CustomList<int> TestList = new CustomList<int>();
            int ExpectedCapcity = 4;
            
            //Act
            int actual = TestList.Capacity;
            
            //Assert
            Assert.AreEqual(actual, ExpectedCapcity);
        }
        //MethodBeingTested_WhatWeAreDoingInsideThatMethod_WhatWeExpectTheResultToBe
        [TestMethod] 
        public void Add_AddFourItems_CapacityDoublesWhenReached()
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

            //MethodBeingTested_WhatWeAreDoingInsideThatMethod_WhatWeExpectTheResultToBe
        }
        [TestMethod]
        public void Add_AddFiveItems_FifthItemAtFourthIndex()
        {
            //Arrange 

            CustomList<int> TestList = new CustomList<int>();
            int FifthItem = 7;
            int actual;


            //Act

            TestList.Add(0);
            TestList.Add(0);
            TestList.Add(0);
            TestList.Add(0);
            TestList.Add(FifthItem);
            actual = TestList[4]; 

            //Assert
            Assert.AreEqual(actual, FifthItem);


        }
        [TestMethod]
        public void Add_AddFiveItems_ThirdItemAtSecondIndex()
        {
            //Arrange 

            CustomList<int> TestList = new CustomList<int>();
            int thirdItem = 7;
            int actual;


            //Act

            TestList.Add(0);
            TestList.Add(0);
            TestList.Add(thirdItem);
            TestList.Add(0);
            TestList.Add(0);
            actual = TestList[2];

            //Assert
            Assert.AreEqual(actual, thirdItem);


        }

    }
}
