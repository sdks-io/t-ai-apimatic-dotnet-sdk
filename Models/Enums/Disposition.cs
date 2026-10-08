using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Optional cancel behavior. Absent defaults to freeze, which preserves the current traffic split. Revert is removed and rejected with FAILED_PRECONDITION; cancel with freeze, then run a reverse rollout back to the source.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Disposition>))]
public sealed record Disposition : OpenStringEnum<Disposition>
{
    private Disposition(string value) : base(value)
    {
    }

    public static readonly Disposition CancelDispositionFreeze = new("CANCEL_DISPOSITION_FREEZE");

    public static readonly Disposition CancelDispositionRevert = new("CANCEL_DISPOSITION_REVERT");

    public TResult Match<TResult>(Func<TResult> onCancelDispositionFreeze,
        Func<TResult> onCancelDispositionRevert,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CancelDispositionFreeze => onCancelDispositionFreeze(),
            _ when this == CancelDispositionRevert => onCancelDispositionRevert(),
            _ => otherwise(Value)
        };

    public void Match(Action onCancelDispositionFreeze, Action onCancelDispositionRevert, Action<string> otherwise)
    {
        if (this == CancelDispositionFreeze) onCancelDispositionFreeze();
        else if (this == CancelDispositionRevert) onCancelDispositionRevert();
        else otherwise(Value);
    }
}
