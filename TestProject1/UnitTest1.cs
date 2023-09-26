using ConsoleApp5;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("a", 1)]
        [DataRow("asdfgg", 5)]
        [DataRow ("", 0)]
        [DataRow ("Q1234Werrqwertyuiop[", 12)]
        public void GetUnconsequetiveString_EmptyAndSingleString_ReturnsExpectedNumber(string s, int result)
        {
            // Arrange
            Solution solution = new Solution();

            // Act
            int actual = solution.GetUnconsequetiveString(s);

            // Assert
            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        [DataRow("aa", 2)]
        [DataRow("asdf", 1)]
        [DataRow("", 0)]
        [DataRow("aahjbbbbaghsss", 4)]
        public void MaxNumberConsecutiveLetters_EmptyAndSingleString_ReturnsExpectedNumber(string s, int result)
        {
            //Arrange
            Solution solution = new Solution();

            // Act
            int actual = solution.MaxNumberConsecutiveLetters(s);

            // Assert
            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        [DataRow("1", 1)]
        [DataRow("aasf", 0)]
        [DataRow("agsa11ags12354lkg", 2)]
        [DataRow(" 111222233333 ", 5)]
        public void TestMethod3(string s, int result)
        {
            //Arrange
            Solution solution = new Solution();

            //Act
            int actual = solution.MaxNumberConsecutiveNumbers(s);

            // Assert
            Assert.AreEqual(result, actual);
        }

    }
}