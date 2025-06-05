using System;
using Search.library;

namespace Search.tests
{
    [TestClass]
    public class HashtableString_NoCollisions_tests
    {

        private HashtableString_NoCollisions hashtable;

        [TestInitialize]
        public void Setup()
        {
            // Initialize a new list to simulate a string-only hashtable
            hashtable = new HashtableString_NoCollisions(10);
        }

        [TestMethod]
        public void Add_ShouldAddStringValue()
        {
            // Arrange
            string value = "Value1";

            // Act
            hashtable.Add(value);

            // Assert
            Assert.IsTrue(hashtable.Contains(value), "Value should be added to the hashtable.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Add_DuplicateValues_CollisionShouldThrowException()
        {
            // Arrange
            string value = "Value1";

            // Act
            hashtable.Add(value);
            hashtable.Add(value);
        }

        [TestMethod]
        public void Remove_ShouldRemoveStringValue()
        {
            // Arrange
            string value = "Value1";
            hashtable.Add(value);

            // Act
            hashtable.Remove(value);

            // Assert
            Assert.IsFalse(hashtable.Contains(value), "Value should be removed from the hashtable.");
        }

        [TestMethod]
        public void Remove_NonExistentValue_ShouldNotThrowError()
        {
            // Arrange
            string nonExistentValue = "NonExistent";

            // Act
            hashtable.Remove(nonExistentValue);

            // Assert
            Assert.IsTrue(true, "Removing a non-existent value should not throw an error.");
        }

        [TestMethod]
        public void Contains_ShouldReturnTrueForExistingValue()
        {
            // Arrange
            string value = "Value1";
            hashtable.Add(value);

            // Act
            bool containsValue = hashtable.Contains(value);

            // Assert
            Assert.IsTrue(containsValue, "Hashtable should contain the added value.");
        }

        [TestMethod]
        public void Contains_ShouldReturnFalseForNonExistentValue()
        {
            // Arrange
            string value = "NonExistent";

            // Act
            bool containsValue = hashtable.Contains(value);

            // Assert
            Assert.IsFalse(containsValue, "Hashtable should not contain a value that was not added.");
        }

        [TestMethod]
        public void Length_ShouldReturnCorrectNumberOfItems()
        {
            // Arrange
            hashtable.Add("Value1");
            hashtable.Add("Value2");

            // Act
            int length = hashtable.Length;

            // Assert
            Assert.AreEqual(2, length);
        }

        [TestMethod]
        public void Clear_ShouldRemoveAllValues()
        {
            // Arrange
            hashtable.Add("Value1");
            hashtable.Add("Value2");

            // Act
            hashtable.Clear();

            // Assert
            Assert.AreEqual(0, hashtable.Length, "Hashtable should be empty after clearing.");
        }
    }
}
