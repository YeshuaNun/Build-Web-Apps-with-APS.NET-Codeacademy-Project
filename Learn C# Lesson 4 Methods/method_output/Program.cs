// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

// namespace IntroMethodOutput
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       // Call a method with multiple arguments
//       NamePets("Laika", "Albert");
//       // Call a method with named arguments
//       VisitPlanets(numberOfPlanets: 8);
//     }
    
//     // Define a method with multiple parameters
//     static void NamePets(string pet1, string pet2)
//     {
//       Console.WriteLine($"Your pets {pet1} and {pet2} will be joining your voyage across space!");
//     }  
 
//     // Define a method with optional parameters
//     static void VisitPlanets(
//       string adjective = "brave",
//       string name = "Cosmonaut", 
//       int numberOfPlanets = 0,
//       double gForce = 4.2)
//     {
//       Console.WriteLine($"Welcome back, {adjective} {name}.");
//       Console.WriteLine($"You visited {numberOfPlanets} new planets...");
//       Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
//     }
    
//   }
// }

// namespace Return
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//         Console.WriteLine(DecoratePlanet("Jupiter"));
//     }
//     static string DecoratePlanet(string planet)
//     {
//         return $"*.*.* Welcome to {planet} *.*.*";
//     }    
// 	}
// }

// namespace ReturnErrors
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Console.WriteLine(DecoratePlanet("Mars")); 
//       Console.WriteLine("Is Pluto really a dwarf...?");
//       Console.WriteLine(IsPlutoADwarf());
//       Console.WriteLine("Then how many planets are there in the galaxy...?");
//       Console.WriteLine(CountThePlanets());
//     }
    
//     static string DecoratePlanet(string planet)
//     {
//        return $"*..*..* Welcome to {planet} *..*..*";
//     }
    
//     static bool IsPlutoADwarf()
//     {
//       bool answer = true;
//       return answer;
//     }
    
//     static string CountThePlanets()
//     {
//       return "8 planets, usually";
//     }
// 	}
// }

// namespace OutParameters
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       string ageAsString = "102";
//       string nameAsString = "Granny";
//       int ageAsInt;
//       bool outcome;
//       outcome = Int32.TryParse(ageAsString, out ageAsInt);
//       Console.WriteLine(outcome);
//       Console.WriteLine(ageAsInt);
//       int nameAsInt;
//       bool outcome2;
//       outcome2 = Int32.TryParse(nameAsString, out nameAsInt);
//       Console.WriteLine(outcome2);
//       Console.WriteLine(nameAsInt);     
//     }  
// 	}
// }

// namespace UsingOut
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//         string statement = "GARRRR";
//         Console.WriteLine(Whisper(statement, out bool boolean));
//     }
//     static string Whisper(string str, out bool boolean)
//     {
//         boolean = true;
//         return str.ToLower();
//     }    
// 	}
// }

// namespace OutErrors
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       string statement = "GARRRR";
//       bool marker;
// 			string murmur = Whisper(statement, out marker);
//       Console.WriteLine(murmur);
//     }  
    
//     static string Whisper(string phrase, out bool wasWhisperCalled)
//     {
//       wasWhisperCalled = true;
//       return phrase.ToLower();
//     }
// 	} 
// }

// namespace ReviewMethodOutput
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       // Define variables
//       string destination = "Neptune";
//       string galaxyString = "8";
//       int galaxyInt;
//       string welcomeMessage;
//       bool outcome;
      
//       // Call DecoratePlanet() and TryParse() here
//       welcomeMessage = DecoratePlanet("destination");
//       outcome = Int32.TryParse(galaxyString, out galaxyInt);
//       // Print results
//       Console.WriteLine(welcomeMessage);
//       Console.WriteLine($"Parsed to int? {outcome}: {galaxyInt}");
      
//     }
    
//     // Define a method that returns a string
//   	static string DecoratePlanet(string planet)
//     {
//        return $"*..*..* Welcome to {planet} *..*..*";
//     }
    
//     // Define a method with out
//     static string Whisper(string phrase, out bool wasWhisperCalled)
//     {
//       wasWhisperCalled = true;
//       return phrase.ToLower();
//     }
// 	}
// }