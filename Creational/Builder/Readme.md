### Builder Patterns

Motivation Behind this patterns
--having an object with 10 constructor argument is not productive
--utilized on objects that require a lot of argument
--allows Piecewise construction
--Builder provides an API for contructing an object step-by-step

Fluent Interface: A fluent interface is the one that allows you chain several calls by returning the object youre working with.This can be seen in HtmlBuilder class
\*\*public HtmlBuilder AddChild(string childName, string ){//code body}
