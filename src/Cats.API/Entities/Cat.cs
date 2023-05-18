using Cats.API.Enums;

namespace Cats.API.Entities;

public class Cat
{
    public Guid Id { get; set; }
    public string Breed { get; set; } = string.Empty;
    /*public CatSize Size { get; set; }*/
    public CatCoat Coat { get; set; }
    /*public CatEnergy Energy { get; set; }
    public CatShedding Shedding { get; set; }*/
}