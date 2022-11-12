using System.Linq.Expressions;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Critieria { get; }
        List<Expression<Func<T, object>>> Includes { get; }

    }
}