using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BatchSize>))]
public sealed record BatchSize : OpenStringEnum<BatchSize>
{
    private BatchSize(string value) : base(value)
    {
    }

    public static readonly BatchSize Max = new("max");

    public TResult Match<TResult>(Func<TResult> onMax, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Max => onMax(),
            _ => otherwise(Value)
        };

    public void Match(Action onMax, Action<string> otherwise)
    {
        if (this == Max) onMax();
        else otherwise(Value);
    }
}
