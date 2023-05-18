using Cats.API.Models.Cat;

namespace Cats.API.Services.Interfaces;

public interface ICatService
{
    IEnumerable<CatModel> GetAllCats();
}