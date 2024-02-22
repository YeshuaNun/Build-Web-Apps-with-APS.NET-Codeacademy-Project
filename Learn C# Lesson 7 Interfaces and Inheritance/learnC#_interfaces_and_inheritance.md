# Lesson: Interfaces and Inheritance

This series of lesson begins by looking at interfaces. This is a form of contract that defines a set of methods, properties, events, and indexers that a class or struct must implement.

# Lesson: Interfaces

This lesson introduced the concept of **interfaces**. It showed how:
- Learned that interfaces are useful to guarantee certain functionality across multiple classes
- Built an interface using the interface keyword
- Defined properties and methods (but not constructors or fields) in the interface
- Built classes that implemented the interface
- Added members to the classes that weren’t specified in the interface

# Lesson: Inheritance

This lesson introduced the concept of **inheritance**. It showed how:
- Inheritance is a way to avoid duplication across multiple classes.
- In inheritance, one class inherits the members of another class.
- The class that inherits is called a subclass or derived class. The other class is called a superclass or base class.
- We can access a superclass’ members using **base**. This is very useful when calling the superclass’ constructor.
- We can restrict access to a superclass and its subclasses using **protected**.
- We can override a superclass member using **virtual** and **override**.
- We can make a member in a superclass without defining its implementation using **abstract**. This is useful if every subclass’ implementation will be different.