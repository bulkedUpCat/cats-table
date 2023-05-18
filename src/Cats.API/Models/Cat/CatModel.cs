namespace Cats.API.Models.Cat;

public class CatModel
{
    public Guid Id { get; set; }
    public string Breed { get; set; } = string.Empty;
    public string Size { get; set; }
    public string Coat { get; set; }
    public string Energy { get; set; }
    public string Shedding { get; set; }
}