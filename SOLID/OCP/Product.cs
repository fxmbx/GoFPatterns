namespace SOLID.OCP
{

    public enum Color
    {
        Red, Green, Blue
    }
    public enum Size
    {
        Small, Medium, Large
    }
    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;
        public Product(string name, Color _color, Size _size)
        {
            Name = name;
            Color = _color;
            Size = _size;
        }
    }




}