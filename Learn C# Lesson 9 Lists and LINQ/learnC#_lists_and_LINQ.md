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