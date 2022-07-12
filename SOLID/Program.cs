// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using SOLID.OCP;
using SOLID.SRP;

// Console.WriteLine("Hello, World!");

/* SINGLE-RESPONSIBILITY


var j = new Journal();
j.AddEntry("I wasted time with a mish video today");
j.AddEntry("I started design patterns today");
j.AddEntry("Single-Responsibility Principle creates a seperation of concern, making one class have only one job");


var filename =  "/Users/aurora/Funbi_Node_Tut/DesignPatterns/SOLID/journal.txt";
var p = new Persistence();
// Process.Start(filename);

// Console.WriteLine(j); 

*/




/* OPEN-CLOSED */
var apple = new Product("Apple", Color.Green, Size.Small);
var tree = new Product("Tree", Color.Green, Size.Medium);
var bag = new Product("Hermes", Color.Red, Size.Large);
var house = new Product("House", Color.Blue, Size.Large);


Product[] products = {apple, tree, bag, house};

var pf = new ProductFilter();
System.Console.WriteLine("Grenn products (old)");
foreach( var p in pf.FilterByColor(products, Color.Green)){
    Console.WriteLine($" - {p.Name} is green");
}




System.Console.WriteLine("Green products (New way following Open-Closed)");
var bf = new BetterFilter();
foreach(var p in bf.Filter(products, new ColorSpecification(Color.Green))){
    Console.WriteLine($" - {p.Name} is green");

}
System.Console.WriteLine("Medium products (following Open-Closed)");
foreach(var p in bf.Filter(products, new SizeSpecification(Size.Medium))){
    Console.WriteLine($" - {p.Name} is medium");

}

    Console.WriteLine("Large blue Items");
    foreach(var p in bf.Filter(products, new ANDSpecification<Product>( new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large)))){
    Console.WriteLine($" - {p.Name} is Blue and Large");
    }

