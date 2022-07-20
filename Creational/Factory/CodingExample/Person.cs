using System.Globalization;

using System.Runtime.CompilerServices;

namespace CodingExample
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // private Person(int id, string name)
        // {
        //  Id = id;
        //  Name = name;   
        // }
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Id)}:{Id}";

        }
        public class PersonFactory {
            private int id = 0;
            public Person CreatePerson(string name)
            {
                return new Person{Id = id++, Name =  name};
            }
        }
        
    }

    // [TestFixture]
    // public class TestSuite {
    //     [Test]
    //     public void Test(){
    //         var pf = new Person.PersonFactory();
    //         var p1 = pf.CreatePerson("John");
    //         Assert.That(p1.Name == "John");
    //         Assert.That(p1.Id == 0);
    //     }
    // }

}
