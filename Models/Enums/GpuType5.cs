using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// GPUType specifies the GPU hardware to use (e.g., "h100-80gb").
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GpuType5>))]
public sealed record GpuType5 : OpenStringEnum<GpuType5>
{
    private GpuType5(string value) : base(value)
    {
    }

    public static readonly GpuType5 H10080Gb = new("h100-80gb");

    public static readonly GpuType5 H10040GbMig = new("h100-40gb-mig");

    public static readonly GpuType5 H200140Gb = new("h200-140gb");

    public static readonly GpuType5 B200192Gb = new("b200-192gb");

    public TResult Match<TResult>(Func<TResult> onH10080Gb,
        Func<TResult> onH10040GbMig,
        Func<TResult> onH200140Gb,
        Func<TResult> onB200192Gb,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == H10080Gb => onH10080Gb(),
            _ when this == H10040GbMig => onH10040GbMig(),
            _ when this == H200140Gb => onH200140Gb(),
            _ when this == B200192Gb => onB200192Gb(),
            _ => otherwise(Value)
        };

    public void Match(Action onH10080Gb,
        Action onH10040GbMig,
        Action onH200140Gb,
        Action onB200192Gb,
        Action<string> otherwise)
    {
        if (this == H10080Gb) onH10080Gb();
        else if (this == H10040GbMig) onH10040GbMig();
        else if (this == H200140Gb) onH200140Gb();
        else if (this == B200192Gb) onB200192Gb();
        else otherwise(Value);
    }
}
