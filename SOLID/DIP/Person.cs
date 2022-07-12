using System.ComponentModel;

namespace SOLID.DIP
{

    public enum Relationship{
        Parent,
        Child, 
        Sibling
    }
    public class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }


    public class Relationships : IRelationshipBrowser{
        private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)> (); 


        public void AddParentAndChild(Person p,Person c){
            relations.Add((p,Relationship.Parent, c));
            relations.Add((c,Relationship.Child, p));
        }

        public IEnumerable<Person> FindAllChildren(string name)
        {
            foreach (var item in relations.Where(r=>r.Item1.Name ==name && r.Item2 == Relationship.Parent))
            {
                yield return item.Item3;
            }
        }


        // public List<(Person, Relationship, Person)> Relations => relations;
    }

    public class Research{
 
        public Research(IRelationshipBrowser browser){
            foreach (var p in browser.FindAllChildren("John"))
            {
                System.Console.WriteLine("John has a child called: {0}", p.Name);
            }
        }
    }

}