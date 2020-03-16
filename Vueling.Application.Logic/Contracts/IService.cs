namespace Vueling.Application.Logic.Contracts
{
    public interface IService<T> : ICreate<T>, IUpdate<T>, IGet<T>, IDelete
    {
    }
}
