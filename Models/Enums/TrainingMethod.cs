using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Fine-tuning method to preview. Only supervised fine-tuning is currently supported.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TrainingMethod>))]
public sealed record TrainingMethod : OpenStringEnum<TrainingMethod>
{
    private TrainingMethod(string value) : base(value)
    {
    }

    public static readonly TrainingMethod Sft = new("sft");

    public TResult Match<TResult>(Func<TResult> onSft, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Sft => onSft(),
            _ => otherwise(Value)
        };

    public void Match(Action onSft, Action<string> otherwise)
    {
        if (this == Sft) onSft();
        else otherwise(Value);
    }
}
