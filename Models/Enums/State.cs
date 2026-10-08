using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Current state of the deployment.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<State>))]
public sealed record State : OpenStringEnum<State>
{
    private State(string value) : base(value)
    {
    }

    public static readonly State DeploymentStateProvisioning = new("DEPLOYMENT_STATE_PROVISIONING");

    public static readonly State DeploymentStateReady = new("DEPLOYMENT_STATE_READY");

    public static readonly State DeploymentStateScaling = new("DEPLOYMENT_STATE_SCALING");

    public static readonly State DeploymentStateDegraded = new("DEPLOYMENT_STATE_DEGRADED");

    public static readonly State DeploymentStateFailed = new("DEPLOYMENT_STATE_FAILED");

    public static readonly State DeploymentStateStopped = new("DEPLOYMENT_STATE_STOPPED");

    public static readonly State DeploymentStateStopping = new("DEPLOYMENT_STATE_STOPPING");

    public TResult Match<TResult>(Func<TResult> onDeploymentStateProvisioning,
        Func<TResult> onDeploymentStateReady,
        Func<TResult> onDeploymentStateScaling,
        Func<TResult> onDeploymentStateDegraded,
        Func<TResult> onDeploymentStateFailed,
        Func<TResult> onDeploymentStateStopped,
        Func<TResult> onDeploymentStateStopping,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DeploymentStateProvisioning => onDeploymentStateProvisioning(),
            _ when this == DeploymentStateReady => onDeploymentStateReady(),
            _ when this == DeploymentStateScaling => onDeploymentStateScaling(),
            _ when this == DeploymentStateDegraded => onDeploymentStateDegraded(),
            _ when this == DeploymentStateFailed => onDeploymentStateFailed(),
            _ when this == DeploymentStateStopped => onDeploymentStateStopped(),
            _ when this == DeploymentStateStopping => onDeploymentStateStopping(),
            _ => otherwise(Value)
        };

    public void Match(Action onDeploymentStateProvisioning,
        Action onDeploymentStateReady,
        Action onDeploymentStateScaling,
        Action onDeploymentStateDegraded,
        Action onDeploymentStateFailed,
        Action onDeploymentStateStopped,
        Action onDeploymentStateStopping,
        Action<string> otherwise)
    {
        if (this == DeploymentStateProvisioning) onDeploymentStateProvisioning();
        else if (this == DeploymentStateReady) onDeploymentStateReady();
        else if (this == DeploymentStateScaling) onDeploymentStateScaling();
        else if (this == DeploymentStateDegraded) onDeploymentStateDegraded();
        else if (this == DeploymentStateFailed) onDeploymentStateFailed();
        else if (this == DeploymentStateStopped) onDeploymentStateStopped();
        else if (this == DeploymentStateStopping) onDeploymentStateStopping();
        else otherwise(Value);
    }
}
