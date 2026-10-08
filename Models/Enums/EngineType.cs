using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Inference engine used to serve the model.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EngineType>))]
public sealed record EngineType : OpenStringEnum<EngineType>
{
    private EngineType(string value) : base(value)
    {
    }

    public static readonly EngineType EngineTypePulsar = new("ENGINE_TYPE_PULSAR");

    public static readonly EngineType EngineTypeVllm = new("ENGINE_TYPE_VLLM");

    public static readonly EngineType EngineTypeSglang = new("ENGINE_TYPE_SGLANG");

    public static readonly EngineType EngineTypeTgl = new("ENGINE_TYPE_TGL");

    public static readonly EngineType EngineTypeTrtllm = new("ENGINE_TYPE_TRTLLM");

    public static readonly EngineType EngineTypeSmg = new("ENGINE_TYPE_SMG");

    public TResult Match<TResult>(Func<TResult> onEngineTypePulsar,
        Func<TResult> onEngineTypeVllm,
        Func<TResult> onEngineTypeSglang,
        Func<TResult> onEngineTypeTgl,
        Func<TResult> onEngineTypeTrtllm,
        Func<TResult> onEngineTypeSmg,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == EngineTypePulsar => onEngineTypePulsar(),
            _ when this == EngineTypeVllm => onEngineTypeVllm(),
            _ when this == EngineTypeSglang => onEngineTypeSglang(),
            _ when this == EngineTypeTgl => onEngineTypeTgl(),
            _ when this == EngineTypeTrtllm => onEngineTypeTrtllm(),
            _ when this == EngineTypeSmg => onEngineTypeSmg(),
            _ => otherwise(Value)
        };

    public void Match(Action onEngineTypePulsar,
        Action onEngineTypeVllm,
        Action onEngineTypeSglang,
        Action onEngineTypeTgl,
        Action onEngineTypeTrtllm,
        Action onEngineTypeSmg,
        Action<string> otherwise)
    {
        if (this == EngineTypePulsar) onEngineTypePulsar();
        else if (this == EngineTypeVllm) onEngineTypeVllm();
        else if (this == EngineTypeSglang) onEngineTypeSglang();
        else if (this == EngineTypeTgl) onEngineTypeTgl();
        else if (this == EngineTypeTrtllm) onEngineTypeTrtllm();
        else if (this == EngineTypeSmg) onEngineTypeSmg();
        else otherwise(Value);
    }
}
