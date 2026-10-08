using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Orchestration framework used to run replicas for this config.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DeploymentFramework>))]
public sealed record DeploymentFramework : OpenStringEnum<DeploymentFramework>
{
    private DeploymentFramework(string value) : base(value)
    {
    }

    public static readonly DeploymentFramework DeploymentFrameworkDefault = new("DEPLOYMENT_FRAMEWORK_DEFAULT");

    public static readonly DeploymentFramework DeploymentFrameworkRollouts = new("DEPLOYMENT_FRAMEWORK_ROLLOUTS");

    public static readonly DeploymentFramework DeploymentFrameworkLws = new("DEPLOYMENT_FRAMEWORK_LWS");

    public static readonly DeploymentFramework DeploymentFrameworkDynamo = new("DEPLOYMENT_FRAMEWORK_DYNAMO");

    public static readonly DeploymentFramework DeploymentFrameworkGrove = new("DEPLOYMENT_FRAMEWORK_GROVE");

    public TResult Match<TResult>(Func<TResult> onDeploymentFrameworkDefault,
        Func<TResult> onDeploymentFrameworkRollouts,
        Func<TResult> onDeploymentFrameworkLws,
        Func<TResult> onDeploymentFrameworkDynamo,
        Func<TResult> onDeploymentFrameworkGrove,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DeploymentFrameworkDefault => onDeploymentFrameworkDefault(),
            _ when this == DeploymentFrameworkRollouts => onDeploymentFrameworkRollouts(),
            _ when this == DeploymentFrameworkLws => onDeploymentFrameworkLws(),
            _ when this == DeploymentFrameworkDynamo => onDeploymentFrameworkDynamo(),
            _ when this == DeploymentFrameworkGrove => onDeploymentFrameworkGrove(),
            _ => otherwise(Value)
        };

    public void Match(Action onDeploymentFrameworkDefault,
        Action onDeploymentFrameworkRollouts,
        Action onDeploymentFrameworkLws,
        Action onDeploymentFrameworkDynamo,
        Action onDeploymentFrameworkGrove,
        Action<string> otherwise)
    {
        if (this == DeploymentFrameworkDefault) onDeploymentFrameworkDefault();
        else if (this == DeploymentFrameworkRollouts) onDeploymentFrameworkRollouts();
        else if (this == DeploymentFrameworkLws) onDeploymentFrameworkLws();
        else if (this == DeploymentFrameworkDynamo) onDeploymentFrameworkDynamo();
        else if (this == DeploymentFrameworkGrove) onDeploymentFrameworkGrove();
        else otherwise(Value);
    }
}
