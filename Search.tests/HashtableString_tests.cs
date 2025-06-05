using System;
using Search.library;

namespace Search.tests
{
    [TestClass]
    public class HashtableString_tests
    {

        private HashtableString hashtable;

        [TestInitialize]
        public void Setup()
        {
            // Initialize a new list to simulate a string-only hashtable
            hashtable = new HashtableString(10);
        }

        [TestMethod]
        public void Add_ShouldAddStringValue()
        {
            // Arrange
            string value = "Value1";

            // Act
            hashtable.Add(value);

            // Assert
            Assert.IsTrue(hashtable.Contains(value));
        }

        [TestMethod]
        public void Add_DuplicateValues_CollisionShouldNotThrowException()
        {
            // Arrange
            string value = "Value1";

            // Act
            hashtable.Add(value);
            hashtable.Add(value);

            //Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Add_DuplicateValues_CountShouldReturnNumberOfInstances()
        {
            // Arrange
            string value = "Value1";

            // Act
            hashtable.Add(value);
            hashtable.Add(value);

            //Assert
            Assert.AreEqual(2, hashtable.Count(value));
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
            Assert.IsFalse(hashtable.Contains(value));
        }

        [TestMethod]
        public void Remove_NonExistentValue_ShouldNotThrowError()
        {
            // Arrange
            string nonExistentValue = "NonExistent";

            // Act
            hashtable.Remove(nonExistentValue);

            // Assert
            Assert.IsTrue(true);
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
            Assert.IsTrue(containsValue);
        }

        [TestMethod]
        public void Contains_ShouldReturnFalseForNonExistentValue()
        {
            // Arrange
            string value = "NonExistent";

            // Act
            bool containsValue = hashtable.Contains(value);

            // Assert
            Assert.IsFalse(containsValue);
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
            Assert.AreEqual(0, hashtable.Length);
        }
    }
}
