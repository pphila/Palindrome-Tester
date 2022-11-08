using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeCheckerTests
  {
    [TestMethod]
    public void IsPalindromeString_True()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      PalindromeChecker testPalindromeChecker = new PalindromeChecker();
      Assert.AreEqual(true, testPalindromeChecker.IsPalindromeString("tacocat"));
    }

    [TestMethod]
    public void IsAPalindrome_False()
    {
      PalindromeChecker testPalindromeChecker = new PalindromeChecker();
      Assert.AreEqual(false, testPalindromeChecker.IsPalindromeString("cars"));
    }
  }
}