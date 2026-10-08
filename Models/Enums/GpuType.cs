using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// GPU type selected for this resource.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GpuType>))]
public sealed record GpuType : OpenStringEnum<GpuType>
{
    private GpuType(string value) : base(value)
    {
    }

    public static readonly GpuType H10080Gb = new("H100-80GB");

    public static readonly GpuType B200Sxm = new("B200-SXM");

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
