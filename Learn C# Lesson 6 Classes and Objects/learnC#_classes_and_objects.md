# Lesson: Classes and Objects

This series of lessons looks at how classes and objects are used to represent data that looks and behaves more like information in the real world. For instance, creating on object with features such as size, colour and other properties.

# Lesson: Basic Classes and Objects

This lesson explored classes and objects and covered the following concepts:
- Define a **class**
- Instantiate an object using **new**
- Define **fields**, the pieces of data for each class
- Define **properties**, the spokespeople for each field
- Define **automatic properties**, the shorthand for making properties
- Define **methods**, the actions a class can take
- Define **constructors**, the special methods called when a class is instantiated
- Overload **constructors** and reuse code with this
- Control access to class members using **public** and **private**

# Lesson: Static Members

This lesson discussed the use of the word **static** in C#. It covered the following topics:
- In general, **static** means “associated with the class, not an instance”.
- A static member is always accessed by the class name, rather than the instance name, like Forest.Area.
- A static method cannot access non-static members.
- A static constructor is run once per type, not per instance. It is invoked before the type is instantiated or a static member is accessed.
- Either of these would trigger the static constructor of Forest:

public static void Main() {
  Forest f  = new Forest(); 
}

or

public static void Main() {
  Forest.Define(); 
}

- A static class cannot be instantiated. Its members are accessed by the class name, like Math.PI.