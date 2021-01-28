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
            actual = testList[0];

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
            actual = testList.Count;

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
            actual = testList[0];
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


        }                       //MethodBeingTested_WhatWeAreDoingInsideThatMethod_WhatWeExpectTheResultToBe
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
            int expected = 30;
            int actual;

            //Act
            TestList.Add(23); //index 0
            TestList.Add(10); //index 1
            TestList.Add(duplicateItem1); //index 3
            TestList.Add(30); //index 4
            TestList.Add(duplicateItem1);
            TestList.Remove(duplicateItem1);
            actual = TestList[3];

            //Assert
            Assert.AreEqual(actual, expected);

        }
        //MethodBeingTested_WhatWeAreDoingInsideThatMethod_WhatWeExpectTheResultToBe
        [TestMethod]
        public void Remove_RemoveFirstItem_HasItemTwoReplacedItemOne()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 0;
            int actual;

            //Act
            customList.Add(1);         //index 0
            customList.Add(expected); //index 1
            customList.Add(3);       //index 2
            customList.Remove(1);
            customList.Add(expected);
            actual = customList[0];

            //Assert
            Assert.AreEqual(actual, expected);

        }
        //MethodBeingTested_WhatWeAreDoingInsideThatMethod_WhatWeExpectTheResultToBe
        [TestMethod]
        public void Remove_RemoveNonexsistentItem_CountStaysTheSame()
        {//Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 3;
            int actual;

            //Act
            customList.Add(100); //index 0
            customList.Add(200); //index 1
            customList.Add(300); //index 2
            customList.Remove(400); //index 3
            actual = customList.Count;

            //Assert
            Assert.AreEqual(actual, expected);
        }
        //MethodBeingTested_WhatWeAreDoingInsideThatMethod_WhatWeExpectTheResultToBe
        [TestMethod]
        public void Remove_RemoveNonexsistentItem_ValuesStaysTheSame()
        {//Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected1 = 100;
            int expected2 = 200;
            int expected3 = 300;
            int actual1;
            int actual2;
            int actual3;

            //Act
            customList.Add(100); //index 0
            customList.Add(200); //index 1
            customList.Add(300); //index 2
            customList.Remove(400); //index 3
            actual1 = customList[0];
            actual2 = customList[1];
            actual3 = customList[2];

            //Assert
            Assert.AreEqual(actual1, expected1);
            Assert.AreEqual(actual2, expected2);
            Assert.AreEqual(actual3, expected3);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }


        //MethodBeingTested_WhatWeAreDoingInsideThatMethod_WhatWeExpectTheResultToBe
        [TestMethod]
        public void Remove_RemoveNonexsistentString_CountStaysTheSame()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();

            string expected = ("400");
            int actual;

            //Act
            customList.Add("100"); //index 0
            customList.Add("200"); //index 1
            customList.Add("300"); //index 2
            customList.Remove("400"); //index 3
            actual = customList.Count;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        //MethodBeingTested_WhatWeAreDoingInsideThatMethod_WhatWeExpectTheResultToBe

        [TestMethod]
        public void Add_AddFourStrings_CapacityDoublesWhenReached()
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
            TestList.Add(4);
            actual = TestList.Capacity;

            //Assert
            Assert.AreEqual(actual, ExpectedCapcity);

        }
    }
}
