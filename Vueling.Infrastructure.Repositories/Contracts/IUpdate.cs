namespace Vueling.Infrastructure.Repositories.Contracts
{
    public interface IUpdate<T>
    {
        T Update(T model);
    }
}
