using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Node phase.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Phase>))]
public sealed record Phase : OpenStringEnum<Phase>
{
    private Phase(string value) : base(value)
    {
    }

    public static readonly Phase NodePhasePending = new("NODE_PHASE_PENDING");

    public static readonly Phase NodePhaseScheduling = new("NODE_PHASE_SCHEDULING");

    public static readonly Phase NodePhaseBooting = new("NODE_PHASE_BOOTING");

    public static readonly Phase NodePhaseBootstrapping = new("NODE_PHASE_BOOTSTRAPPING");

    public static readonly Phase NodePhaseRunning = new("NODE_PHASE_RUNNING");

    public static readonly Phase NodePhaseSucceeded = new("NODE_PHASE_SUCCEEDED");

    public static readonly Phase NodePhaseFailed = new("NODE_PHASE_FAILED");

    public static readonly Phase NodePhasePaused = new("NODE_PHASE_PAUSED");

    public TResult Match<TResult>(Func<TResult> onNodePhasePending,
        Func<TResult> onNodePhaseScheduling,
        Func<TResult> onNodePhaseBooting,
        Func<TResult> onNodePhaseBootstrapping,
        Func<TResult> onNodePhaseRunning,
        Func<TResult> onNodePhaseSucceeded,
        Func<TResult> onNodePhaseFailed,
        Func<TResult> onNodePhasePaused,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NodePhasePending => onNodePhasePending(),
            _ when this == NodePhaseScheduling => onNodePhaseScheduling(),
            _ when this == NodePhaseBooting => onNodePhaseBooting(),
            _ when this == NodePhaseBootstrapping => onNodePhaseBootstrapping(),
            _ when this == NodePhaseRunning => onNodePhaseRunning(),
            _ when this == NodePhaseSucceeded => onNodePhaseSucceeded(),
            _ when this == NodePhaseFailed => onNodePhaseFailed(),
            _ when this == NodePhasePaused => onNodePhasePaused(),
            _ => otherwise(Value)
        };

    public void Match(Action onNodePhasePending,
        Action onNodePhaseScheduling,
        Action onNodePhaseBooting,
        Action onNodePhaseBootstrapping,
        Action onNodePhaseRunning,
        Action onNodePhaseSucceeded,
        Action onNodePhaseFailed,
        Action onNodePhasePaused,
        Action<string> otherwise)
    {
        if (this == NodePhasePending) onNodePhasePending();
        else if (this == NodePhaseScheduling) onNodePhaseScheduling();
        else if (this == NodePhaseBooting) onNodePhaseBooting();
        else if (this == NodePhaseBootstrapping) onNodePhaseBootstrapping();
        else if (this == NodePhaseRunning) onNodePhaseRunning();
        else if (this == NodePhaseSucceeded) onNodePhaseSucceeded();
        else if (this == NodePhaseFailed) onNodePhaseFailed();
        else if (this == NodePhasePaused) onNodePhasePaused();
        else otherwise(Value);
    }
}
