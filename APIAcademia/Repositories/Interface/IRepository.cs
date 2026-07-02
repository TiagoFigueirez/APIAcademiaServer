using System.Linq.Expressions;

namespace APIAcademia.Repositories.Interface
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetAsync(Expression<Func<T, bool>> precidacte);
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);

    }
}
