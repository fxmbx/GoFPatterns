namespace SOLID.DIP
{

    //this interface will help use access low-level module from high
    public interface IRelationshipBrowser
    {
         IEnumerable<Person> FindAllChildren(string name);
    }
}