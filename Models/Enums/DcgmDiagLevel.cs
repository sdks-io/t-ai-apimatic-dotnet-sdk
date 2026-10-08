using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// DCGM diagnostic depth. SHORT = readiness; MEDIUM = default; LONG = system validation; EXTENDED = memtest. An omitted value selects MEDIUM when enabled.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DcgmDiagLevel>))]
public sealed record DcgmDiagLevel : OpenStringEnum<DcgmDiagLevel>
{
    private DcgmDiagLevel(string value) : base(value)
    {
    }

    public static readonly DcgmDiagLevel DcgmDiagLevelShort = new("DCGM_DIAG_LEVEL_SHORT");

    public static readonly DcgmDiagLevel DcgmDiagLevelMedium = new("DCGM_DIAG_LEVEL_MEDIUM");

    public static readonly DcgmDiagLevel DcgmDiagLevelLong = new("DCGM_DIAG_LEVEL_LONG");

    public static readonly DcgmDiagLevel DcgmDiagLevelExtended = new("DCGM_DIAG_LEVEL_EXTENDED");

    public TResult Match<TResult>(Func<TResult> onDcgmDiagLevelShort,
        Func<TResult> onDcgmDiagLevelMedium,
        Func<TResult> onDcgmDiagLevelLong,
        Func<TResult> onDcgmDiagLevelExtended,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DcgmDiagLevelShort => onDcgmDiagLevelShort(),
            _ when this == DcgmDiagLevelMedium => onDcgmDiagLevelMedium(),
            _ when this == DcgmDiagLevelLong => onDcgmDiagLevelLong(),
            _ when this == DcgmDiagLevelExtended => onDcgmDiagLevelExtended(),
            _ => otherwise(Value)
        };

    public void Match(Action onDcgmDiagLevelShort,
        Action onDcgmDiagLevelMedium,
        Action onDcgmDiagLevelLong,
        Action onDcgmDiagLevelExtended,
        Action<string> otherwise)
    {
        if (this == DcgmDiagLevelShort) onDcgmDiagLevelShort();
        else if (this == DcgmDiagLevelMedium) onDcgmDiagLevelMedium();
        else if (this == DcgmDiagLevelLong) onDcgmDiagLevelLong();
        else if (this == DcgmDiagLevelExtended) onDcgmDiagLevelExtended();
        else otherwise(Value);
    }
}
