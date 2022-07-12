using System.Runtime.CompilerServices;

namespace SOLID.O
{
    public interface IFilter<T>
    {
         IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}