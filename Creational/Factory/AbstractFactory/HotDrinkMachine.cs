using static System.Console;

namespace Factory.AbstractFactory
{
    public interface IHotDrink {
        void Consume();
    }

    internal class Tea : IHotDrink{
        public void Consume(){
            WriteLine($"This tea is hmmmm muah 🤌😘✨");
        }
    }

    internal class Coffea : IHotDrink {
          public void Consume(){
            WriteLine($"Ah coffea yi dun gan o");
        }
    }
    

    public interface IHotDrinkFactory {
        IHotDrink Prepare(int amount);
    }

    internal class TeaFactory : IHotDrinkFactory {
        public IHotDrink Prepare(int amount) {
            WriteLine($"Put in a tea bag, boil {amount} of water, pour and enjoy");
            return new Tea();
        }
    }

    internal class CoffeaFactory : IHotDrinkFactory {
        public IHotDrink Prepare(int amount) {
            WriteLine($"two teaspoonful of coffer , add {amount} of water and no sugar");
            return new Coffea();

        }
    }

    public class HotDrinkMachine
    {
        //this approach goes against OCP 
        // public enum AvailableDrink { Coffea, Tea}

        // private Dictionary<AvailableDrink, IHotDrinkFactory> factories = new Dictionary<AvailableDrink, IHotDrinkFactory>();
        //  public HotDrinkMachine()
        //  {
        //      foreach(AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
        //      {
        //          var factory =  (IHotDrinkFactory)Activator.CreateInstance(
        //              Type.GetType("Factory.AbstractFactory."+Enum.GetName(typeof(AvailableDrink), drink) + "Factory")
        //          );
        //          factories.Add(drink, factory);
        //      }
        //  }

        //  public IHotDrink MakeDrink(AvailableDrink drink, int amount){
        //      return factories[drink].Prepare(amount);
        //  }

        private List<Tuple<string, IHotDrinkFactory>> factories = new List<Tuple<string, IHotDrinkFactory>> ();
        public HotDrinkMachine()
        {
            foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                //IsAssignableFrom is used to check is comething implemts and interface
                if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface){
                    factories.Add(Tuple.Create(t.Name.Replace("Factory", string.Empty), (IHotDrinkFactory)Activator.CreateInstance(t)));
                }
            }
        }

        public IHotDrink MakeDrink(){
            WriteLine("Available drinks");
           for(int index =0; index<factories.Count; index++){
               var tuple = factories[index];
               WriteLine($"{index}:{tuple.Item1}");
           }
           while(true){
                string s;
               if((s = Console.ReadLine()) != null && int.TryParse(s, out int i )&& i >=0 && i< factories.Count){
                   Write("Specify amount");
                   s = ReadLine();
                   if(s != null && int.TryParse(s, out int amount) && amount >0){
                       return factories[i].Item2.Prepare(amount);
                   }
               }

               WriteLine("Incorrect input, try again");
           }

        }
    }
}