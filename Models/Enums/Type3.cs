using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Role of the weights: full model, speculative draft model, or LoRA adapter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type3>))]
public sealed record Type3 : OpenStringEnum<Type3>
{
    private Type3(string value) : base(value)
    {
    }

    public static readonly Type3 WeightsTypeDefault = new("WEIGHTS_TYPE_DEFAULT");

    public static readonly Type3 WeightsTypeSpeculator = new("WEIGHTS_TYPE_SPECULATOR");

    public static readonly Type3 WeightsTypeAdapter = new("WEIGHTS_TYPE_ADAPTER");

    public TResult Match<TResult>(Func<TResult> onWeightsTypeDefault,
        Func<TResult> onWeightsTypeSpeculator,
        Func<TResult> onWeightsTypeAdapter,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == WeightsTypeDefault => onWeightsTypeDefault(),
            _ when this == WeightsTypeSpeculator => onWeightsTypeSpeculator(),
            _ when this == WeightsTypeAdapter => onWeightsTypeAdapter(),
            _ => otherwise(Value)
        };

    public void Match(Action onWeightsTypeDefault,
        Action onWeightsTypeSpeculator,
        Action onWeightsTypeAdapter,
        Action<string> otherwise)
    {
        if (this == WeightsTypeDefault) onWeightsTypeDefault();
        else if (this == WeightsTypeSpeculator) onWeightsTypeSpeculator();
        else if (this == WeightsTypeAdapter) onWeightsTypeAdapter();
        else otherwise(Value);
    }
}
