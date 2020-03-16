namespace Vueling.Infrastructure.Repositories.Contracts
{
    public interface ICreate<T>
    {
        T Create(T model);
    }
}
