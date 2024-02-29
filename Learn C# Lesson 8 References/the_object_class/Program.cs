// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

// namespace TheObjectClass
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Book bk = new Book();
//       Object ok = bk;
      
//       Diary dy = new Diary(38);
//       Object oy = dy;
      
//       int i = 9;
//       Object o = i;
      
//     }
//   }
// }

// namespace TheObjectClass
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Book b = new Book();      
//       Diary d = new Diary(38);
//       Random r = new Random();
//       int i = 9;
//       Object[] arrObjects = {b, d, r, i};
//       foreach (Object obj in arrObjects) {
//         Console.WriteLine(obj.GetType());
//       }
//     }
//   }
// }

// namespace TheObjectClass
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Book bk = new Book("Ta-Nehisi Coates", "Between the World and Me");
//       Console.WriteLine(bk.ToString());
      
//     }
//   }
// }

// namespace TheObjectClass
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//         Diary d = new Diary();
//         Console.WriteLine(d);
//     }
//   }
// }

namespace TheObjectClass
{
  class Program
  {
    static void Main(string[] args)
    {
      Book bk = new Book("Ta-Nehisi Coates", "Between the World and Me");
      Diary dy = new Diary(38);
      Random rand = new Random();
      int i = 9;

      Object[] objects = {bk, dy, rand, i};

      foreach (Object obj in objects)
      {
        Console.WriteLine(obj.GetType());
        Console.WriteLine(obj);
      }

      bool b = true;
      Console.WriteLine(b);
      Console.WriteLine(b.ToString());
    }
  }
}