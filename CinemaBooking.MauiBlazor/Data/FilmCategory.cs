using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

[JsonConverter(typeof(StringEnumConverter))]
public enum FilmCategory
{
    [EnumMember(Value = "Action")]
    Action,
    [EnumMember(Value = "Drama")]
    Drama,
    [EnumMember(Value = "Comedy")]
    Comedy,
    [EnumMember(Value = "Fantasy")]
    Fantasy,
    [EnumMember(Value = "Horror")]
    Horror,
    [EnumMember(Value = "Mystery")]
    Mystery,
    [EnumMember(Value = "Romance")]
    Romance,
    [EnumMember(Value = "Thriller")]
    Thriller,
    [EnumMember(Value = "Western")]
    Western,
    [EnumMember(Value = "Adventure")]
    Adventure,
    [EnumMember(Value = "Science Fiction")]
    ScienceFiction
}