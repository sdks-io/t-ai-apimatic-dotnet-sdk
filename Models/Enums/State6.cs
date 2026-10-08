using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// RemediationState represents the lifecycle state of a remediation.
/// <list type="bullet">
///   <item><description><c>PENDING_APPROVAL</c>: Awaiting approval before processing can begin.</description></item>
///   <item><description><c>PENDING</c>: Approved and queued for processing.</description></item>
///   <item><description><c>RUNNING</c>: Actively being processed.</description></item>
///   <item><description><c>SUCCEEDED</c>: Successfully completed.</description></item>
///   <item><description><c>FAILED</c>: Failed with an error.</description></item>
///   <item><description><c>CANCELLED</c>: Cancelled by user or system.</description></item>
///   <item><description><c>AUTO_RESOLVED</c>: The underlying issue was automatically resolved before processing.</description></item>
///   <item><description><c>QUARANTINING</c>: Cordoning or preparing the host before remediation.</description></item>
///   <item><description><c>QUARANTINED</c>: Host has been cordoned or isolated for remediation.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<State6>))]
public sealed record State6 : OpenStringEnum<State6>
{
    private State6(string value) : base(value)
    {
    }

    public static readonly State6 PendingApproval = new("PENDING_APPROVAL");

    public static readonly State6 Pending = new("PENDING");

    public static readonly State6 Running = new("RUNNING");

    public static readonly State6 Succeeded = new("SUCCEEDED");

    public static readonly State6 Failed = new("FAILED");

    public static readonly State6 Cancelled = new("CANCELLED");

    public static readonly State6 AutoResolved = new("AUTO_RESOLVED");

    public static readonly State6 Quarantining = new("QUARANTINING");

    public static readonly State6 Quarantined = new("QUARANTINED");

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
