using System;
using System.Collections.Generic;
using Palindrome;

namespace Palindrome {
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter in a palindrome: ");
      string userInput = Console.ReadLine();
      PalindromeChecker pal1 = new PalindromeChecker();

      if (pal1.IsPalindromeString(userInput))
      {
        Console.WriteLine("WOOOHOOO!!!! " + userInput + " is a palindrome!!!!!!!!!!!!");
      }
      else
      {
        Console.WriteLine("Read a palindrome dictionary!");
      }
    }
  }
}