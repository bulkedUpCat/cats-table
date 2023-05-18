using AutoMapper;
using Cats.API.DataProviders.Interfaces;
using Cats.API.Models.Cat;
using Cats.API.Services.Interfaces;

namespace Cats.API.Services;

public class CatService: ICatService
{
    private readonly IDataProvider _dataProvider;
    private readonly IMapper _mapper;

    public CatService(
        IDataProvider dataProvider, 
        IMapper mapper)
    {
        _dataProvider = dataProvider;
        _mapper = mapper;
    }

    public IEnumerable<CatModel> GetAllCats()
    {
        var cats = _dataProvider.GetAllCats();
        var catModels = _mapper.Map<IEnumerable<CatModel>>(cats);

        return catModels;
    }
}