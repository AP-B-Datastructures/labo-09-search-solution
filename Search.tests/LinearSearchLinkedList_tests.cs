using System;
using Search.library;
using Search.library.SinglyLinkedList;

namespace Search.tests
{
    [TestClass]
    public class LinearSearchLinkedList_tests
    {
        [TestMethod]
        public void LinearSearch_TargetExistsInArray_ShouldReturnCorrectIndex()
        {
            // Arrange
            ListInt list = new ListInt(); 
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            int target = 30;

            // Act
            int result = LinearSearchInt.SearchLinkedList(list, target);

            // Assert
            Assert.AreEqual(2, result, "The index of the target value should be correct.");
        }

        [TestMethod]
        public void LinearSearch_TargetDoesNotExistInArray_ShouldReturnNegativeOne()
        {
            // Arrange
            ListInt list = new ListInt(); 
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            int target = 60;

            // Act
            int result = LinearSearchInt.SearchLinkedList(list, target);

            // Assert
            Assert.AreEqual(-1, result, "The function should return -1 if the target value is not found.");
        }

        [TestMethod]
        public void LinearSearch_TargetIsAtTheBeginning_ShouldReturnZero()
        {
            // Arrange
            ListInt list = new ListInt(); 
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            int target = 10;

            // Act
            int result = LinearSearchInt.SearchLinkedList(list, target);

            // Assert
            Assert.AreEqual(0, result, "The index of the first element should be 0.");
        }

        [TestMethod]
        public void LinearSearch_TargetIsAtTheEnd_ShouldReturnLastIndex()
        {
            // Arrange
            ListInt list = new ListInt();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            int target = 50;

            // Act
            int result = LinearSearchInt.SearchLinkedList(list, target);

            // Assert
            Assert.AreEqual(4, result, "The index of the last element should be returned.");
        }

        [TestMethod]
        public void LinearSearch_ArrayHasDuplicateTargets_ShouldReturnFirstIndex()
        {
            // Arrange
            ListInt list = new ListInt(); 
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(20);
            list.Add(50);
            int target = 20;

            // Act
            int result = LinearSearchInt.SearchLinkedList(list, target);

            // Assert
            Assert.AreEqual(1, result, "The index of the first occurrence of the target should be returned.");
        }

        [TestMethod]
        public void LinearSearch_ArrayIsEmpty_ShouldReturnNegativeOne()
        {
            // Arrange
            ListInt list = new ListInt();
            int target = 10;

            // Act
            int result = LinearSearchInt.SearchLinkedList(list, target);

            // Assert
            Assert.AreEqual(-1, result, "The function should return -1 if the array is empty.");
        }

        [TestMethod]
        public void LinearSearch_ArrayHasSingleElement_TargetExists_ShouldReturnZero()
        {
            // Arrange
            ListInt list = new ListInt(); 
            list.Add(10);
            int target = 10;

            // Act
            int result = LinearSearchInt.SearchLinkedList(list, target);

            // Assert
            Assert.AreEqual(0, result, "The function should return 0 if the single element matches the target.");
        }

        [TestMethod]
        public void LinearSearch_ArrayHasSingleElement_TargetDoesNotExist_ShouldReturnNegativeOne()
        {
            // Arrange
            ListInt list = new ListInt(); 
            list.Add(10);
            int target = 20;

            // Act
            int result = LinearSearchInt.SearchLinkedList(list, target);

            // Assert
            Assert.AreEqual(-1, result, "The function should return -1 if the single element does not match the target.");
        }

        [TestMethod]
        public void LinearSearch_NegativeTarget_ShouldWorkCorrectly()
        {
            // Arrange
            ListInt list = new ListInt(); 
            list.Add(-10);
            list.Add(-20);
            list.Add(-30);
            list.Add(-40);
            list.Add(-50);
            int target = -30;

            // Act
            int result = LinearSearchInt.SearchLinkedList(list, target);

            // Assert
            Assert.AreEqual(2, result, "The function should handle negative numbers correctly.");
        }

        [TestMethod]
        public void LinearSearch_MixedPositiveAndNegativeNumbers_ShouldFindTarget()
        {
            // Arrange
            ListInt list = new ListInt(); 
            list.Add(-10);
            list.Add(20);
            list.Add(-30);
            list.Add(40);
            list.Add(-50);
            int target = 40;

            // Act
            int result = LinearSearchInt.SearchLinkedList(list, target);

            // Assert
            Assert.AreEqual(3, result, "The function should find the target among mixed positive and negative numbers.");
        }
    }
}
