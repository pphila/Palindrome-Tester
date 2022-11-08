using System;

namespace Palindrome
{
  public class PalindromeChecker
  {
    public bool IsPalindromeString(string str)
    {
      char[] strArr = new char[str.Length];
      //breaks it into an array of letters
      for(int i = 0; i < str.Length; i++)
      {
        strArr[i] = str[i];
        Console.WriteLine(str[i]);
      }
      //smushes it back into a string
      Array.Reverse(strArr);
      var reversedString = new string (strArr);
      
      if(reversedString == str)
      {
        return true;
      }
      return false;
    }
  }
}