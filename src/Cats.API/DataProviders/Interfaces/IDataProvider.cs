using Cats.API.Entities;

namespace Cats.API.DataProviders.Interfaces;

public interface IDataProvider
{
    Task<IEnumerable<Cat>> GetAllCatsAsync();
}