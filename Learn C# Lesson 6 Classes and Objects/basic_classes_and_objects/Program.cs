// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Reflection;

// namespace BasicClasses
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//         Forest f = new Forest();
//         f.name = "Sherwood";
//         f.biome = "Oak";
//         f.trees = 300;
//         f.age = 800;
//         Console.WriteLine(f.name);
//     }
//   }
// }

// namespace BasicClasses
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Forest f = new Forest();
//       f.Name = "Congo";
//       f.Trees = 0;
//       f.age = 0;
//       f.biome = "Tropical";
      
//       Console.WriteLine(f.Name);
//     }
//   }
// }

// namespace BasicClasses
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Forest f = new Forest();
//       f.Name = "Congo";
//       f.Trees = 0;
//       f.age = 0;
//       f.biome = "Tropical";
      
//       Console.WriteLine(f.Name);
//     }
//   }
// }

// namespace BasicClasses
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Forest f = new Forest();
//       f.Name = "Congo";
//       f.Trees = 0;
//       f.age = 0;
//       f.Biome = "Desert";
      
//       Console.WriteLine(f.Name);
//       Console.WriteLine(f.Biome);
//     }
//   }
// }

// namespace BasicClasses
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Forest f = new Forest();
//       f.Name = "Congo";
//       f.Trees = 0;
//       f.age = 0;
//       f.Biome = "Desert";
//       f.Age = 400;
      
//       Console.WriteLine(f.Name);
//       Console.WriteLine(f.Biome);
//     }
//   }
// }

// namespace BasicClasses
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Forest f = new Forest();
//       f.Name = "Congo";
//       f.Trees = 0;
//       f.Biome = "Desert";
      
//       Console.WriteLine(f.Name);
//       Console.WriteLine(f.Biome);
//     }
//   }
// }

// namespace BasicClasses
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
      
//       Forest f = new Forest("Congo", "Desert");
//       f.Trees = 0;
      
//       Console.WriteLine(f.Name);
//       Console.WriteLine(f.Biome);
      
//     }
//   }
// }

// namespace BasicClasses
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Forest f = new Forest("Congo", "Tropical");
//       f.Trees = 0;
      
//       Console.WriteLine(f.Name);
//       Console.WriteLine(f.Biome);
//     }
//   }
// }

// namespace BasicClasses
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Forest f = new Forest("Congo", "Tropical");
//       f.Trees = 0;
      
//       Console.WriteLine(f.Name);
//       Console.WriteLine(f.Biome);
      
//       Forest g = new Forest("Rendlesham");
//       Console.WriteLine(g.Biome);
//     }
//   }
// }

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
        Forest f = new Forest("Amazon");
        Console.WriteLine(f.Trees);
        f.Grow();
        Console.WriteLine(f.Trees);
    }
  }
}
        // // FieldsClass fieldsInst = new FieldsClass();
        // // Get the type of FieldsClass.
        // Type fieldsType = typeof(Forest);

        // // Get an array of FieldInfo objects.
        // FieldInfo[] fields = fieldsType.GetFields(BindingFlags.Public
        //     | BindingFlags.Instance);
        // // Display the values of the fields.
        // Console.WriteLine("Displaying the values of the fields of {0}:",
        //     fieldsType);
        // for(int i = 0; i < fields.Length; i++)
        // {
        //     Console.WriteLine("   {0}:\t'{1}'",
        //         fields[i].Name, fields[i].GetValue(f));
        // }     