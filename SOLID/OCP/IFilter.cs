using System.Runtime.CompilerServices;

namespace SOLID.OCP
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}