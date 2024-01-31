[TestClass]
public class StringShufflerTests
{
    [TestMethod]
    public void ShuffleStrings_ShouldNotChangeOriginalList()
    {
        // Arrange
        var originalList = new List<string> { "A", "B", "C", "D" };
        var shuffler = new StringShuffler();

        // Act
        var shuffledList = shuffler.ShuffleStrings(originalList);

        // Assert
        CollectionAssert.AreNotEqual(originalList, shuffledList);
    }

    [TestMethod]
    public void ShuffleStrings_ShouldContainSameElements()
    {
        // Arrange
        var originalList = new List<string> { "A", "B", "C", "D" };
        var shuffler = new StringShuffler();

        // Act
        var shuffledList = shuffler.ShuffleStrings(originalList);

        // Assert
        CollectionAssert.AreEquivalent(originalList, shuffledList);
    }

    [TestMethod]
    public void ShuffleStrings_ShouldBeRandom()
    {
        // Arrange
        var originalList = new List<string> { "A", "B", "C", "D" };
        var shuffler = new StringShuffler();

        // Act
        var shuffle1 = shuffler.ShuffleStrings(originalList);
        var shuffle2 = shuffler.ShuffleStrings(originalList);

        // Assert
        CollectionAssert.AreNotEqual(shuffle1, shuffle2);
    }
}
