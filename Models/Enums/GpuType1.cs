using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// GPU type to provision. Omit to use the model's default GPU type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GpuType1>))]
public sealed record GpuType1 : OpenStringEnum<GpuType1>
{
    private GpuType1(string value) : base(value)
    {
    }

    public static readonly GpuType1 H10080Gb = new("H100-80GB");

    public static readonly GpuType1 B200Sxm = new("B200-SXM");

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
