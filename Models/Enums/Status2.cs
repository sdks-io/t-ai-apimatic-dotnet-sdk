using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Current status of the GPU cluster.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status2>))]
public sealed record Status2 : OpenStringEnum<Status2>
{
    private Status2(string value) : base(value)
    {
    }

    public static readonly Status2 WaitingForControlPlaneNodes = new("WaitingForControlPlaneNodes");

    public static readonly Status2 WaitingForDataPlaneNodes = new("WaitingForDataPlaneNodes");

    public static readonly Status2 WaitingForSubnet = new("WaitingForSubnet");

    public static readonly Status2 WaitingForSharedVolume = new("WaitingForSharedVolume");

    public static readonly Status2 InstallingDrivers = new("InstallingDrivers");

    public static readonly Status2 RunningAcceptanceTests = new("RunningAcceptanceTests");

    public static readonly Status2 Paused = new("Paused");

    public static readonly Status2 OnDemandComputePaused = new("OnDemandComputePaused");

    public static readonly Status2 Ready = new("Ready");

    public static readonly Status2 Degraded = new("Degraded");

    public static readonly Status2 Deleting = new("Deleting");

    public TResult Match<TResult>(Func<TResult> onWaitingForControlPlaneNodes,
        Func<TResult> onWaitingForDataPlaneNodes,
        Func<TResult> onWaitingForSubnet,
        Func<TResult> onWaitingForSharedVolume,
        Func<TResult> onInstallingDrivers,
        Func<TResult> onRunningAcceptanceTests,
        Func<TResult> onPaused,
        Func<TResult> onOnDemandComputePaused,
        Func<TResult> onReady,
        Func<TResult> onDegraded,
        Func<TResult> onDeleting,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == WaitingForControlPlaneNodes => onWaitingForControlPlaneNodes(),
            _ when this == WaitingForDataPlaneNodes => onWaitingForDataPlaneNodes(),
            _ when this == WaitingForSubnet => onWaitingForSubnet(),
            _ when this == WaitingForSharedVolume => onWaitingForSharedVolume(),
            _ when this == InstallingDrivers => onInstallingDrivers(),
            _ when this == RunningAcceptanceTests => onRunningAcceptanceTests(),
            _ when this == Paused => onPaused(),
            _ when this == OnDemandComputePaused => onOnDemandComputePaused(),
            _ when this == Ready => onReady(),
            _ when this == Degraded => onDegraded(),
            _ when this == Deleting => onDeleting(),
            _ => otherwise(Value)
        };

    public void Match(Action onWaitingForControlPlaneNodes,
        Action onWaitingForDataPlaneNodes,
        Action onWaitingForSubnet,
        Action onWaitingForSharedVolume,
        Action onInstallingDrivers,
        Action onRunningAcceptanceTests,
        Action onPaused,
        Action onOnDemandComputePaused,
        Action onReady,
        Action onDegraded,
        Action onDeleting,
        Action<string> otherwise)
    {
        if (this == WaitingForControlPlaneNodes) onWaitingForControlPlaneNodes();
        else if (this == WaitingForDataPlaneNodes) onWaitingForDataPlaneNodes();
        else if (this == WaitingForSubnet) onWaitingForSubnet();
        else if (this == WaitingForSharedVolume) onWaitingForSharedVolume();
        else if (this == InstallingDrivers) onInstallingDrivers();
        else if (this == RunningAcceptanceTests) onRunningAcceptanceTests();
        else if (this == Paused) onPaused();
        else if (this == OnDemandComputePaused) onOnDemandComputePaused();
        else if (this == Ready) onReady();
        else if (this == Degraded) onDegraded();
        else if (this == Deleting) onDeleting();
        else otherwise(Value);
    }
}
