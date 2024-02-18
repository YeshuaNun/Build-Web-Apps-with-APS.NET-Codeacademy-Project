// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

// namespace BuildingArrays
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//         string[] summerStrut;
//         summerStrut = new string[] {"Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles"};
//         int[] ratings = {1, 2, 3, 4, 5};
//     }
//   }
// }

// namespace ArrayLength
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       string[] summerStrut;
//       summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito" };
//       int playlistLen = summerStrut.Length;
//       if (playlistLen==8) {
//         Console.WriteLine($"summerStrut Playlist is ready to go!");
//       } else if (playlistLen>8) {
//         Console.WriteLine("Too many songs!");
//       } else {
//         Console.WriteLine("Add some songs!");
//       }   
//     }
//   }
// }

// namespace AccessingArrays
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {     
//       string[] summerStrut;      
//       summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };      
//       int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
//       Console.WriteLine($"You rated the song {summerStrut[1]} {ratings[1]} stars.");      
//     }
//   }
// }

// namespace EditingArrays
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {     
//       string[] summerStrut;      
//       summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };      
//       int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
//       summerStrut[7]="I Like It";
//       ratings[7]=2;
//     }
//   }
// }

// namespace BuiltInMethods
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {     
//       string[] summerStrut;      
//       summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };      
//       int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
//       int threeStar = Array.IndexOf(ratings, 3)+1;
//       Console.WriteLine($"Song number {threeStar} is rated three stars.");
//       string moreThanTen = Array.Find(summerStrut, song=>song.Length>10);
//       Console.WriteLine($"The first song that has more than 10 characters in the title is {moreThanTen}.");
//       Array.Sort(summerStrut);
//       Console.WriteLine(summerStrut[0]);
//       Console.WriteLine(summerStrut[7]);
//     }
//   }
// }

// namespace DocumentationHunt
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {     
//       string[] summerStrut;      
//       summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };      
//       int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
//       string[] summerStrutCopy = new string[8];
//       Array.Copy(summerStrut, summerStrutCopy, 8);
//       Array.Reverse(summerStrut);
//       Array.Clear(ratings, 0, 7);
//       Console.WriteLine(ratings);
//     }
//   }
// }