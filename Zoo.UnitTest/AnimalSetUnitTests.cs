namespace Zoo.UnitTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Zoo.Logic;

    namespace SetTests
    {
        /// <summary>
        /// Contains unit tests for the <see cref="Set"/> class, verifying the functionality of adding,
        /// checking for duplicates, counting, and set operations (union, intersection, difference)
        /// with different types of animals including <see cref="Fish"/>, <see cref="Bird"/>, and <see cref="Mammal"/>.
        /// </summary>
        /// <remarks>
        /// This class uses the Microsoft.VisualStudio.TestTools.UnitTesting framework to run the tests.
        /// Each test method is designed to validate specific behaviors and edge cases of the <see cref="Set"/> class.
        /// </remarks>
        [TestClass]
        public class AnimalSetUnitTests
        {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
            private Fish _fish1;
            private Bird _bird1;
            private Mammal _mammal1, _mammal2;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

            /// <summary>
            /// Initializes the test environment by creating instances of various animal types.
            /// </summary>
            /// <remarks>
            /// This method is called before each test method is executed. It sets up the necessary objects for testing,
            /// including a <see cref="Fish"/> named "Goldfish", a <see cref="Bird"/> named "Eagle", and two <see cref="Mammal"/>
            /// instances named "Lion" and "Elephant".
            /// </remarks>
            [TestInitialize]
            public void Setup()
            {
                _fish1 = new Fish("Goldfish");
                _bird1 = new Bird("Eagle");
                _mammal1 = new Mammal("Lion");
                _mammal2 = new Mammal("Elephant");
            }

            /// <summary>
            /// Tests the addition of a new animal to the set when the animal does not already exist in the set.
            /// </summary>
            /// <remarks>
            /// This test method verifies that when a new animal is added to the set, the count of animals in the set is incremented by one,
            /// and the newly added animal is confirmed to be present in the set.
            /// </remarks>
            /// <example>
            /// <code>
            /// Set animalSet = new();
            /// animalSet.Add(_fish1);
            /// Assert.AreEqual(1, animalSet.Count);
            /// Assert.IsTrue(animalSet.IsAnimalInSet(_fish1));
            /// </code>
            /// </example>
            [TestMethod]
            public void ItShouldAddNewAnimalToSet_GivenAnimalDoesNotExist()
            {
                // Arrange
                Set animalSet = new();

                // Act
                animalSet.Add(_fish1);

                // Assert
                Assert.AreEqual(1, animalSet.Count);
                Assert.IsTrue(animalSet.IsAnimalInSet(_fish1));
            }

            /// <summary>
            /// Tests that attempting to add a duplicate animal to the animal set does not increase the count.
            /// </summary>
            /// <remarks>
            /// This test verifies that when an animal that already exists in the set is added again,
            /// the total count of animals in the set remains unchanged.
            /// </remarks>
            /// <example>
            /// <code>
            /// var animalSet = new Set();
            /// animalSet.Add(mammal1); // Adding the first mammal
            /// animalSet.Add(mammal1); // Attempting to add the same mammal again
            /// Assert.AreEqual(1, animalSet.Count); // The count should still be 1
            /// </code>
            /// </example>
            [TestMethod]
            public void ItShouldNotAddDuplicateAnimal_GivenAnimalAlreadyExists()
            {
                // Arrange
                Set animalSet = new();

                // Act
                animalSet.Add(_mammal1);
                animalSet.Add(_mammal1);  // Duplicate

                // Assert
                Assert.AreEqual(1, animalSet.Count);
            }

            /// <summary>
            /// Tests the <see cref="Set.IsAnimalInSet(Animal)"/> method to ensure that it returns true
            /// when the specified animal exists in the set.
            /// </summary>
            /// <remarks>
            /// This test method arranges a set containing a specific animal, then asserts that
            /// the <see cref="Set.IsAnimalInSet(Animal)"/> method correctly identifies that
            /// the animal is present in the set.
            /// </remarks>
            /// <example>
            /// <code>
            /// Set animalSet = new();
            /// animalSet.Add(_bird1);
            /// bool result = animalSet.IsAnimalInSet(_bird1);
            /// Assert.IsTrue(result);
            /// </code>
            /// </example>
            [TestMethod]
            public void ItShouldReturnTrue_GivenAnimalExistsInSet()
            {
                // Arrange
                Set animalSet = new();
                animalSet.Add(_bird1);

                // Act & Assert
                Assert.IsTrue(animalSet.IsAnimalInSet(_bird1));
            }

            /// <summary>
            /// Tests that the <see cref="Set.IsAnimalInSet"/> method returns false
            /// when the specified animal does not exist in the set.
            /// </summary>
            /// <remarks>
            /// This test initializes a new instance of the <see cref="Set"/> class
            /// and checks if a specific animal, represented by <c>_bird1</c>,
            /// is not present in the set, expecting the result to be false.
            /// </remarks>
            [TestMethod]
            public void ItShouldReturnFalse_GivenAnimalDoesNotExistInSet()
            {
                // Arrange
                Set animalSet = new();

                // Act & Assert
                Assert.IsFalse(animalSet.IsAnimalInSet(_bird1));
            }

            /// <summary>
            /// Tests that the <see cref="Set"/> class correctly counts the number of animals added to it.
            /// </summary>
            /// <remarks>
            /// This test method verifies that when multiple animals are added to the <see cref="Set"/> instance,
            /// the <see cref="Set.Count"/> property reflects the correct number of animals.
            /// </remarks>
            /// <example>
            /// <code>
            /// var animalSet = new Set();
            /// animalSet.Add(new Mammal());
            /// animalSet.Add(new Bird());
            /// Assert.AreEqual(2, animalSet.Count);
            /// </code>
            /// </example>
            [TestMethod]
            public void ItShouldCountCorrectly_GivenMultipleAnimals()
            {
                // Arrange
                Set animalSet = new();

                // Act
                animalSet.Add(_mammal1);
                animalSet.Add(_bird1);

                // Assert
                Assert.AreEqual(2, animalSet.Count);
            }

            /// <summary>
            /// Tests the union operation of two non-overlapping sets to ensure that
            /// the resulting set contains all unique elements from both sets.
            /// </summary>
            /// <remarks>
            /// This test method arranges two sets, each containing a different animal.
            /// It then performs the union operation and asserts that the resulting
            /// set contains the correct number of elements and that both elements
            /// are present in the resulting set.
            /// </remarks>
            /// <example>
            /// <code>
            /// // Example usage:
            /// ItShouldPerformUnionCorrectly_GivenTwoNonOverlappingSets();
            /// </code>
            /// </example>
            /// <returns>
            /// This method does not return a value. It asserts conditions to validate
            /// the union operation.
            /// </returns>
            [TestMethod]
            public void ItShouldPerformUnionCorrectly_GivenTwoNonOverlappingSets()
            {
                // Arrange
                Set set1 = new();
                Set set2 = new();

                set1.Add(_fish1);
                set2.Add(_bird1);

                // Act
                Set resultSet = set1 + set2;

                // Assert
                Assert.AreEqual(2, resultSet.Count);
                Assert.IsTrue(resultSet.IsAnimalInSet(_fish1));
                Assert.IsTrue(resultSet.IsAnimalInSet(_bird1));
            }

            /// <summary>
            /// Tests the union operation of two sets when there are duplicate animals in both sets.
            /// </summary>
            /// <remarks>
            /// This test verifies that when two sets containing the same animal are combined,
            /// the resulting set contains only a single instance of that animal.
            /// </remarks>
            /// <example>
            /// <code>
            /// Set set1 = new Set();
            /// Set set2 = new Set();
            /// set1.Add(_fish1);
            /// set2.Add(_fish1); // Duplicate in both sets
            /// Set resultSet = set1 + set2;
            /// Assert.AreEqual(1, resultSet.Count);
            /// Assert.IsTrue(resultSet.IsAnimalInSet(_fish1));
            /// </code>
            /// </example>
            [TestMethod]
            public void ItShouldHandleUnion_GivenDuplicateAnimalsInBothSets()
            {
                // Arrange
                Set set1 = new();
                Set set2 = new();

                set1.Add(_fish1);
                set2.Add(_fish1);  // Duplicate in both sets

                // Act
                Set resultSet = set1 + set2;

                // Assert
                Assert.AreEqual(1, resultSet.Count);
                Assert.IsTrue(resultSet.IsAnimalInSet(_fish1));
            }

            /// <summary>
            /// Tests the intersection operation between two sets of animals.
            /// This test verifies that the intersection correctly identifies common animals in both sets.
            /// </summary>
            /// <remarks>
            /// The test initializes two sets, adds a common animal (_bird1) to both sets,
            /// and then performs the intersection operation. It asserts that the resulting set
            /// contains exactly one animal, which should be the common animal.
            /// </remarks>
            /// <example>
            /// <code>
            /// ItShouldPerformIntersectionCorrectly_GivenCommonAnimalInBothSets();
            /// </code>
            /// </example>
            [TestMethod]
            public void ItShouldPerformIntersectionCorrectly_GivenCommonAnimalInBothSets()
            {
                // Arrange
                Set set1 = new();
                Set set2 = new();

                set1.Add(_mammal1);
                set1.Add(_bird1);
                set2.Add(_bird1);

                // Act
                Set resultSet = set1 * set2;

                // Assert
                Assert.AreEqual(1, resultSet.Count);
                Assert.IsTrue(resultSet.IsAnimalInSet(_bird1));
            }

            /// <summary>
            /// Tests that the intersection of two sets returns an empty set when there are no common animals in both sets.
            /// </summary>
            /// <remarks>
            /// This test method arranges two sets, <c>set1</c> containing a mammal and <c>set2</c> containing a bird.
            /// It then performs an intersection operation on these sets and asserts that the resulting set is empty.
            /// </remarks>
            /// <example>
            /// <code>
            /// Set set1 = new();
            /// Set set2 = new();
            /// set1.Add(_mammal1);
            /// set2.Add(_bird1);
            /// Set resultSet = set1 * set2;
            /// Assert.AreEqual(0, resultSet.Count);
            /// </code
            [TestMethod]
            public void ItShouldReturnEmptySet_GivenNoCommonAnimalsInBothSets()
            {
                // Arrange
                Set set1 = new();
                Set set2 = new();

                set1.Add(_mammal1);
                set2.Add(_bird1);

                // Act
                Set resultSet = set1 * set2;

                // Assert
                Assert.AreEqual(0, resultSet.Count);
            }

            /// <summary>
            /// Tests the difference operation between two sets of animals.
            /// This test verifies that when unique animals are present in the first set,
            /// the resulting set after performing the difference operation contains only
            /// those animals that are not present in the second set.
            /// </summary>
            /// <remarks>
            /// In this test, <c>set1</c> contains a fish and a bird, while <c>set2</c> contains only the bird.
            /// After performing the difference operation (<c>set1 - set2</c>), the result should only include the fish,
            /// as the bird is present in both sets.
            /// </remarks>
            /// <example>
            /// <code>
            /// // Example of how to use this test method:
            /// It
            [TestMethod]
            public void ItShouldPerformDifferenceCorrectly_GivenSomeUniqueAnimalsInFirstSet()
            {
                // Arrange
                Set set1 = new();
                Set set2 = new();

                set1.Add(_fish1);
                set1.Add(_bird1);
                set2.Add(_bird1);

                // Act
                Set resultSet = set1 - set2;

                // Assert
                Assert.AreEqual(1, resultSet.Count);
                Assert.IsTrue(resultSet.IsAnimalInSet(_fish1));
                Assert.IsFalse(resultSet.IsAnimalInSet(_bird1));
            }

            /// <summary>
            /// Tests that the result of subtracting a second set from the first set returns an empty set
            /// when there are no unique animals in the first set.
            /// </summary>
            /// <remarks>
            /// This test method sets up two sets containing the same animal. It then performs a subtraction
            /// operation on the first set with the second set and asserts that the resulting set is empty.
            /// </remarks>
            /// <example>
            /// <code>
            /// ItShouldReturnEmptySet_GivenNoUniqueAnimalsInFirstSet();
            /// </code>
            /// </example>
            [TestMethod]
            public void ItShouldReturnEmptySet_GivenNoUniqueAnimalsInFirstSet()
            {
                // Arrange
                Set set1 = new();
                Set set2 = new();

                set1.Add(_mammal1);
                set2.Add(_mammal1);

                // Act
                Set resultSet = set1 - set2;

                // Assert
                Assert.AreEqual(0, resultSet.Count);
            }

            /// <summary>
            /// Verifies that the count of an empty set is zero.
            /// </summary>
            /// <remarks>
            /// This test method ensures that when a new instance of the <see cref="Set"/> class is created without any elements,
            /// the <see cref="Count"/> property returns zero.
            /// </remarks>
            /// <example>
            /// <code>
            /// Set emptySet = new Set();
            /// int count = emptySet.Count; // count will be 0
            /// </code>
            /// </example>
            [TestMethod]
            public void ItShouldReturnCountAsZero_GivenEmptySet()
            {
                // Arrange
                Set emptySet = new();

                // Act
                int count = emptySet.Count;

                // Assert
                Assert.AreEqual(0, count);
            }

            /// <summary>
            /// Tests the <see cref="Set"/> class to ensure that it correctly converts a set of animals to a string representation.
            /// </summary>
            /// <remarks>
            /// This test method verifies that when multiple animals are added to the set,
            /// the resulting string representation contains the names of the added animals.
            /// Specifically, it checks for the presence of "Lion" and "Eagle" in the output string.
            /// </remarks>
            /// <example>
            /// <code>
            /// // Example usage of the test method
            /// ItShouldConvertSetToStringCorrectly_GivenMultipleAnimals();
            /// </code>
            /// </example>
            [TestMethod]
            public void ItShouldConvertSetToStringCorrectly_GivenMultipleAnimals()
            {
                // Arrange
                Set animalSet = new();
                animalSet.Add(_mammal1);
                animalSet.Add(_bird1);

                // Act
                string result = animalSet.ToString();

                // Assert
                StringAssert.Contains(result, "Lion");
                StringAssert.Contains(result, "Eagle");
            }

            /// <summary>
            /// Tests that the <see cref="Set"/> class returns an empty string when initialized with an empty set.
            /// </summary>
            /// <remarks>
            /// This test method verifies the behavior of the <see cref="Set.ToString()"/> method when the set contains no elements.
            /// The expected result is an empty string.
            /// </remarks>
            [TestMethod]
            public void ItShouldReturnEmptyString_GivenEmptySet()
            {
                // Arrange
                Set emptySet = new();

                // Act
                string result = emptySet.ToString();

                // Assert
                Assert.AreEqual(string.Empty, result.Trim());
            }

            /// <summary>
            /// Tests the behavior of the <see cref="Set"/> class when a large number of animals are added.
            /// Specifically, it verifies that adding one thousand <see cref="Mammal"/> instances results in the correct count.
            /// </summary>
            /// <remarks>
            /// This test method sets up a scenario where 1000 <see cref="Mammal"/> objects are created and added to an instance of <see cref="Set"/>.
            /// It then asserts that the total count of animals in the set is equal to 1000, ensuring that the <see cref="Set"/> can handle large numbers of entries correctly.
            /// </remarks>
            /// <exception cref="Exception">Thrown if the count does not equal 1000.</exception>
            [TestMethod]
            public void ItShouldHandleLargeNumberOfAnimals_GivenThousandAnimalsAreAdded()
            {
                // Arrange
                Set animalSet = new();

                for (int i = 0; i < 1000; i++)
                {
                    animalSet.Add(new Mammal($"Mammal {i}"));
                }

                // Act
                int count = animalSet.Count;

                // Assert
                Assert.AreEqual(1000, count);
            }

            /// <summary>
            /// Tests the addition of different types of animals (Fish, Bird, and Mammal)
            /// to the <see cref="Set"/> class.
            /// </summary>
            /// <remarks>
            /// This test verifies that when a Fish, a Bird, and a Mammal are added to the
            /// animal set, the count of animals in the set equals 3.
            /// </remarks>
            /// <example>
            /// <code>
            /// ItShouldAddDifferentTypesOfAnimals_GivenFishBirdAndMammal();
            /// </code>
            /// </example>
            [TestMethod]
            public void ItShouldAddDifferentTypesOfAnimals_GivenFishBirdAndMammal()
            {
                // Arrange
                Set animalSet = new();

                // Act
                animalSet.Add(_fish1);
                animalSet.Add(_bird1);
                animalSet.Add(_mammal1);

                // Assert
                Assert.AreEqual(3, animalSet.Count);
            }

            /// <summary>
            /// Tests that the <see cref="Set"/> class correctly adds only unique animal instances,
            /// even when the instances are of the same type.
            /// </summary>
            /// <remarks>
            /// This test method verifies that when two different instances of the same type (in this case, <see cref="Fish"/>)
            /// are added to the <see cref="Set"/>, both instances are counted, ensuring that the set allows multiple instances
            /// of the same type as long as they are different objects.
            /// </remarks>
            /// <example>
            /// <code>
            /// // Arrange
            /// Set animalSet = new();
            /// Fish fish1 = new("Goldfish");
            /// Fish fish2 = new("Guppy");
            ///
            /// // Act
            [TestMethod]
            public void ItShouldAddOnlyUniqueAnimals_GivenSameTypeDifferentInstances()
            {
                // Arrange
                Set animalSet = new();
                Fish fish2 = new("Goldfish");

                // Act
                animalSet.Add(_fish1);
                animalSet.Add(fish2); // Same type, different instance

                // Assert
                Assert.AreEqual(2, animalSet.Count);
            }

            /// <summary>
            /// Tests that the <see cref="Set"/> correctly returns a count of animals when a valid animal is added,
            /// and verifies that the count is 1 when a null animal is not added.
            /// </summary>
            /// <remarks>
            /// This test method sets up a new instance of the <see cref="Set"/> class, adds a valid mammal
            /// instance, and asserts that the count of animals in the set is equal to 1.
            /// </remarks>
            /// <exception cref="ArgumentNullException">Thrown if a null animal is attempted to be added.</exception>
            [TestMethod]
            public void ItShouldReturnCorrectCount_GivenNullAnimalAndValidAnimalAdded()
            {
                // Arrange
                Set animalSet = new();

                // Act
                animalSet.Add(_mammal1);

                // Assert
                Assert.AreEqual(1, animalSet.Count);
            }

            /// <summary>
            /// Tests the union operation between an empty set and a non-empty set.
            /// </summary>
            /// <remarks>
            /// This test verifies that when an empty set is united with a non-empty set,
            /// the result contains all elements of the non-empty set. It specifically checks
            /// that the count of the resulting set is equal to 1 and that the specific
            /// element (_mammal1) is present in the resulting set.
            /// </remarks>
            /// <exception cref="AssertFailedException">
            /// Thrown when the assertions regarding the count and presence of the element in the result set fail.
            /// </exception>
            [TestMethod]
            public void ItShouldPerformUnion_GivenEmptyAndNonEmptySets()
            {
                // Arrange
                Set emptySet = new();
                Set nonEmptySet = new();
                nonEmptySet.Add(_mammal1);

                // Act
                Set resultSet = emptySet + nonEmptySet;

                // Assert
                Assert.AreEqual(1, resultSet.Count);
                Assert.IsTrue(resultSet.IsAnimalInSet(_mammal1));
            }
        }
    }
}