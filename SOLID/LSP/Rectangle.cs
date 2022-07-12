namespace SOLID.LSP
{
    public class Rectangle
    { 
        //virtual allows derived class override or use base 
        public virtual int Width {get;set;}
        public virtual int Height { get; set; }
        public Rectangle()
        {
            
        }
        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}, {2} : {3}", nameof(Width), Width, nameof(Height), Height);
        }


    }
}