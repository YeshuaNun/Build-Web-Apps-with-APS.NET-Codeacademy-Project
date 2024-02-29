// namespace TheObjectClass
// {
//   class Book
//   {
//     public string Author
//     { get; private set; }
    
//     public string Title
//     { get; private set; }

//     public Book(string author = "Unknown", string title = "Untitled")
//     {
//       Author = author;
//       Title = title;
//     }

//     public virtual string Stringify()
//     {
//       return "This is a Book object!";
//     }
//   }
// }

// namespace TheObjectClass
// {
//   class Book
//   {
//     public string Author
//     { get; private set; }
    
//     public string Title
//     { get; private set; }

//     public Book(string author = "Unknown", string title = "Untitled")
//     {
//       Author = author;
//       Title = title;
//     }

//     public virtual string Stringify()
//     {
//       return "This is a Book object!";
//     }

//     public override string ToString()
//     {
//         return $"This book is called {Title} and is written by {Author}.";
//     }
//   }
// }

namespace TheObjectClass
{
  class Book
  {
    public string Author
    { get; private set; }
    
    public string Title
    { get; private set; }

    public Book(string author = "Unknown", string title = "Untitled")
    {
      Author = author;
      Title = title;
    }

    public virtual string Stringify()
    {
      return "This is a Book object!";
    }
  	
    public override string ToString()
    {
      return $"This Book is {Title}, by {Author}.";
    }
  }
}