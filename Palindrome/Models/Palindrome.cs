using System;

namespace Palindrome
{
  public class PalindromeChecker
  {
    public bool IsStringPalindrome(string str)
    {
      if(str.GetType() == typeof(string))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}