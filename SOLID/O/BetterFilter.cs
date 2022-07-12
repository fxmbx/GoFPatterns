namespace SOLID.O
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach(var a in items){
                if(spec.IsSatisfied(a))
                    yield return a;
            }
        }
    }
}