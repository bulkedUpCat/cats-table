using Cats.API.DataGenerators;
using Cats.API.DataProviders.Interfaces;
using Cats.API.Entities;
using Cats.API.Models.Cat;

namespace Cats.API.DataProviders;

public class DataProvider: IDataProvider
{
    private readonly CatEntityGenerator _catEntityGenerator;

    public DataProvider()
    {
        _catEntityGenerator = new CatEntityGenerator();
    }

    public Task<IEnumerable<Cat>> GetAllCatsAsync()
    {
        return Task.FromResult(_catEntityGenerator.Generate(100));
    }
}