using System;

// namespace BasicClasses
// {
//     class Forest {
//         public string name;
//         public string biome;
//         public int trees;
//         public int age;
//     }
// }

// namespace BasicClasses
// {
//   class Forest
//   {
//     public string name;
//     public int trees;
//     public int age;
//     public string biome;
//     public string Name
//     {
//         get {return name;}
//         set {name = value;}
//     }
//     public int Trees
//     {
//         get {return trees;}
//         set {trees = value;}
//     }
//     public string Biome
//     {
//         get {return biome;}
//         set {
//             if (value=="Tropical"||value=="Temperate"||value=="Boreal") {
//                 biome = value;
//             } else {
//                 biome = "Unknown";
//             }
//         }
//     }
//   }
// }

// namespace BasicClasses
// {
//   class Forest
//   {
//     public int age;
//     public string biome;
    
//     public string Name
//     { get; set;
//     }
    
//     public int Trees
//     { get; set;
//     }
    
//     public string Biome
//     {
//       get { return biome; }
//       set
//       {
//         if (value == "Tropical" ||
//             value == "Temperate" ||
//             value == "Boreal")
//         {
//           biome = value;
//         }
//         else
//         {
//           biome = "Unknown";
//         }
//       }
//     }
//   }

// }

// namespace BasicClasses
// {
//   class Forest
//   {
//     public int age;
//     string biome;
    
//     public string Name
//     { get; set; }
    
//     public int Trees
//     { get; set; }
    
//     public string Biome
//     {
//       get { return biome; }
//       set
//       {
//         if (value == "Tropical" ||
//             value == "Temperate" ||
//             value == "Boreal")
//         {
//           biome = value;
//         }
//         else
//         {
//           biome = "Unknown";
//         }
//       }
//     }
//   }

// }

// namespace BasicClasses
// {
//   class Forest
//   {
//     public int age;
//     private string biome;
    
//     public string Name
//     { get; set; }
    
//     public int Trees
//     { get; set; }
    
//     public string Biome
//     {
//       get { return biome; }
//       set
//       {
//         if (value == "Tropical" ||
//             value == "Temperate" ||
//             value == "Boreal")
//         {
//           biome = value;
//         }
//         else
//         {
//           biome = "Unknown";
//         }
//       }
//     }
//     public int Age
//     {
//         get; private set;
//     }
    
    
//   }

// }

// namespace BasicClasses
// {
//   class Forest
//   {
//     public int age;
//     private string biome;
    
//     public string Name
//     { get; set; }
    
//     public int Trees
//     { get; set; }
    
//     public string Biome
//     {
//       get { return biome; }
//       set
//       {
//         if (value == "Tropical" ||
//             value == "Temperate" ||
//             value == "Boreal")
//         {
//           biome = value;
//         }
//         else
//         {
//           biome = "Unknown";
//         }
//       }
//     }
    
//     public int Age
//     { 
//       get { return age; }
//       private set { age = value; }
//     }

//     public int Grow()
//     {
//         Trees+=30;
//         Age++;
//         return Trees;
//     }

//     public int Burn()
//     {
//         Trees-=20;
//         Age++;
//         return Trees;
//     }
    
//   }

// }

// namespace BasicClasses
// {
//   class Forest
//   {
//     public int age;
//     private string biome;
    
//     public string Name
//     { get; set; }
    
//     public int Trees
//     { get; set; }
    
//     public string Biome
//     {
//       get { return biome; }
//       set
//       {
//         if (value == "Tropical" ||
//             value == "Temperate" ||
//             value == "Boreal")
//         {
//           biome = value;
//         }
//         else
//         {
//           biome = "Unknown";
//         }
//       }
//     }
    
//     public int Age
//     { 
//       get { return age; }
//       private set { age = value; }
//     }
     
//     public int Grow()
//     {
//       Trees += 30;
//       Age += 1;
//       return Trees;
//     }
    
//     public int Burn()
//     {
//       Trees -= 20;
//       Age += 1;
//       return Trees;
//     }

//     public Forest(string name, string biome)
//     {
//         Name = name;
//         Biome = biome;
//         Age = 0;
//     }
    
//   }

// }

// namespace BasicClasses
// {
//   class Forest
//   {
//     public int age;
//     private string biome;
    
//     public Forest(string name, string biome)
//     {
//       this.Name = name;
//       this.Biome = biome;
//       Age = 0;
//     }
    
//     public string Name
//     { get; set; }
    
//     public int Trees
//     { get; set; }
    
//     public string Biome
//     {
//       get { return biome; }
//       set
//       {
//         if (value == "Tropical" ||
//             value == "Temperate" ||
//             value == "Boreal")
//         {
//           biome = value;
//         }
//         else
//         {
//           biome = "Unknown";
//         }
//       }
//     }
    
//     public int Age
//     { 
//       get { return age; }
//       private set { age = value; }
//     }
     
//     public int Grow()
//     {
//       Trees += 30;
//       Age += 1;
//       return Trees;
//     }
    
//     public int Burn()
//     {
//       Trees -= 20;
//       Age += 1;
//       return Trees;
//     }
    
//   }

// }

// namespace BasicClasses
// {
//   class Forest
//   {
//     public int age;
//     private string biome;
    
//     public Forest(string name, string biome)
//     {
//       this.Name = name;
//       this.Biome = biome;
//       Age = 0;
//     }

//     public Forest(string name) : this(name, "Unknown")
//     {
//         Console.WriteLine("Default value of 'Unknown' has been set.");
//     }
    
//     public string Name
//     { get; set; }
    
//     public int Trees
//     { get; set; }
    
//     public string Biome
//     {
//       get { return biome; }
//       set
//       {
//         if (value == "Tropical" ||
//             value == "Temperate" ||
//             value == "Boreal")
//         {
//           biome = value;
//         }
//         else
//         {
//           biome = "Unknown";
//         }
//       }
//     }
    
//     public int Age
//     { 
//       get { return age; }
//       private set { age = value; }
//     }
     
//     public int Grow()
//     {
//       Trees += 30;
//       Age += 1;
//       return Trees;
//     }
    
//     public int Burn()
//     {
//       Trees -= 20;
//       Age += 1;
//       return Trees;
//     }
    
//   }

// }

namespace BasicClasses
{
  class Forest
  {
    public int age;
    private string biome;
    
    public Forest(string name, string biome)
    {
      this.Name = name;
      this.Biome = biome;
      Age = 0;
    }
    
    public Forest(string name) : this(name, "Unknown")
    { }
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    public int Age
    { 
      get { return age; }
      private set { age = value; }
    }
     
    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }
    
    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }
    
  }

}