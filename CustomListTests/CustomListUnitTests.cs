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

            TestList.Add(1);
            TestList.Add(2);
            TestList.Add(3);
            TestList.Add(4);



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

            //MethodBeingTested_WhatWeAreDoingInsideThatMethod_WhatWeExpectTheResultToBe
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



            ////////////////////////////////////////////////////////////////////////////////////////




            //MethodBeingTested_WhatWeAreDoingInsideThatMethod_WhatWeExpectTheResultToBe
        }
        [TestMethod]
        public void Remove_RemoveOneItemFromList_CountGoesDownByOne()
        {
            //Arrange 

            CustomList<int> TestList = new CustomList<int>();
            int expected = 3;
            int actual;

            //Act

            TestList.Add(1);
            TestList.Add(2);
            TestList.Add(3);
            TestList.Add(4);
            expected = TestList.Count - 1;
            TestList.Remove(3);
            actual = TestList.Count;

            //Assert

            Assert.AreEqual(actual, expected);


            //MethodBeingTested_WhatWeAreDoingInsideThatMethod_WhatWeExpectTheResultToBe
        }
        [TestMethod]
        public void Remove_RemoveDuplicateValue_OnlyRemoveFirstValueOfDuplicate()
        {
            //Arrange 
            CustomList<int> TestList = new CustomList<int>();
            int duplicateItem1 = 3;
            int expected = 3;
            int actual;

            //Act
            TestList.Add(23);
            TestList.Add(10);
            TestList.Add(duplicateItem1);
            TestList.Add(30);
            TestList.Add(duplicateItem1);
            TestList.Remove(duplicateItem1);
            actual = TestList[3];

            //Assert
            Assert.AreEqual(actual, expected);

        }
        [TestMethod]
        public void Remove_RemoveFirstItem_HasItemTwoReplacedItemOne()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 0;
            int actual;

            //Act
            customList.Add(1); //index 0
            customList.Add(expected); //index 1
            customList.Add(3); //index 2
            customList.Remove(1);
            customList.Add(expected);
            actual = customList[0]; 


            //Assert

            Assert.AreEqual(actual, expected);

        }

    }
}
