using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<State11>))]
public sealed record State11 : OpenStringEnum<State11>
{
    private State11(string value) : base(value)
    {
    }

    public static readonly State11 PendingApproval = new("PENDING_APPROVAL");

    public static readonly State11 Pending = new("PENDING");

    public static readonly State11 Running = new("RUNNING");

    public static readonly State11 Succeeded = new("SUCCEEDED");

    public static readonly State11 Failed = new("FAILED");

    public static readonly State11 Cancelled = new("CANCELLED");

    public static readonly State11 AutoResolved = new("AUTO_RESOLVED");

    public static readonly State11 Quarantining = new("QUARANTINING");

    public static readonly State11 Quarantined = new("QUARANTINED");

    public TResult Match<TResult>(Func<TResult> onPendingApproval,
        Func<TResult> onPending,
        Func<TResult> onRunning,
        Func<TResult> onSucceeded,
        Func<TResult> onFailed,
        Func<TResult> onCancelled,
        Func<TResult> onAutoResolved,
        Func<TResult> onQuarantining,
        Func<TResult> onQuarantined,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PendingApproval => onPendingApproval(),
            _ when this == Pending => onPending(),
            _ when this == Running => onRunning(),
            _ when this == Succeeded => onSucceeded(),
            _ when this == Failed => onFailed(),
            _ when this == Cancelled => onCancelled(),
            _ when this == AutoResolved => onAutoResolved(),
            _ when this == Quarantining => onQuarantining(),
            _ when this == Quarantined => onQuarantined(),
            _ => otherwise(Value)
        };

    public void Match(Action onPendingApproval,
        Action onPending,
        Action onRunning,
        Action onSucceeded,
        Action onFailed,
        Action onCancelled,
        Action onAutoResolved,
        Action onQuarantining,
        Action onQuarantined,
        Action<string> otherwise)
    {
        if (this == PendingApproval) onPendingApproval();
        else if (this == Pending) onPending();
        else if (this == Running) onRunning();
        else if (this == Succeeded) onSucceeded();
        else if (this == Failed) onFailed();
        else if (this == Cancelled) onCancelled();
        else if (this == AutoResolved) onAutoResolved();
        else if (this == Quarantining) onQuarantining();
        else if (this == Quarantined) onQuarantined();
        else otherwise(Value);
    }
}
