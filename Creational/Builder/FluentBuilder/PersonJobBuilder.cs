namespace Builder.FluentBuilder
{
    //adding the recursive generic here will make it possible to inherit from here also 
    public class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>> where SELF : PersonJobBuilder<SELF>
    {
        public SELF WorksAs(string position){
            person.Position = position;
            return (SELF) this;
        }

    }
}