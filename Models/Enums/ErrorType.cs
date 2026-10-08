using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Category of validation failure.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ErrorType>))]
public sealed record ErrorType : OpenStringEnum<ErrorType>
{
    private ErrorType(string value) : base(value)
    {
    }

    public static readonly ErrorType InvalidFormat = new("INVALID_FORMAT");

    public TResult Match<TResult>(Func<TResult> onInvalidFormat, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InvalidFormat => onInvalidFormat(),
            _ => otherwise(Value)
        };

    public void Match(Action onInvalidFormat, Action<string> otherwise)
    {
        if (this == InvalidFormat) onInvalidFormat();
        else otherwise(Value);
    }
}
