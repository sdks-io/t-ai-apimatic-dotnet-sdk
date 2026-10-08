using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DeploymentStatus>))]
public sealed record DeploymentStatus : OpenStringEnum<DeploymentStatus>
{
    private DeploymentStatus(string value) : base(value)
    {
    }

    public static readonly DeploymentStatus DeploymentStatusUpdating = new("Updating");

    public static readonly DeploymentStatus DeploymentStatusScaling = new("Scaling");

    public static readonly DeploymentStatus DeploymentStatusReady = new("Ready");

    public static readonly DeploymentStatus DeploymentStatusFailed = new("Failed");

    public static readonly DeploymentStatus DeploymentStatusScaledToZero = new("ScaledToZero");

    public TResult Match<TResult>(Func<TResult> onDeploymentStatusUpdating,
        Func<TResult> onDeploymentStatusScaling,
        Func<TResult> onDeploymentStatusReady,
        Func<TResult> onDeploymentStatusFailed,
        Func<TResult> onDeploymentStatusScaledToZero,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DeploymentStatusUpdating => onDeploymentStatusUpdating(),
            _ when this == DeploymentStatusScaling => onDeploymentStatusScaling(),
            _ when this == DeploymentStatusReady => onDeploymentStatusReady(),
            _ when this == DeploymentStatusFailed => onDeploymentStatusFailed(),
            _ when this == DeploymentStatusScaledToZero => onDeploymentStatusScaledToZero(),
            _ => otherwise(Value)
        };

    public void Match(Action onDeploymentStatusUpdating,
        Action onDeploymentStatusScaling,
        Action onDeploymentStatusReady,
        Action onDeploymentStatusFailed,
        Action onDeploymentStatusScaledToZero,
        Action<string> otherwise)
    {
        if (this == DeploymentStatusUpdating) onDeploymentStatusUpdating();
        else if (this == DeploymentStatusScaling) onDeploymentStatusScaling();
        else if (this == DeploymentStatusReady) onDeploymentStatusReady();
        else if (this == DeploymentStatusFailed) onDeploymentStatusFailed();
        else if (this == DeploymentStatusScaledToZero) onDeploymentStatusScaledToZero();
        else otherwise(Value);
    }
}
