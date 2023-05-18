using System.ComponentModel;

namespace Cats.API.Enums;

public enum CatCoat
{
    [Description(nameof(Long))]
    Long,
    [Description(nameof(Medium))]
    Medium,
    [Description(nameof(Short))]
    Short
}