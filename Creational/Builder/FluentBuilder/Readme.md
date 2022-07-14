### Fluent Builder

A fluent interface is an object-oriented API that depends largely on method chaining. The goal of a fluent interface is to reduce code complexity, make the code readable, and create a domain specific language (DSL).

## Problem with inheritance of fluent interface is

you are not allowed to use the containing type as the return type because it make no sense
e.g if you have some like this

public PersonInfoBuilder() Called{return this}
public PersonJobBuilder WorksAs(){return this}

p = new PersonJobBuilder();
p.Called() aint gon allow you call workas directly like p.Called().WorkAs()

Instead make the retuning type generic/more sophisticated

## Recursive Generics 🤯

makes it possible for you to fluently inherit from different classes having diff types
class PersonInforBuilder<SELF> : PersonJobBuilder where SELF : PersonInfoBuilder{ public SELF Called(){return (SELF) this}}
class PersonJobBuilder<SELF> : PersonInforBuilder where SELF : PersonJobBuilder{ public SELF WorksAs(){return (SELF) this}}

now we can have
p = new PersonJobBuilder()
p.Called().WorkAs();
