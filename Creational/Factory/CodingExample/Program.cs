// See https://aka.ms/new-console-template for more information
using CodingExample;
using static System.Console;
Console.WriteLine("Hello, World!");


var personfactory = new Person.PersonFactory();

WriteLine(personfactory.CreatePerson("john"));
WriteLine(personfactory.CreatePerson("paul"));