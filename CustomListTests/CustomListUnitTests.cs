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
        #region AddMethodTests
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


        }   //MethodBeingTested_WhatWeAreDoingInsideThatMethod_WhatWeExpectTheResultToBe
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
        #endregion
        #region RemoveMethodTests
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
        #endregion
        #region ToStringMethods
        [TestMethod]
        public void ToString_OneItemInList_ReturnsStringOfOneItem()
        {
            //Arrange 
            CustomList<int> TestList = new CustomList<int>();
            string ExpectedResult = "1";
            string actual;

            //Act
            TestList.Add(1);
            actual = TestList.ToString();

            //Assert
            Assert.AreEqual(actual, ExpectedResult);

        }

        [TestMethod]
        public void ToString_MultipleItemsInList_ReturnsStringOfAllItems()
        {
            //Arrange 
            CustomList<int> TestList = new CustomList<int>();
            string ExpectedResult = "123";
            string actual;

            //Act
            TestList.Add(1);
            TestList.Add(2);
            TestList.Add(3);
            actual = TestList.ToString();

            //Assert
            Assert.AreEqual(actual, ExpectedResult);

        }

        [TestMethod]
        public void ToString_EmptyList_ReturnsEmptyString()
        {
            //Arrange 
            CustomList<int> TestList = new CustomList<int>();
            string ExpectedResults = "";
            string actual;

            //Act
            
            
            actual = TestList.ToString();

            //Assert
            Assert.AreEqual(actual, ExpectedResults);

        }
        [TestMethod]
        public void ToString_MultipleStringItemsInList_ReturnsStringOfAllItems()
        {
            //Arrange 
            CustomList<string> TestList = new CustomList<string>();
            string ExpectedResult = "123";
            string actual;

            //Act
            TestList.Add("1");
            TestList.Add("2");
            TestList.Add("3");
            actual = TestList.ToString();

            //Assert
            Assert.AreEqual(actual, ExpectedResult);

        }
        #endregion ToStringMethods
        #region OperatorMethodTests
        [TestMethod]
        public void AddOperator_ListsWithContent_CountEqualsSumOfBothLists()
        {
            //Arrange 
            CustomList<int> FirstList = new CustomList<int>();
            CustomList<int> SecondList = new CustomList<int>();
            int ExpectedCount = 5;
            int actual;

            //Act
            FirstList.Add(1);
            FirstList.Add(2);
            FirstList.Add(3);
            SecondList.Add(4);
            SecondList.Add(4);
            var resultlist = FirstList + SecondList;
            actual = resultlist.Count;

            //Assert
            Assert.AreEqual(actual, ExpectedCount);

        }
        [TestMethod]
        public void AddOperator_ListsWithContent_ListOrderHasBeenRetained()
        {
            //Arrange 
            CustomList<int> FirstList = new CustomList<int>();
            CustomList<int> SecondList = new CustomList<int>();
            int Expected = 3;
            int actual;

            //Act
            FirstList.Add(1);
            FirstList.Add(2);
            FirstList.Add(3);
            SecondList.Add(4);
            SecondList.Add(4);
            var resultlist = FirstList + SecondList;
            actual = resultlist[2];

            //Assert
            Assert.AreEqual(actual, Expected);

        }

        [TestMethod]
        public void AddOperator_ListsWithContent_OriginalListsUnchanged()
        {
            //Arrange 
            CustomList<int> FirstList = new CustomList<int>();
            CustomList<int> SecondList = new CustomList<int>();
           

            //Act
            FirstList.Add(1);
            FirstList.Add(2);
            FirstList.Add(3);
            SecondList.Add(4);
            SecondList.Add(4);
            var resultlist = FirstList + SecondList;
           

            //Assert
            Assert.AreEqual(FirstList[0], 1);
            Assert.AreEqual(FirstList[1], 2);
            Assert.AreEqual(FirstList[2], 3);
            Assert.AreEqual(SecondList[1], 4);
            Assert.AreEqual(SecondList[0], 4);
        }

        [TestMethod]
        public void AddOperator_AddEmptyList_ResultsIsListWithContents()
        {
            //Arrange 
            CustomList<int> FirstList = new CustomList<int>();
            CustomList<int> SecondList = new CustomList<int>();
           

            //Act
            FirstList.Add(1);
            FirstList.Add(2);
            FirstList.Add(3);
            var resultlist = FirstList + SecondList;
            
            //Assert
            Assert.AreEqual(FirstList[0], resultlist[0]);
            Assert.AreEqual(FirstList[1], resultlist[1]);
            Assert.AreEqual(FirstList[2], resultlist[2]);
        }

        [TestMethod]
        public void AddOperator_AddEmptyLists_ResultsIsEmptyList()
        {
            //Arrange 
            CustomList<int> FirstList = new CustomList<int>();
            CustomList<int> SecondList = new CustomList<int>();
            int Expected = 0;
            int actual;


            //Act
            var resultlist = FirstList + SecondList;
            actual = resultlist.Count;

            //Assert
            Assert.AreEqual(actual, Expected);
        }
        [TestMethod]
        public void SubtractOperator_ListsWithContent_CountUpdatedToRemovedItems()
        {
            //Arrange 
            CustomList<int> FirstList = new CustomList<int>();
            CustomList<int> SecondList = new CustomList<int>();
            int ExpectedCount = 2;
            int actual;

            //Act
            FirstList.Add(1);
            FirstList.Add(2);
            FirstList.Add(3);
            SecondList.Add(3);
            SecondList.Add(4);
            var resultlist = FirstList - SecondList;
            actual = resultlist.Count;

            //Assert
            Assert.AreEqual(actual, ExpectedCount);

        }
        [TestMethod]
        public void SubtractOperator_ListsWithContent_ListOrderHasBeenRetained()
        {
            //Arrange 
            CustomList<int> FirstList = new CustomList<int>();
            CustomList<int> SecondList = new CustomList<int>();
            int Expected = 2;
            int actual;

            //Act
            FirstList.Add(1);
            FirstList.Add(2);
            FirstList.Add(3);
            SecondList.Add(3);
            SecondList.Add(4);
            var resultlist = FirstList - SecondList;
            actual = resultlist[1];

            //Assert
            Assert.AreEqual(actual, Expected);

        }

        [TestMethod]
        public void SubtractOperator_ListsWithContent_OriginalListsUnchanged()
        {
            //Arrange 
            CustomList<int> FirstList = new CustomList<int>();
            CustomList<int> SecondList = new CustomList<int>();


            //Act
            FirstList.Add(1);
            FirstList.Add(2);
            FirstList.Add(3);
            SecondList.Add(3);
            SecondList.Add(4);
            var resultlist = FirstList - SecondList;


            //Assert
            Assert.AreEqual(FirstList[0], 1);
            Assert.AreEqual(FirstList[1], 2);
            Assert.AreEqual(FirstList[2], 3);
            Assert.AreEqual(SecondList[1], 4);
            Assert.AreEqual(SecondList[0], 3);
        }

        [TestMethod]
        public void SubtractOperator_SubtractEmptyList_ResultsIsUnchanged()
        {
            //Arrange 
            CustomList<int> FirstList = new CustomList<int>();
            CustomList<int> SecondList = new CustomList<int>();


            //Act
            FirstList.Add(1);
            FirstList.Add(2);
            FirstList.Add(3);
            var resultlist = FirstList - SecondList;

            //Assert
            Assert.AreEqual(FirstList[0], resultlist[0]);
            Assert.AreEqual(FirstList[1], resultlist[1]);
            Assert.AreEqual(FirstList[2], resultlist[2]);
        }
        
        [TestMethod]
        public void SubtractOperator_SubtractEmptyLists_ResultsIsEmptyList()
        {
            //Arrange 
            CustomList<int> FirstList = new CustomList<int>();
            CustomList<int> SecondList = new CustomList<int>();
            int Expected = 0;
            int actual;


            //Act
            var resultlist = FirstList - SecondList;
            actual = resultlist.Count;

            //Assert
            Assert.AreEqual(actual, Expected);
        }

        [TestMethod]
        public void SubtractOperator_ListsWithDuplicates_OnlyFirstItemIsRemoved()
        {
            //Arrange 
            CustomList<int> FirstList = new CustomList<int>();
            CustomList<int> SecondList = new CustomList<int>();
            int Expected = 2;
            int actual;

            //Act
            FirstList.Add(1);
            FirstList.Add(3);
            FirstList.Add(3);
            SecondList.Add(3);
            SecondList.Add(4);
            var resultlist = FirstList - SecondList;
            actual = resultlist.Count;

            //Assert
            Assert.AreEqual(actual, Expected);

        }
        #endregion
        #region ZipMethodTests
        [TestMethod]
        public void Zip_ListsWithContent_CountEqualsSumOfBothLists()
        {
            //Arrange 
            CustomList<int> FirstList = new CustomList<int>();
            CustomList<int> SecondList = new CustomList<int>();
            int ExpectedCount = 5;
            int actual;

            //Act
            FirstList.Add(1);
            FirstList.Add(2);
            FirstList.Add(3);
            SecondList.Add(4);
            SecondList.Add(4);
            FirstList.Zip(SecondList);
            actual = FirstList.Count;

            //Assert
            Assert.AreEqual(actual, ExpectedCount);

        }

        [TestMethod]
        public void Zip_ListsWithContent_ItemsAlternateBetweenLists()
        {
            //Arrange 
            CustomList<int> FirstList = new CustomList<int>();
            CustomList<int> SecondList = new CustomList<int>();
            

            //Act
            FirstList.Add(1);
            FirstList.Add(2);
            FirstList.Add(3);
            SecondList.Add(4);
            SecondList.Add(4);
            FirstList.Zip(SecondList);
            

            //Assert
            Assert.AreEqual(FirstList[0], 1);
            Assert.AreEqual(FirstList[1], 4);
            Assert.AreEqual(FirstList[2], 2); 
            Assert.AreEqual(FirstList[3], 4); 
            Assert.AreEqual(FirstList[4], 3);
            


        }
        [TestMethod]
        public void Zip_ListsWithContent_CountEqualsSumOfBothLists()
        {
            //Arrange 
            CustomList<int> FirstList = new CustomList<int>();
            CustomList<int> SecondList = new CustomList<int>();
            int ExpectedCount = 5;
            int actual;

            //Act
            FirstList.Add(1);
            FirstList.Add(2);
            FirstList.Add(3);
            SecondList.Add(4);
            SecondList.Add(4);
            FirstList.Zip(SecondList);
            actual = FirstList.Count;

            //Assert
            Assert.AreEqual(actual, ExpectedCount);

        }
        [TestMethod]
        public void Zip_OneEmptyList_ResultIsFirstList()
        {
            //Arrange 
            CustomList<int> FirstList = new CustomList<int>();
            CustomList<int> SecondList = new CustomList<int>();
           

            //Act
            FirstList.Add(1);
            FirstList.Add(2);
            FirstList.Add(3);
            FirstList.Zip(SecondList);


            //Assert
            Assert.AreEqual(FirstList[0], 1);
            Assert.AreEqual(FirstList[1], 2);
            Assert.AreEqual(FirstList[2], 3);

        }
        [TestMethod]
        public void Zip_TwoEmptyList_ResultIsEmptyList()
        {
            //Arrange 
            CustomList<int> FirstList = new CustomList<int>();
            CustomList<int> SecondList = new CustomList<int>();
            int Expected = 0;
            int actual;

            //Act
            FirstList.Zip(SecondList);
            actual = FirstList.Count;

            //Assert
            Assert.AreEqual(Expected, actual);
        }
        #endregion
        #region IterationTests
        [TestMethod]
        public void Iteration_IterateOverItems_IteratesNumberOfTimesEqualToCount()
        {
            //Arrange 
            CustomList<int> TestList = new CustomList<int>();
            int Expected = 0;

            //Act
            TestList.Add(1);
            TestList.Add(2);
            TestList.Add(3);
            foreach (var item in TestList)
            {
                Expected++; 
            }

            //Assert
            Assert.AreEqual(Expected, TestList.Count);

        }
        [TestMethod]
        public void Iteration_IterateOverItems_IteratingCanSucsessfullyCopyList()
        {
            //Arrange 
            CustomList<int> TestList = new CustomList<int>();
            CustomList<int> CopyList = new CustomList<int>();
            

            //Act
            TestList.Add(1);
            TestList.Add(2);
            TestList.Add(3);
            foreach (var item in TestList)
            {
                CopyList.Add(item);
            }

            //Assert
            Assert.AreEqual(TestList[0], CopyList[0]);
            Assert.AreEqual(TestList[1], CopyList[1]);
            Assert.AreEqual(TestList[2], CopyList[2]);
           
        }
        #endregion

    }

}
