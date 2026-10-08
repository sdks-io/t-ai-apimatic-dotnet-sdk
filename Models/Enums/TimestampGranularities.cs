using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TimestampGranularities>))]
public sealed record TimestampGranularities : OpenStringEnum<TimestampGranularities>
{
    private TimestampGranularities(string value) : base(value)
    {
    }

    public static readonly TimestampGranularities Segment = new("segment");

    public static readonly TimestampGranularities Word = new("word");

    public TResult Match<TResult>(Func<TResult> onSegment, Func<TResult> onWord, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Segment => onSegment(),
            _ when this == Word => onWord(),
            _ => otherwise(Value)
        };

    public void Match(Action onSegment, Action onWord, Action<string> otherwise)
    {
        if (this == Segment) onSegment();
        else if (this == Word) onWord();
        else otherwise(Value);
    }
}
