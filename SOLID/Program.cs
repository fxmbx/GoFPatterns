// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using SOLID.S;

// Console.WriteLine("Hello, World!");


var j = new Journal();
j.AddEntry("I wasted time with a mish video today");
j.AddEntry("I started design patterns today");
j.AddEntry("Single-Responsibility Principle creates a seperation of concern, making one class have only one job");


var filename =  "/Users/aurora/Funbi_Node_Tut/DesignPatterns/SOLID/journal.txt";
var p = new Persistence();
p.SaveToFIle(j, filename, true);
// Process.Start(filename);

// Console.WriteLine(j); 