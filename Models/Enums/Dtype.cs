using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Tensor element type, either <c>int64</c> or <c>float32</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Dtype>))]
public sealed record Dtype : OpenStringEnum<Dtype>
{
    private Dtype(string value) : base(value)
    {
    }

    public static readonly Dtype Int64 = new("int64");

    public static readonly Dtype Float32 = new("float32");

    public TResult Match<TResult>(Func<TResult> onInt64, Func<TResult> onFloat32, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Int64 => onInt64(),
            _ when this == Float32 => onFloat32(),
            _ => otherwise(Value)
        };

    public void Match(Action onInt64, Action onFloat32, Action<string> otherwise)
    {
        if (this == Int64) onInt64();
        else if (this == Float32) onFloat32();
        else otherwise(Value);
    }
}
