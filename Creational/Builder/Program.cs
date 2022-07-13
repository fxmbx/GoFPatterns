// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Threading.Tasks;
using Builder;

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
builder.AddChild("li", "list item one");
builder.AddChild("li", "list item two");
builder.ToString();
System.Console.WriteLine(builder.ToString());