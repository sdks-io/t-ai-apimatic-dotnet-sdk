using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Cluster phase.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Phase1>))]
public sealed record Phase1 : OpenStringEnum<Phase1>
{
    private Phase1(string value) : base(value)
    {
    }

    public static readonly Phase1 ClusterPhaseQueued = new("CLUSTER_PHASE_QUEUED");

    public static readonly Phase1 ClusterPhaseScheduled = new("CLUSTER_PHASE_SCHEDULED");

    public static readonly Phase1 ClusterPhaseWaitingForControlPlaneNodes = new(
        "CLUSTER_PHASE_WAITING_FOR_CONTROL_PLANE_NODES");

    public static readonly Phase1 ClusterPhaseWaitingForDataPlaneNodes = new(
        "CLUSTER_PHASE_WAITING_FOR_DATA_PLANE_NODES");

    public static readonly Phase1 ClusterPhaseWaitingForSubnet = new("CLUSTER_PHASE_WAITING_FOR_SUBNET");

    public static readonly Phase1 ClusterPhaseWaitingForSharedVolume = new("CLUSTER_PHASE_WAITING_FOR_SHARED_VOLUME");

    public static readonly Phase1 ClusterPhaseWaitingForAutoScaler = new("CLUSTER_PHASE_WAITING_FOR_AUTO_SCALER");

    public static readonly Phase1 ClusterPhaseInstallingDrivers = new("CLUSTER_PHASE_INSTALLING_DRIVERS");

    public static readonly Phase1 ClusterPhaseRunningAcceptanceTests = new("CLUSTER_PHASE_RUNNING_ACCEPTANCE_TESTS");

    public static readonly Phase1 ClusterPhaseAcceptanceTestsFailed = new("CLUSTER_PHASE_ACCEPTANCE_TESTS_FAILED");

    public static readonly Phase1 ClusterPhaseRunningNcclTests = new("CLUSTER_PHASE_RUNNING_NCCL_TESTS");

    public static readonly Phase1 ClusterPhaseNcclTestsFailed = new("CLUSTER_PHASE_NCCL_TESTS_FAILED");

    public static readonly Phase1 ClusterPhaseReady = new("CLUSTER_PHASE_READY");

    public static readonly Phase1 ClusterPhasePaused = new("CLUSTER_PHASE_PAUSED");

    public static readonly Phase1 ClusterPhaseOnDemandComputePaused = new("CLUSTER_PHASE_ON_DEMAND_COMPUTE_PAUSED");

    public static readonly Phase1 ClusterPhaseDegraded = new("CLUSTER_PHASE_DEGRADED");

    public static readonly Phase1 ClusterPhaseDeleting = new("CLUSTER_PHASE_DELETING");

    public TResult Match<TResult>(Func<TResult> onClusterPhaseQueued,
        Func<TResult> onClusterPhaseScheduled,
        Func<TResult> onClusterPhaseWaitingForControlPlaneNodes,
        Func<TResult> onClusterPhaseWaitingForDataPlaneNodes,
        Func<TResult> onClusterPhaseWaitingForSubnet,
        Func<TResult> onClusterPhaseWaitingForSharedVolume,
        Func<TResult> onClusterPhaseWaitingForAutoScaler,
        Func<TResult> onClusterPhaseInstallingDrivers,
        Func<TResult> onClusterPhaseRunningAcceptanceTests,
        Func<TResult> onClusterPhaseAcceptanceTestsFailed,
        Func<TResult> onClusterPhaseRunningNcclTests,
        Func<TResult> onClusterPhaseNcclTestsFailed,
        Func<TResult> onClusterPhaseReady,
        Func<TResult> onClusterPhasePaused,
        Func<TResult> onClusterPhaseOnDemandComputePaused,
        Func<TResult> onClusterPhaseDegraded,
        Func<TResult> onClusterPhaseDeleting,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ClusterPhaseQueued => onClusterPhaseQueued(),
            _ when this == ClusterPhaseScheduled => onClusterPhaseScheduled(),
            _ when this == ClusterPhaseWaitingForControlPlaneNodes => onClusterPhaseWaitingForControlPlaneNodes(),
            _ when this == ClusterPhaseWaitingForDataPlaneNodes => onClusterPhaseWaitingForDataPlaneNodes(),
            _ when this == ClusterPhaseWaitingForSubnet => onClusterPhaseWaitingForSubnet(),
            _ when this == ClusterPhaseWaitingForSharedVolume => onClusterPhaseWaitingForSharedVolume(),
            _ when this == ClusterPhaseWaitingForAutoScaler => onClusterPhaseWaitingForAutoScaler(),
            _ when this == ClusterPhaseInstallingDrivers => onClusterPhaseInstallingDrivers(),
            _ when this == ClusterPhaseRunningAcceptanceTests => onClusterPhaseRunningAcceptanceTests(),
            _ when this == ClusterPhaseAcceptanceTestsFailed => onClusterPhaseAcceptanceTestsFailed(),
            _ when this == ClusterPhaseRunningNcclTests => onClusterPhaseRunningNcclTests(),
            _ when this == ClusterPhaseNcclTestsFailed => onClusterPhaseNcclTestsFailed(),
            _ when this == ClusterPhaseReady => onClusterPhaseReady(),
            _ when this == ClusterPhasePaused => onClusterPhasePaused(),
            _ when this == ClusterPhaseOnDemandComputePaused => onClusterPhaseOnDemandComputePaused(),
            _ when this == ClusterPhaseDegraded => onClusterPhaseDegraded(),
            _ when this == ClusterPhaseDeleting => onClusterPhaseDeleting(),
            _ => otherwise(Value)
        };

