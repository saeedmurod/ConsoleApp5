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
        public void TestMethod1(string s, int result)
        {
            Solution solution = new Solution();
            int actual = solution.GetConsequetiveString(s);
            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        [DataRow("aa", 2)]
        [DataRow("asdf", 1)]
        [DataRow("", 0)]
        [DataRow("aahjbbbbaghsss", 4)]
        public void TestMethod2(string s, int result)
        {
            Solution solution = new Solution();
            int actual = solution.MaxNumberConsecutiveLetters(s);
            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        [DataRow("1", 1)]
        [DataRow("aasf", 0)]
        [DataRow("agsa11ags12354lkg", 2)]
        [DataRow(" 111222233333 ", 5)]
        public void TestMethod3(string s, int result)
        {
            Solution solution = new Solution();
            int actual = solution.MaxNumberConsecutiveNumbers(s);
            Assert.AreEqual(result, actual);
        }
    }
}