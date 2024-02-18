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
      Console.WriteLine("Do you need to Encrypt or Decrypt a message? ");
      string enOrDecrypt = Console.ReadLine();
      if (enOrDecrypt=="Encrypt") {
        Console.WriteLine(Encrypt(alphabet, 3));
      } else if (enOrDecrypt=="Decrypt") {
        Console.WriteLine(Decrypt(alphabet, 3));
      } else {
        Console.WriteLine("Invalid response. The program will end");
      }
    }

    static string Encrypt(char[] charArr, int key) {
      Console.WriteLine("What is the secret message?");
      string secretMessage = Console.ReadLine();
      char[] secretMessageArr = secretMessage.ToCharArray();
      int messageLength = secretMessageArr.Length;
      char[] encryptedMessageArr = new char[messageLength];
      for (int i=0; i<messageLength; i++) {
        int charArrIndex = Array.IndexOf(charArr, secretMessageArr[i]);
        if (charArrIndex!=-1) {
          charArrIndex+=key;
          if (charArrIndex>25) {
            charArrIndex-=26;
          }
          encryptedMessageArr[i]=charArr[charArrIndex];
        } else {
          encryptedMessageArr[i]=secretMessageArr[i];
        }
      }
      string encryptedMessage = string.Join("", encryptedMessageArr);
      return encryptedMessage;
    }

    static string Decrypt(char[] charArr, int key) {
      Console.WriteLine("What is the message to decrypt?");
      string codedMessage = Console.ReadLine();
      char[] codedMessageArr = codedMessage.ToCharArray();
      int messageLength = codedMessageArr.Length;
      char[] decryptedMessageArr = new char[messageLength];
      for (int i=0; i<messageLength; i++) {
        int charArrIndex = Array.IndexOf(charArr, codedMessageArr[i]);
        if (charArrIndex!=-1) {
          charArrIndex-=key;
          if (charArrIndex<0) {
            charArrIndex+=26;
          }
          decryptedMessageArr[i]=charArr[charArrIndex];
        } else {
          decryptedMessageArr[i]=codedMessageArr[i];
        }
      }
      string decryptedMessage = string.Join("", decryptedMessageArr);
      return decryptedMessage;
    }
  }
}