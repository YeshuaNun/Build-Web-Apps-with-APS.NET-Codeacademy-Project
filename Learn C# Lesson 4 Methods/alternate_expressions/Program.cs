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

// namespace AlternateExpressions
// {
//   class Program
//   {
//   	// Method to be used as second argument
//    	public static bool IsLong(string word)
//     {
//       return word.Length > 8;
//     }
      
//     static void Main(string[] args)
//     {
//       // Array to be used as first argument
//       string[] adjectives = {"rocky", "mountainous", "cosmic", "extraterrestrial"};
     
//       // Call Array.Find() and 
//       // Pass in the array and method as arguments
//       string firstLongAdjective = Array.Find(adjectives, IsLong);
      
//       Console.WriteLine($"The first long word is: {firstLongAdjective}.");
//     }
//   }
// }

// namespace AlternateExpressions
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};
      
//       bool makesContact = Array.Exists(spaceRocks, (string s)=>s == "meteorite");
      
//       if (makesContact)
//       {
//         Console.WriteLine("At least one space rock has reached the Earth's surface!");
//       } 
//     } 
    
//     static bool HitGround(string s)
//     {
//       return s == "meteorite";
//     }
//   }
// }

// namespace AlternateExpressions
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};
      
//       bool makesContact = Array.Exists(spaceRocks, s => s == "meteorite");
      
//       if (makesContact)
//       {
//         Console.WriteLine("At least one space rock has reached the Earth's surface!");
//       } 
//     } 
//   }
// }

// namespace AlternateExpressions
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       int[] nums = {0, 555, 252, 3, 9, 101};
      
//       bool hasBigNum = Array.Exists(nums, IsBig);
      
//       bool hasSmallNum = Array.Exists(nums, IsSmall);
      
//       bool hasMediumNum = Array.Exists(nums, (n) => n >= 10 && n <= 100);
      
//       Console.WriteLine($"Any big #s? {hasBigNum}");
//       Console.WriteLine($"Any small #s? {hasSmallNum}");
//       Console.WriteLine($"Any medium #s? {hasMediumNum}");
      
//     }
    
//     static bool IsBig(int n) => n > 100;
    
//     static bool IsSmall(int n) => n < 10;
    
//   }
// }