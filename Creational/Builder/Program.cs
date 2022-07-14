// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Threading.Tasks;
using Builder;
using Builder.FluentBuilder;

//LIFE WITHOUT BUILDERS such a mess 
//StringBuilder() is a low level builder interface. see journey just to create small list

// var hello = "hello";
// var sb = new StringBuilder();
// sb.Append("<p>");
// sb.Append(hello);
// sb.Append("</p>");

// System.Console.WriteLine(sb);

// var words = new[] {"hello", "good mroning"};
// sb.Clear();
// sb.Append("<ul>");
// foreach(var a in words){
//     sb.AppendFormat("<li>{0}</li>",a);
// }
// sb.Append("</ul>");

// System.Console.WriteLine(sb);


var builder = new HtmlBuilder("ul");
//nor fluent interface
builder.AddChild("li", "list item one").AddChild("li", "list item two");
builder.ToString();
System.Console.WriteLine(builder.ToString());


//boxed up fluent interface using recursive generics
var me =  Person.New.Called("Funbi").WorksAs("dev").Build();
// var builder1 = new PersonJobBuilder();
// builder1.Called("john").WorksAs("Carpenter");
System.Console.WriteLine(me);
