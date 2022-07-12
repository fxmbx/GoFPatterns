namespace SOLID.O
{
    public interface ISpecification<T>
    {
         bool IsSatisfied(T t);
    }
}