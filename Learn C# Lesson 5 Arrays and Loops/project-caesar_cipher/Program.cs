// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      Console.WriteLine("What is the secret message?");
      string secretMessage = Console.ReadLine();
      char[] secretMessageArr = secretMessage.ToCharArray();
      int messageLength = secretMessageArr.Length;
      char[] encryptedMessageArr = new char[messageLength];
      for (int i=0; i<messageLength; i++) {
        int alphabetIndex = Array.IndexOf(alphabet, secretMessageArr[i]);
        if (alphabetIndex!=-1) {
          alphabetIndex+=3;
          if (alphabetIndex>25) {
            alphabetIndex-=26;
          }
          encryptedMessageArr[i]=alphabet[alphabetIndex];
        } else {
          encryptedMessageArr[i]=secretMessageArr[i];
        }
      }     
      string encryptedMessage = string.Join("", encryptedMessageArr);
      Console.WriteLine(encryptedMessage);
    }
  }
}