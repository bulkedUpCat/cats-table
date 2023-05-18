using System.ComponentModel;
using AutoMapper;
using Cats.API.Entities;
using Cats.API.Models.Cat;

namespace Cats.API.MappingProfiles;

public class CatProfile: Profile
{
    public CatProfile()
    {
        CreateMap<Cat, CatModel>()
            .ForMember(dest => dest.Coat, src => src.MapFrom(opt => GetEnumDescription(opt.Coat)));
    }
    
    private static string GetEnumDescription(Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attribute = field?.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

        return attribute.Length > 0 ? attribute[0].Description : value.ToString();
    }
}