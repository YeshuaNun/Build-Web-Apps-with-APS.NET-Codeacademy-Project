// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

// namespace LearnReferences
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//         Diary dy1 = new Diary(5);
//         Diary dy2 = dy1;
//         dy2.Flip();
//         Console.WriteLine(dy1.CurrentPage);
//         Console.WriteLine(dy2.CurrentPage);
//     }
//   }
// }

// namespace LearnReferences
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//         Book bookLocation = new Book();
//         Book sameBookLocation = bookLocation;
//         bool falseValue = false;
//         bool anotherFalseValue = falseValue;
//     }
//   }
// }

// namespace LearnReferences
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//         Book b1 = new Book();
//         Book b2 = b1;
//         Console.WriteLine(b1==b2);
//     }
//   }
// }

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
      Dissertation diss = new Dissertation();
			IFlippable fdiss = diss;
      Book bdiss = diss;
			fdiss.CurrentPage = 42;
    //   bdiss.CurrentPage = 43;
    //   fdiss.Stringify();
      bdiss.Stringify();
      Console.WriteLine(fdiss == bdiss);
    }
  }
}