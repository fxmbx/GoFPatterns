namespace SOLID.O
{
    public class ANDSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;
        public ANDSpecification(ISpecification<T> _first,ISpecification<T> _second)
        {
         this.first = _first ?? throw new ArgumentNullException(paramName: nameof(_first));   
         this.second = _second ?? throw new ArgumentNullException(paramName: nameof(_second));   
        }
        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }


   

}