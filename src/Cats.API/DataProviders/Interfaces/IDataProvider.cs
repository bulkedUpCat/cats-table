using Cats.API.Entities;

namespace Cats.API.DataProviders.Interfaces;

public interface IDataProvider
{
    IEnumerable<Cat> GetAllCats();
}