using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The object type, which is always <c>secret</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Object5>))]
public sealed record Object5 : OpenStringEnum<Object5>
{
    private Object5(string value) : base(value)
    {
    }

    public static readonly Object5 Secret = new("secret");

    public TResult Match<TResult>(Func<TResult> onSecret, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Secret => onSecret(),
            _ => otherwise(Value)
        };

    public void Match(Action onSecret, Action<string> otherwise)
    {
        if (this == Secret) onSecret();
        else otherwise(Value);
    }
}
