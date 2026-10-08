using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The format of the response
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResponseFormat1>))]
public sealed record ResponseFormat1 : OpenStringEnum<ResponseFormat1>
{
    private ResponseFormat1(string value) : base(value)
    {
    }

    public static readonly ResponseFormat1 Json = new("json");

    public static readonly ResponseFormat1 VerboseJson = new("verbose_json");

    public TResult Match<TResult>(Func<TResult> onJson, Func<TResult> onVerboseJson, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Json => onJson(),
            _ when this == VerboseJson => onVerboseJson(),
            _ => otherwise(Value)
        };

    public void Match(Action onJson, Action onVerboseJson, Action<string> otherwise)
    {
        if (this == Json) onJson();
        else if (this == VerboseJson) onVerboseJson();
        else otherwise(Value);
    }
}
