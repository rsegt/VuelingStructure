using System.Collections.Generic;

namespace Vueling.Infrastructure.Repositories.Contracts
{
    public interface IGet<T>
    {
        List<T> GetAll();
    }
}
