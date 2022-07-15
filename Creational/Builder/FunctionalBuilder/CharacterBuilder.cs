namespace Builder.FunctionalBuilder
{
    //sealed prevents other classes from inheriting from this class
    public sealed class CharacterBuilder  : FunctionalBuilderClass<Character, CharacterBuilder>
    {
    //   private readonly List<Func<Character, Character>> actions = new List<Func<Character, Character>>();

    //   private CharacterBuilder AddAction(Action<Character> action){
    //       actions.Add(c =>{
    //           action(c);
    //           return c;
    //       });
    //       return this;
    //   }

    //    public CharacterBuilder  Do(Action<Character> action) => AddAction(action); 

       public CharacterBuilder Called(string name) => Do(c=>c.Name = name);

    //    public Character Build()=>
    //        //the aggregate allows you compact a list into a single application
    //        actions.Aggregate(new Character(), (p,f)=>f(p));
       
    }

    public static class CharacterBuilderExtension
    {
        public static CharacterBuilder PlaysAs(this CharacterBuilder builder, string position)=>builder.Do(p=>p.Position = position);
        
    }

    // CharacterBuilder :FunctionalBuilder<Character, CharacterBuilder>
    // CharacterBuilder :FunctionalBuilder<ObjectClass, ObjectClassBuilder>
    public abstract class FunctionalBuilderClass<TSubjectClass, TBuilderClass> where TBuilderClass : FunctionalBuilderClass<TSubjectClass,TBuilderClass> where TSubjectClass : new() {

        private readonly List<Func<TSubjectClass, TSubjectClass>> actions = new List<Func<TSubjectClass, TSubjectClass>>();

        private TBuilderClass AddAction(Action<TSubjectClass> action) {
            actions.Add(a => {
                action(a);
                return a;
            });
            return (TBuilderClass)this;
        }

       public TBuilderClass Do(Action<TSubjectClass> action) => AddAction(action);

       public TSubjectClass Build()=> actions.Aggregate(new TSubjectClass(), (a,f)=>f(a));

    }
}