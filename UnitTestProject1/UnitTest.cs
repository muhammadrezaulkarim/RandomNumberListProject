/* Author: Muhammad Rezaul Karim
 * Date: December 07, 2017
 */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomNumberListProject;
using System.Collections;

namespace UnitTestProject
{

    [TestClass]
    public class UnitTest
    {
        int lowerLimit;
        int upperLimit;
        int totalNumbers;

        // This method will initialize the required variables (e.g. lower limit, upper limit and total numbers)
        [TestInitialize]
        public void InitializeVariablesBeforeTest()
        {
            lowerLimit = 1;
            upperLimit = 10000;
            totalNumbers = 10000; 
        }

        // This method checks whether each number in the generated list is unique and between lower and upper limit (inclusive)
        [TestMethod]
        public void TestMethodGenerateRandomListHashTableBasedUniquenessAndTotalNumberCountTest()
        {

            // generate all possible numbers between lower limit and upper limit
            int[] possibleRangeOfNumbers = new int[upperLimit-lowerLimit + 1];
            for (int num = lowerLimit, index = 0; num <= upperLimit; num++, index++)
                possibleRangeOfNumbers[index] = num;

            // run once
            int[] generatedNumbers = RandomMinMaxNumberList.GenerateRandomListHashTableBased(lowerLimit, upperLimit, totalNumbers);

            //check whether all generated numbers are unique
            CollectionAssert.AllItemsAreUnique(generatedNumbers);
            
            //check whether all generated numbers are within the lower and upper limit range
            CollectionAssert.IsSubsetOf(generatedNumbers, possibleRangeOfNumbers);

            // check whether the generated list have expected N (e.g. totalNumbers = 10000) numbers
            Assert.AreEqual(generatedNumbers.Length, totalNumbers);

            // run once again
            generatedNumbers = RandomMinMaxNumberList.GenerateRandomListHashTableBased(lowerLimit, upperLimit, totalNumbers);

            //check whether all generated numbers are unique
            CollectionAssert.AllItemsAreUnique(generatedNumbers);

            //check whether all generated numbers are within the lower and upper limit range
            CollectionAssert.IsSubsetOf(generatedNumbers, possibleRangeOfNumbers);

            // check whether the generated list have expected N (e.g. totalNumbers = 10000) numbers
            Assert.AreEqual(generatedNumbers.Length, totalNumbers);

        }

