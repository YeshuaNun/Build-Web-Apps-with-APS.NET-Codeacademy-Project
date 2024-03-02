# Lesson: Lists and LINQ

# Lesson: Lists
This lesson looked at lists and an alternative way to store several values within a single variable, much like arrays but with the added advantage of further more mutable functionality. The points addressed in this lesson include:
- A list, or List\<T>, is a generic, sequential data structure. The specific type that it contains is specified upon instantiation.
- Lists are effectively unlimited. They “grow” and “shrink” as the number of elements rises and falls.
- List values can be accessed by index using square brackets: [ ].
- To create an empty list, use a basic constructor. To create a list with values, use object initialization.
- Add() is used to add an element to a list.
- Remove() is used to remove an element from the list. It returns true if it is successful, false otherwise.
- Count is the number of elements in the array.
- Contains() returns true if the argument exists in the list, false otherwise.
- A sequence within a list is called a range. There are specific methods for working with ranges, including GetRange(), AddRange(), InsertRange(), and RemoveRange().
- Lists are a type of generic collection, which are defined with generic type parameters. The type parameters are specified when instantiating any generic class.
- Use lists and dictionaries in your code by including this line at the top of your file: using **System.Collections.Generic;**

The documentation for list is found here:
https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-8.0

# Lesson: LINQ
In the course of this lesson, concepts such as:
- How to import the LINQ features to C#
- How to run LINQ queries on datasets
- How to identify method and query syntax
- Basic operators, such as **Select**, **Where**, and **from**

are taught.

This lesson covered a lot of of LINQ. This is some of the core details covered:
-LINQ is a set of language and framework features for writing structured, type-safe queries over local object collections and remote data sources.
- Use LINQ by referencing the System.Linq namespace in your file.
- When a LINQ query returns a sequence of elements its type is IEnumerable<T>. That means it works with foreach loops and its length is accessible with Count().
- Store a query’s result in a variable of type var. var is an implicit type, meaning it gets all of the benefits of type-checking without our specifying the actual type.
- LINQ queries can be written in method syntax or query syntax.
- We prefer method syntax for single operations and query syntax for most everything else.
- The Where operator is used to select certain elements from a sequence.
- The Select operator determines what is returned for each element in the sequence.
- The from operator declares a range variable that is used to traverse the sequence.
- LINQ can be used on arrays and lists, among other datatypes.

Further information on LINQ can be found from Microsofts guide to LINQ:
https://learn.microsoft.com/en-us/dotnet/csharp/linq/