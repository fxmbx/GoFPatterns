namespace Builder.FluentBuilder
{
    public class Person
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }

        //this class to enable a class expose it's own generic interface builder
        public class Builder : PersonJobBuilder<Builder>{}
        //this makes sure everytime the object is called it creates a new builder
        public static Builder New => new Builder();


    }

    //fluent
   
}