        // This method checks whether a list of N (e.g. totalNumbers = 10000) numbers is generated in random order
        [TestMethod]
        public void TestMethodGenerateRandomListHashTableBasedRandomDifferentOrderTest()
        {
            // Check whether generated list of numbers are in different order or not. Test fails if not different
            int[] numberArray1 = RandomMinMaxNumberList.GenerateRandomListHashTableBased(lowerLimit, upperLimit, totalNumbers);
            int[] numberArray2 = RandomMinMaxNumberList.GenerateRandomListHashTableBased(lowerLimit, upperLimit, totalNumbers);
            CollectionAssert.AreNotEqual(numberArray1, numberArray2);

            // Check whether generated list of numbers are in different order or not. Test fails if not different
            numberArray1 = RandomMinMaxNumberList.GenerateRandomListHashTableBased(lowerLimit, upperLimit, totalNumbers);
            numberArray2 = RandomMinMaxNumberList.GenerateRandomListHashTableBased(lowerLimit, upperLimit, totalNumbers);
            CollectionAssert.AreNotEqual(numberArray1, numberArray2);

            // Check whether generated list of numbers are in different order or not. Test fails if not different
            numberArray1 = RandomMinMaxNumberList.GenerateRandomListHashTableBased(lowerLimit, upperLimit, totalNumbers);
            numberArray2 = RandomMinMaxNumberList.GenerateRandomListHashTableBased(lowerLimit, upperLimit, totalNumbers);
            CollectionAssert.AreNotEqual(numberArray1, numberArray2);

            // Check whether generated list of numbers are in different order or not. Test fails if not different
            numberArray1 = RandomMinMaxNumberList.GenerateRandomListHashTableBased(lowerLimit, upperLimit, totalNumbers);
            numberArray2 = RandomMinMaxNumberList.GenerateRandomListHashTableBased(lowerLimit, upperLimit, totalNumbers);
            CollectionAssert.AreNotEqual(numberArray1, numberArray2);

            // Check whether generated list of numbers are in different order or not. Test fails if not different
            numberArray1 = RandomMinMaxNumberList.GenerateRandomListHashTableBased(lowerLimit, upperLimit, totalNumbers);
            numberArray2 = RandomMinMaxNumberList.GenerateRandomListHashTableBased(lowerLimit, upperLimit, totalNumbers);
            CollectionAssert.AreNotEqual(numberArray1, numberArray2);
        }
        /*
                // This method checks whether each number in the generated list is unique and between lower and upper limit (inclusive)
                [TestMethod]
                public void TestMethodGenerateRandomListArrayListBasedUniquenessAndTotalNumberCountTest()
                {
                    // generate all possible numbers between lower limit and upper limit
                    int[] possibleRangeOfNumbers = new int[upperLimit - lowerLimit + 1];
                    for (int num = lowerLimit, index = 0; num <= upperLimit; num++, index++)
                        possibleRangeOfNumbers[index] = num;

                    // run once
                    int[] generatedNumbers = RandomMinMaxNumberList.GenerateRandomListArrayListBased(lowerLimit, upperLimit, totalNumbers);

                    //check whether all generated numbers are unique
                    CollectionAssert.AllItemsAreUnique(generatedNumbers);

                    //check whether all generated numbers are within the lower and upper limit range
                    CollectionAssert.IsSubsetOf(generatedNumbers, possibleRangeOfNumbers);

                    // check whether the generated list have expected N (e.g. totalNumbers = 10000) numbers
                    Assert.AreEqual(generatedNumbers.Length, totalNumbers);

                    // run once again
                    generatedNumbers = RandomMinMaxNumberList.GenerateRandomListArrayListBased(lowerLimit, upperLimit, totalNumbers);

                    //check whether all generated numbers are unique
                    CollectionAssert.AllItemsAreUnique(generatedNumbers);

                    //check whether all generated numbers are within the lower and upper limit range
                    CollectionAssert.IsSubsetOf(generatedNumbers, possibleRangeOfNumbers);

                    // check whether the generated list have expected N (e.g. totalNumbers = 10000) numbers
                    Assert.AreEqual(generatedNumbers.Length, totalNumbers);
                }

                // This method checks whether a list of N (e.g. totalNumbers = 10000) numbers is generated in random order
                [TestMethod]
                public void TestMethodGenerateRandomListArrayListBasedRandomDifferentOrderTest()
                {
                    // Check whether generated list of numbers are in different order or not. Test fails if not different
                    int[] numberArray1 = RandomMinMaxNumberList.GenerateRandomListArrayListBased(lowerLimit, upperLimit, totalNumbers);
                    int[] numberArray2 = RandomMinMaxNumberList.GenerateRandomListArrayListBased(lowerLimit, upperLimit, totalNumbers);
                    CollectionAssert.AreNotEqual(numberArray1, numberArray2);

                    // Check whether generated list of numbers are in different order or not. Test fails if not different
                    numberArray1 = RandomMinMaxNumberList.GenerateRandomListArrayListBased(lowerLimit, upperLimit, totalNumbers);
                    numberArray2 = RandomMinMaxNumberList.GenerateRandomListArrayListBased(lowerLimit, upperLimit, totalNumbers);
                    CollectionAssert.AreNotEqual(numberArray1, numberArray2);

                    // Check whether generated list of numbers are in different order or not. Test fails if not different
                    numberArray1 = RandomMinMaxNumberList.GenerateRandomListArrayListBased(lowerLimit, upperLimit, totalNumbers);
                    numberArray2 = RandomMinMaxNumberList.GenerateRandomListArrayListBased(lowerLimit, upperLimit, totalNumbers);
                    CollectionAssert.AreNotEqual(numberArray1, numberArray2);

                    // Check whether generated list of numbers are in different order or not. Test fails if not different
                    numberArray1 = RandomMinMaxNumberList.GenerateRandomListArrayListBased(lowerLimit, upperLimit, totalNumbers);
                    numberArray2 = RandomMinMaxNumberList.GenerateRandomListArrayListBased(lowerLimit, upperLimit, totalNumbers);
                    CollectionAssert.AreNotEqual(numberArray1, numberArray2);

                    // Check whether generated list of numbers are in different order or not. Test fails if not different
                    numberArray1 = RandomMinMaxNumberList.GenerateRandomListArrayListBased(lowerLimit, upperLimit, totalNumbers);
                    numberArray2 = RandomMinMaxNumberList.GenerateRandomListArrayListBased(lowerLimit, upperLimit, totalNumbers);
                    CollectionAssert.AreNotEqual(numberArray1, numberArray2);
                } */
    }
}
