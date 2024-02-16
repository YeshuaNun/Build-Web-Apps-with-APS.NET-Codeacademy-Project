// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

// namespace AlternateExpressions
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Welcome("Earth");
//       double days = 500;
//       double rotations = DaysToRotations(days);
//       Console.WriteLine($"In {days} days, the Earth has rotated {rotations} time(s).");
//     } 
    
//     static double DaysToRotations(double days) => days / 365;
    
//     static void Welcome(string planet) => Console.WriteLine($"Welcome to {planet}!");
//   }
// }

namespace AlternateExpressions
{
  class Program
  {
  	// Method to be used as second argument
   	public static bool IsLong(string word)
    {
      return word.Length > 8;
    }
      
    static void Main(string[] args)
    {
      // Array to be used as first argument
      string[] adjectives = {"rocky", "mountainous", "cosmic", "extraterrestrial"};
     
      // Call Array.Find() and 
      // Pass in the array and method as arguments
      string firstLongAdjective = Array.Find(adjectives, IsLong);
      
      Console.WriteLine($"The first long word is: {firstLongAdjective}.");
    }
  }
}