namespace Vueling.Infrastructure.Repositories.Contracts
{
    public interface IRepository<T> : ICreate<T>, IUpdate<T>, IDelete, IGet<T>
    {
    }
}
