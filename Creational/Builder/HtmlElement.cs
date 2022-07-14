using System.Text;

namespace Builder
{
    public class HtmlElement
    {
        public string Name { get; set; }
        public string Text { get; set; }

        public List<HtmlElement> Elements = new List<HtmlElement>();
        private int indentSize = 2;

        public HtmlElement()
        {
            
        }
        public HtmlElement(string name)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
        }
        public HtmlElement(string? name, string? text)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Text = text ?? throw new ArgumentNullException(paramName: nameof(text));;
        }

        private string ToStringImplementation(int indent){
            //looking at the stringbuilder interface, the functions like Append() return the StringBuilder type this is to allow you chain methods together e.g Append("foo").Append("chi") 
            var sb = new StringBuilder();
            var indt = new string(' ', indent* indentSize);
            sb.AppendLine($"{indt}<{Name}>");
            if(!string.IsNullOrWhiteSpace(Text)){
                sb.Append(new string(' ', (indent+1)* indentSize));
                sb.AppendLine(Text);
            }

            foreach (var item in Elements)
            {
                sb.Append(item.ToStringImplementation(indent +1));
            }
            // sb.AppendLine("{0}</{1}>",indt,Name);
            sb.AppendLine($"{indt}</{Name}>");

            return sb.ToString();
        }
        public override string ToString()
        {
            return ToStringImplementation(0);
        }

    }
}