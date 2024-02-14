// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace PasswordChecker
{
  public class Tools
  {
    public Tools()
    {
    }

    public static bool Contains(string target, string list)
    {
      return target.IndexOfAny(list.ToCharArray()) != -1;
    }

    public static void ContainsTest()
    {
      string loudWord = "LASDAD";
      string quietWord = "pssst";
      string mixedWord = "lkaAWEkasfkEW";

      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";

      Console.WriteLine("Running \"tests...\"");
      Console.WriteLine($"Should be true: {Contains(loudWord, uppercase)}");
      Console.WriteLine($"Should be false: {Contains(loudWord, lowercase)}");
      Console.WriteLine($"Should be false: {Contains(quietWord, uppercase)}");
      Console.WriteLine($"Should be true: {Contains(quietWord, lowercase)}");
      Console.WriteLine($"Should be true: {Contains(mixedWord, uppercase)}");
      Console.WriteLine($"Should be true: {Contains(mixedWord, lowercase)}");
    }
  }  
  class Program
  {
    public static void Main(string[] args)
    {
        int minLength = 8;
        string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowercase = "abcdefghijklmnopqrstuvwxyz";
        string digits = "1234567890";
        string specialChars = "!\"£$%^&*(){}[]:@~;'#<>?,./-=_+";
        Console.WriteLine("Enter a password: ");
        string password = Console.ReadLine();
        int score = 0;
        int passwordLen = password.Length;
        if (passwordLen>=minLength) {
            score++;
        }
        if (Tools.Contains(password, uppercase)) {
            score++;
        }
        if (Tools.Contains(password, lowercase)) {
            score++;
        }
        if (Tools.Contains(password, digits)) {
            score++;
        }
        if (Tools.Contains(password, specialChars)) {
            score++;
        }
        
        switch (score) {
            case >=4:
            Console.WriteLine("password is extremely strong");
            break;
            case 3:
            Console.WriteLine("password is strong");
            break;
            case 2:
            Console.WriteLine("password is medium");
            break;
            case 1:
            Console.WriteLine("password is weak");
            break;
            default:
            Console.WriteLine("the password doesn't meet any of the standards");
            break;
        }
    }
  }
}