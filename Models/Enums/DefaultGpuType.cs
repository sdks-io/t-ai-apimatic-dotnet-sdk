using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// GPU type used when model-resource creation omits gpu_type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DefaultGpuType>))]
public sealed record DefaultGpuType : OpenStringEnum<DefaultGpuType>
{
    private DefaultGpuType(string value) : base(value)
    {
    }

    public static readonly DefaultGpuType H10080Gb = new("H100-80GB");

    public static readonly DefaultGpuType B200Sxm = new("B200-SXM");

    public TResult Match<TResult>(Func<TResult> onH10080Gb, Func<TResult> onB200Sxm, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == H10080Gb => onH10080Gb(),
            _ when this == B200Sxm => onB200Sxm(),
            _ => otherwise(Value)
        };

    public void Match(Action onH10080Gb, Action onB200Sxm, Action<string> otherwise)
    {
        if (this == H10080Gb) onH10080Gb();
        else if (this == B200Sxm) onB200Sxm();
        else otherwise(Value);
    }
}
