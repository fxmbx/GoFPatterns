### Builder Patterns

Motivation Behind this patterns
--having an object with 10 constructor argument is not productive
--utilized on objects that require a lot of argument
--allows Piecewise construction
--Builder provides an API for contructing an object step-by-step

## Fluent Interfaces

Fluent Interface: A fluent interface is the one that allows you chain several calls by returning the object youre working with.This can be seen in HtmlBuilder class
\*\*public HtmlBuilder AddChild(string childName, string ){//code body}

## Recursive Generics

makes it possible for you to fluently inherit from different classes having diff types
where the class object being passed is inheriting from the base

class PersonInforBuilder<SELF> : PersonJobBuilder where SELF : PersonInfoBuilder{ public SELF Called(){return (SELF) this}}
class PersonJobBuilder<SELF> : PersonInforBuilder where SELF : PersonJobBuilder{ public SELF WorksAs(){return (SELF) this}}

now we can have
p = new PersonJobBuilder()
p.Called().WorkAs();

## Functional Builders

enhance the Builder Pattern to be better in a more functional way. the implementation follows the openclosed principle of open for extension but closed for modification

## Facade Builder

basically using different builders to build up different parts of an object
