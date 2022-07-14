
namespace Builder.FluentBuilder
{

    //this is allowing a situation where SELF only refers to the object inheriting from this object 
    //e.g Foo : Bar<FOO> 
    //the type castin/conditioning done here is to avoid unwanted return types to be passed as generic parameters
    public class PersonInfoBuilder<SELF> : PersonBuilder where SELF : PersonInfoBuilder<SELF>
    {
        // protected Person person = new Person();
        public SELF Called(string name){
            person.Name = name;
            return (SELF) this;
        }

    
    }
}