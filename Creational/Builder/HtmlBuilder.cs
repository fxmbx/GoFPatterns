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

        // public void AddChild(string childName, string childText){

        public HtmlBuilder AddChild(string childName, string childText){
            //making this method return HtmlBuilder will allow you chain it just like methods in the stringbuilder 
            var childElement = new HtmlElement(childName, childText);
            root.Elements.Add(childElement);
            return this;
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