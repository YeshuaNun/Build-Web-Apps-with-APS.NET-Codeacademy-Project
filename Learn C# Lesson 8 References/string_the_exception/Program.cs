// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

// namespace StringTheException
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//         string a = "immutable";
//         string b = "immutable";
//         Console.WriteLine(a==b);
//         Object c = new Object();
//         Object d = new Object();
//         Console.WriteLine(c==d);
//     }
//   }
// }

// namespace StringTheException
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Please type some text");
//         string a = Console.ReadLine();
//         string message = (String.IsNullOrEmpty(a)) ? "You didn't enter anything!" : "Thank you for your submission!";
//         Console.WriteLine(message);
//     }
//   }
// }

// namespace StringTheException
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       string lyrics = 
//         "Dollie, Dollie, bo-bollie,\n" +
//         "Banana-fana fo-follie\n" +
//         "Fee-fi-mo-mollie\n" +
//         "Dollie!";
      
//       // Call `Replace()` here
//       lyrics = lyrics.Replace("ollie", "ana");
      
//       Console.WriteLine(lyrics);
//     }
//   }
// }

namespace StringTheException
{
  class Program
  {
    static void Main(string[] args)
    {
      // Example 1
      string dog = "chihuahua";
      string tinyDog = dog;
      dog = "dalmation";
      Console.WriteLine(dog);
      // Output: "dalmation"
      Console.WriteLine(tinyDog);
      // Output: "chihuahua"

      // Example 2
      string s1 = "Hello ";
      string s2 = s1;
      s1 += "World";
      System.Console.WriteLine(s1);
      // Output: "Hello World"
      System.Console.WriteLine(s2);
      // Output: "Hello"
    }
  }
}