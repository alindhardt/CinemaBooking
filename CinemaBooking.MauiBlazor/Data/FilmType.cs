using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

[JsonConverter(typeof(StringEnumConverter))]
public enum FilmType
{
    [EnumMember(Value = "2D")]
    TwoD,
    [EnumMember(Value = "3D")]
    ThreeD
}