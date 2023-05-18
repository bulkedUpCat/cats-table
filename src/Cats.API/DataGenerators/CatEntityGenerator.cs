using Bogus;
using Cats.API.Entities;
using Cats.API.Enums;

namespace Cats.API.DataGenerators;

public class CatEntityGenerator
{
    private readonly Faker<Cat> _faker;
    private readonly IEnumerable<string> _catBreeds = new List<string>
    {
        "Abyssinian", "American Bobtail", "American Curl", "American Shorthair", "American Wirehair",
        "Balinese", "Bengal", "Birman", "Bombay", "British Shorthair",
        "Burmese", "Chartreux", "Chausie", "Cornish Rex", "Devon Rex",
        "Egyptian Mau", "European Shorthair", "Exotic Shorthair", "Havana Brown", "Himalayan",
        "Japanese Bobtail", "Javanese", "LaPerm", "Maine Coon", "Manx",
        "Munchkin", "Norwegian Forest", "Oriental", "Persian", "Ragamuffin",
        "Savannah", "Scottish Fold", "Selkirk Rex", "Siamese", "Siberian",
        "Somali", "Turkish Angora", "Turkish Van"
    };


    public CatEntityGenerator()
    {
        _faker = new Faker<Cat>()
            .RuleFor(c => c.Id, faker => faker.Random.Guid())
            .RuleFor(c => c.Breed, faker => faker.PickRandom(_catBreeds))
            .RuleFor(c => c.Coat, faker => faker.PickRandom<CatCoat>());
    }

    public Cat Generate()
    {
        return _faker.Generate();
    }

    public IEnumerable<Cat> Generate(int n)
    {
        return _faker.Generate(n);
    }
}