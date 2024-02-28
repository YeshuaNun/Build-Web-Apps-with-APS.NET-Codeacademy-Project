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

// namespace LearnReferences
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Dissertation diss = new Dissertation();
// 			IFlippable fdiss = diss;
//       Book bdiss = diss;
// 			fdiss.CurrentPage = 42;
//     //   bdiss.CurrentPage = 43;
//     //   fdiss.Stringify();
//       bdiss.Stringify();
//       Console.WriteLine(fdiss == bdiss);
//     }
//   }
// }

// namespace LearnReferences
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Dissertation diss1 = new Dissertation(32, "Anna Knowles-Smith", "Refugees and Theatre");
// 	  Dissertation diss2 = new Dissertation(19, "Lajos Kossuth", "Shiny Happy People");
// 	  Diary dy1 = new Diary(48, "Anne Frank", "The Diary of a Young Girl");
// 	  Diary dy2 = new Diary(23, "Lili Elbe", "Man into Woman");
//       Book[] books = {diss1, diss2, dy1, dy2};
//       foreach (Book book in books) {
//         Console.WriteLine(book.Title);
//       }      
//     }
//   }
// }

// namespace LearnReferences
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Book b1 = new Book();
//       Book b2 = new Diary();
//       Console.WriteLine(b1.Stringify());
//       Console.WriteLine(b2.Stringify());      
//     }
//   }
// }

// namespace LearnReferences
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
// 			Dissertation diss = new Dissertation();
//       Diary dy = new Diary();
      
//       Book bdiss = diss;
//       Book bdy = dy;
//     }
//   }
// }

// namespace LearnReferences
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Book bk = null;
//       Console.WriteLine(bk);
//       Console.WriteLine(bk==null);
//     }
//   }
// }

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
      // Two references to the same object
      Dissertation diss1 = new Dissertation();
      Dissertation diss2 = diss1;
      diss1.CurrentPage = 31;
      diss1.Flip();
      Console.WriteLine(diss1.CurrentPage);
      Console.WriteLine(diss2.CurrentPage);
      // Both print 32

      // Referential equality when comparing reference types
      Dissertation d1 = new Dissertation(50);
      Dissertation d2 = new Dissertation(50);
      Console.WriteLine(d1 == d2);
      // Prints false

      // Value equality when comparing value types
      int int1 = 6;
      int int2 = 6;
      Console.WriteLine(int1 == int2);
      // Prints true

      // Reference to object with implemented interface
      Dissertation diss = new Dissertation(50);
      IFlippable f = diss;
      diss.Flip();
      f.Flip();
      Console.WriteLine(diss.Define());
      // This causes an error!
      // Console.WriteLine(f.Define());

      // Reference to object with inherited superclass
      Dissertation diss3 = new Dissertation(19, "Lajos Kossuth", "Shiny Happy People");
      Book bdiss3 = diss3;
      Console.WriteLine(diss3.Author);
      Console.WriteLine(bdiss3.Author);
      Console.WriteLine(diss3.Define());
      // This causes an error!
      // bdiss3.Define();

      // Arrays of references
      IFlippable[] flippers = new IFlippable[] {new Dissertation(), new Diary()};
      foreach (IFlippable flipper in flippers)
      {
        flipper.Flip();
      }
      
      // Same reference type but different behavior (using virtual/override)
      Book bdiss = new Dissertation();
      Book bk = new Book();
      Console.WriteLine(bdiss.Stringify());
      Console.WriteLine(bk.Stringify());
      // Output:
      // "This is a Dissertation object!"
      // "This is a Book object!"
      
      // Null reference
      Diary dy = null;
      // Unassigned reference
      Diary dy2;
      // Unassigned references in array
      Diary[] dys = new Diary[5];
    }
  }
}