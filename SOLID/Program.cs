// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using SOLID.LSP;
using SOLID.OCP;
using SOLID.SRP;
using SOLID.DIP;

// Console.WriteLine("Hello, World!");

/* SINGLE-RESPONSIBILITY

var j = new Journal();
j.AddEntry("I wasted time with a mish video today");
j.AddEntry("I started design patterns today");
j.AddEntry("Single-Responsibility Principle creates a seperation of concern, making one class have only one job");


var filename =  "/Users/aurora/Funbi_Node_Tut/DesignPatterns/SOLID/journal.txt";
var p = new Persistence();

*/




/* OPEN-CLOSED 

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

*/




/*LISKOV SUBSTITUITION PRINCIPLE

static int Area(Rectangle r)=> r.Width *r.Height;
var rc = new Rectangle(10,20);
Console.WriteLine("{0} has Area : {1}",rc, Area(rc));


Rectangle sq = new Square();
sq.Width =4;
Console.WriteLine("{0} has Area : {1}",sq, Area(sq));

*/


/*DEPENDENCY INVERSION */
// class Research {
    // public Research(Relationships relationships)
    // {
    //     var relations = relationships.Relations;
    //     foreach (var item in relations.Where(x=>x.Item1.Name == "John" && x.Item2 == Relationship.Parent))
    //     {
    //         System.Console.WriteLine("John has a child called{0}", item.Item3.Name);
    //     }
    // }

    // static void Main(string[] args){ 
        // var parent = new Person {Name="John snow"};
        // var child1 = new Person {Name="Mary snow"};
        // var child2 = new Person {Name="Johnathan snow"};


        // var relationships = new Relationships();
        // relationships.AddParentAndChild(parent, child1);
        // relationships.AddParentAndChild(parent, child2);

        // new Research(relationships);

    // }
// }