    public void Match(Action onClusterPhaseQueued,
        Action onClusterPhaseScheduled,
        Action onClusterPhaseWaitingForControlPlaneNodes,
        Action onClusterPhaseWaitingForDataPlaneNodes,
        Action onClusterPhaseWaitingForSubnet,
        Action onClusterPhaseWaitingForSharedVolume,
        Action onClusterPhaseWaitingForAutoScaler,
        Action onClusterPhaseInstallingDrivers,
        Action onClusterPhaseRunningAcceptanceTests,
        Action onClusterPhaseAcceptanceTestsFailed,
        Action onClusterPhaseRunningNcclTests,
        Action onClusterPhaseNcclTestsFailed,
        Action onClusterPhaseReady,
        Action onClusterPhasePaused,
        Action onClusterPhaseOnDemandComputePaused,
        Action onClusterPhaseDegraded,
        Action onClusterPhaseDeleting,
        Action<string> otherwise)
    {
        if (this == ClusterPhaseQueued) onClusterPhaseQueued();
        else if (this == ClusterPhaseScheduled) onClusterPhaseScheduled();
        else if (this == ClusterPhaseWaitingForControlPlaneNodes) onClusterPhaseWaitingForControlPlaneNodes();
        else if (this == ClusterPhaseWaitingForDataPlaneNodes) onClusterPhaseWaitingForDataPlaneNodes();
        else if (this == ClusterPhaseWaitingForSubnet) onClusterPhaseWaitingForSubnet();
        else if (this == ClusterPhaseWaitingForSharedVolume) onClusterPhaseWaitingForSharedVolume();
        else if (this == ClusterPhaseWaitingForAutoScaler) onClusterPhaseWaitingForAutoScaler();
        else if (this == ClusterPhaseInstallingDrivers) onClusterPhaseInstallingDrivers();
        else if (this == ClusterPhaseRunningAcceptanceTests) onClusterPhaseRunningAcceptanceTests();
        else if (this == ClusterPhaseAcceptanceTestsFailed) onClusterPhaseAcceptanceTestsFailed();
        else if (this == ClusterPhaseRunningNcclTests) onClusterPhaseRunningNcclTests();
        else if (this == ClusterPhaseNcclTestsFailed) onClusterPhaseNcclTestsFailed();
        else if (this == ClusterPhaseReady) onClusterPhaseReady();
        else if (this == ClusterPhasePaused) onClusterPhasePaused();
        else if (this == ClusterPhaseOnDemandComputePaused) onClusterPhaseOnDemandComputePaused();
        else if (this == ClusterPhaseDegraded) onClusterPhaseDegraded();
        else if (this == ClusterPhaseDeleting) onClusterPhaseDeleting();
        else otherwise(Value);
    }
}
