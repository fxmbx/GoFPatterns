namespace Builder
{
    public class HtmlBuilder
    {
        private readonly string rootName;
        HtmlElement root = new HtmlElement();
        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = this.rootName;
        }

        public void AddChild(string childName, string childText){
            var childElement = new HtmlElement(childName, childText);
            root.Elements.Add(childElement);
        }
        public void Clear(){
            // root= new HtmlElement(name=rootName);
        }
        public override string ToString()
        {
            return root.ToString();
        }
    }
}