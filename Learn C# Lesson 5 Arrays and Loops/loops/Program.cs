// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

// namespace WhileLoop
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       int emails = 20;
//       while (emails>0) {
//         Console.WriteLine($"You have {emails} emails in your inbox.");
//         emails--;
//         Console.WriteLine($"Deleting an email. You have {emails} emails remaining.");
//       }
//       Console.WriteLine("INBOX ZERO ACHIEVED!");
//     }
//   }
// }

// namespace DoWhileLoop
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       bool buttonClick = true;
//       do {
//         Console.WriteLine("BLARRRRRRRRR");
//       } while (!buttonClick);
//       Console.WriteLine("Time for a five minute break.");
//     }
//   }
// }

// namespace ForLoop
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//         for (int i=1; i<17; i++) {
//             CreateTemplate(i);
//         }
//     }    
//     static void CreateTemplate(int week)
//     {
//       Console.WriteLine($"Week {week}");
//       Console.WriteLine("Announcements: \n \n \n ");
//       Console.WriteLine("Report Backs: \n \n \n");
//       Console.WriteLine("Discussion Items: \n \n \n");
//     }
//   }
// }

// namespace ForEachLoop
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };
//       foreach (string task in todo) {
//         CreateTodoItem(task);
//       }
//     }
    
//     static void CreateTodoItem(string item)
//     {
//       Console.WriteLine($"[] {item}");
//     }
//   }
// }

// namespace ComparingLoops
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       string[] websites = { "twitter", "facebook", "gmail" };
//     //   int counter = 0;      
//     //   while (counter < websites.Length)
//     //   { 
//     //     Console.WriteLine(websites[counter]); 
//     //     counter++; 
//     //   }
//       foreach (string website in websites) {
//         Console.WriteLine(website);
//       }
//     }
//   }
// }

namespace JumpStatements
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = false;
      int alarmSounds = 0;      
      do
      {
        if (alarmSounds==3) {
            break;
        }
        Console.WriteLine("BLARRRRR");
        alarmSounds++;        
      } while(!buttonClick);
    }
  }
}