### Factory Design Pattern

A component with the responsibility of wholesale creation of object

defines an interface for creating an object, but let subclasses decide which class to instantiate. The Factory method lets a class defer instantiation it uses to subclasses.

---

This defers fromBuilder because it looks at object creation wholesale while builder is step-y-step

Object creation can outsorced to something else like a function(factory function)
in enterproses cases you can have stacks/heirach of factories with and abstaract factory

# Motivation

when object creation logic becomes convoluted
and the construcotr is not a good way to describe(constructors cannot be overloaded)

# the main reason to opt for factories is because constructors arent so great

constructor overloading no de.
obviously there are walk arounds but mmh yh
asynchronous calls, async dont work on constructir

## Two types of factory patters

-Proper Factories
-Abstract Factories

# Prowh
