// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

// namespace PrideAndPrejudice
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       // First string variable
//       string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";
//       // Second string variable
//       string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?";
//       // Print variable and newline
//       Console.WriteLine(firstSentence);
//       Console.WriteLine();
//       Console.WriteLine(firstSpeech);      
//     }
//   }
// }

// namespace StoryTime
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       // Declare the variables
//       string beginning = "Start";
//       string middle = "Middle";
//       string end = "End";
//       // Concatenate the string and the variables
//       string story = beginning+" "+middle+" "+end;
//       // Print the story to the console
//       Console.WriteLine(story);
//     }
//   }
// }

// namespace StoryTime
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       // Declare the variables
//       string beginning = "Once upon a time,";
//       string middle = "The kid climbed a tree";
//       string end = "Everyone lived happily ever after.";
//       // Interpolate the string and the variables
//       string story = $"{beginning} {middle} {end}";
//       // Print the story to the console
//       Console.WriteLine(story);
//     }
//   }
// }

// namespace PasswordCheck
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       // Create password
//       string password = "a92301j2add";
//       // Get password length
//       int passwordLength = password.Length;
//       // Check if password uses symbol
//       int passwordCheck = password.IndexOf("!");
//       // Print results
//       Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");
//     }
//   }
// }

// namespace DNA
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       // dna strand
//       string startStrand = "ATGCGATGAGCTTAC";
//       // find location of "tga"
//       int tga = startStrand.IndexOf("TGA");
//       // start point and stop point variables
//       int startPoint = 0;
//       int length = tga+3;
//       // define final strand
//       string dna = startStrand.Substring(startPoint, length);
//       Console.WriteLine(dna);
//       // DNA mutation search
//       char forth = dna[3];
//       Console.WriteLine(forth);
//     }
//   }
// }

// namespace MovieScript
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       // Script line
//       string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";
//       // Get camera directions
//       int charPosition = script.IndexOf("Close");
//       int length = "Close on".Length;
//       string cameraDirections = script.Substring(charPosition, length);
//       // Get scene description
//       charPosition = script.IndexOf("a portrait");
//       string sceneDescription = script.Substring(charPosition);
//       // Make camera directions uppercase
//       cameraDirections = cameraDirections.ToUpper();
//       // Make scene description lowercase
//       sceneDescription = sceneDescription.ToLower();
//       // Print results
//       Console.WriteLine($"{cameraDirections} {sceneDescription}");
//     }
//   }
// }