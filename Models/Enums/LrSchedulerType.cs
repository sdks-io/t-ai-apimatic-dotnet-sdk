using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<LrSchedulerType>))]
public sealed record LrSchedulerType : OpenStringEnum<LrSchedulerType>
{
    private LrSchedulerType(string value) : base(value)
    {
    }

    public static readonly LrSchedulerType Linear = new("linear");

    public static readonly LrSchedulerType Cosine = new("cosine");

    public TResult Match<TResult>(Func<TResult> onLinear, Func<TResult> onCosine, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Linear => onLinear(),
            _ when this == Cosine => onCosine(),
            _ => otherwise(Value)
        };

    public void Match(Action onLinear, Action onCosine, Action<string> otherwise)
    {
        if (this == Linear) onLinear();
        else if (this == Cosine) onCosine();
        else otherwise(Value);
    }
}
