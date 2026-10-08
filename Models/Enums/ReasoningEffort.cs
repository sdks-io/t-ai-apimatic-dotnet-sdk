using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Controls the level of reasoning effort the model should apply when generating responses. Higher values may result in more thoughtful and detailed responses but may take longer to generate.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReasoningEffort>))]
public sealed record ReasoningEffort : OpenStringEnum<ReasoningEffort>
{
    private ReasoningEffort(string value) : base(value)
    {
    }

    public static readonly ReasoningEffort Low = new("low");

    public static readonly ReasoningEffort Medium = new("medium");

    public static readonly ReasoningEffort High = new("high");

    public TResult Match<TResult>(Func<TResult> onLow,
        Func<TResult> onMedium,
        Func<TResult> onHigh,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Low => onLow(),
            _ when this == Medium => onMedium(),
            _ when this == High => onHigh(),
            _ => otherwise(Value)
        };

    public void Match(Action onLow, Action onMedium, Action onHigh, Action<string> otherwise)
    {
        if (this == Low) onLow();
        else if (this == Medium) onMedium();
        else if (this == High) onHigh();
        else otherwise(Value);
    }
}
