# Lesson: References

The focus of this lesson is on references. The lesson covers the following topics:
- How references work in C#
- Why references are useful
- How to upcast a reference
- How to create a null reference

# Lesson: Reference Fundamentals

There was a lot covered in this lesson. During the course of this lesson I leanrt that:
- **Classes** and **interfaces** are reference types. A variable of this type holds a reference to the data, not the data itself. This is different from value types like int and bool
- The equality operator (==) uses a referential comparison for reference types and a value comparison for value types
- Multiple references can be created for a single object
- A reference and its corresponding object do not have to be the same type. For example, we can refer to a subclass object by an inherited superclass or implemented interface reference
- The functionality available to an object reference is determined by the reference’s type, not the object’s type
- **Polymorphism** is the ability in programming to present the same interface for differing data types
- Referencing an object by an inherited type or implemented interface is called upcasting. It can be done implicitly
- Referencing an object by a derived class is called downcasting, which must be made explicit by adding the type name in parentheses. It may cause an InvalidCastException error when the code is run
- To signify that a reference is “empty” or refers to no object, we set it equal to null
- If a reference is not set to any value it is unassigned and cannot perform any operations

# Lesson: The Object Class

This lesson focused on extending the understanding of objects in C#. It covered the following concepts:
- Every type, eventually, inherits from Object
- Object members include **Equals()**, **ToString()**, and **GetType()**
- The **ToString()** method allows **Console.WriteLine()** to work for all types

This link provides information on the Object Class and its specific methods:
https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-8.0

# Lesson: String, The Exception

