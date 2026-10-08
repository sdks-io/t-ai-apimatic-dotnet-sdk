using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Frame>))]
public sealed record Frame : OpenStringEnum<Frame>
{
    private Frame(string value) : base(value)
    {
    }

    public static readonly Frame First = new("first");

    public static readonly Frame Last = new("last");

    public TResult Match<TResult>(Func<TResult> onFirst, Func<TResult> onLast, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == First => onFirst(),
            _ when this == Last => onLast(),
            _ => otherwise(Value)
        };

    public void Match(Action onFirst, Action onLast, Action<string> otherwise)
    {
        if (this == First) onFirst();
        else if (this == Last) onLast();
        else otherwise(Value);
    }
}
