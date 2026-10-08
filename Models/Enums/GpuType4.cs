using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<GpuType4>))]
public sealed record GpuType4 : OpenStringEnum<GpuType4>
{
    private GpuType4(string value) : base(value)
    {
    }

    public static readonly GpuType4 H100Sxm = new("H100_SXM");

    public static readonly GpuType4 H200Sxm = new("H200_SXM");

    public static readonly GpuType4 Rtx6000Pci = new("RTX_6000_PCI");

    public static readonly GpuType4 L40Pcie = new("L40_PCIE");

    public static readonly GpuType4 B200Sxm = new("B200_SXM");

    public static readonly GpuType4 H100SxmInf = new("H100_SXM_INF");

    public static readonly GpuType4 B300Sxm = new("B300_SXM");

    public TResult Match<TResult>(Func<TResult> onH100Sxm,
        Func<TResult> onH200Sxm,
        Func<TResult> onRtx6000Pci,
        Func<TResult> onL40Pcie,
        Func<TResult> onB200Sxm,
        Func<TResult> onH100SxmInf,
        Func<TResult> onB300Sxm,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == H100Sxm => onH100Sxm(),
            _ when this == H200Sxm => onH200Sxm(),
            _ when this == Rtx6000Pci => onRtx6000Pci(),
            _ when this == L40Pcie => onL40Pcie(),
            _ when this == B200Sxm => onB200Sxm(),
            _ when this == H100SxmInf => onH100SxmInf(),
            _ when this == B300Sxm => onB300Sxm(),
            _ => otherwise(Value)
        };

    public void Match(Action onH100Sxm,
        Action onH200Sxm,
        Action onRtx6000Pci,
        Action onL40Pcie,
        Action onB200Sxm,
        Action onH100SxmInf,
        Action onB300Sxm,
        Action<string> otherwise)
    {
        if (this == H100Sxm) onH100Sxm();
        else if (this == H200Sxm) onH200Sxm();
        else if (this == Rtx6000Pci) onRtx6000Pci();
        else if (this == L40Pcie) onL40Pcie();
        else if (this == B200Sxm) onB200Sxm();
        else if (this == H100SxmInf) onH100SxmInf();
        else if (this == B300Sxm) onB300Sxm();
        else otherwise(Value);
    }
}
