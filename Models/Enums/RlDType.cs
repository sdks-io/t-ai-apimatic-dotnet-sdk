using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RlDType>))]
public sealed record RlDType : OpenStringEnum<RlDType>
{
    private RlDType(string value) : base(value)
    {
    }

    public static readonly RlDType DTypeUnspecified = new("D_TYPE_UNSPECIFIED");

    public static readonly RlDType DTypeInt64 = new("D_TYPE_INT64");

    public static readonly RlDType DTypeFloat32 = new("D_TYPE_FLOAT32");

    public static readonly RlDType DTypeBfloat16 = new("D_TYPE_BFLOAT16");

    public TResult Match<TResult>(Func<TResult> onDTypeUnspecified,
        Func<TResult> onDTypeInt64,
        Func<TResult> onDTypeFloat32,
        Func<TResult> onDTypeBfloat16,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DTypeUnspecified => onDTypeUnspecified(),
            _ when this == DTypeInt64 => onDTypeInt64(),
            _ when this == DTypeFloat32 => onDTypeFloat32(),
            _ when this == DTypeBfloat16 => onDTypeBfloat16(),
            _ => otherwise(Value)
        };

    public void Match(Action onDTypeUnspecified,
        Action onDTypeInt64,
        Action onDTypeFloat32,
        Action onDTypeBfloat16,
        Action<string> otherwise)
    {
        if (this == DTypeUnspecified) onDTypeUnspecified();
        else if (this == DTypeInt64) onDTypeInt64();
        else if (this == DTypeFloat32) onDTypeFloat32();
        else if (this == DTypeBfloat16) onDTypeBfloat16();
        else otherwise(Value);
    }
}
