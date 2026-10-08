using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Type of cluster.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ClusterType1>))]
public sealed record ClusterType1 : OpenStringEnum<ClusterType1>
{
    private ClusterType1(string value) : base(value)
    {
    }

    public static readonly ClusterType1 Kubernetes = new("KUBERNETES");

    public static readonly ClusterType1 Slurm = new("SLURM");

    public TResult Match<TResult>(Func<TResult> onKubernetes, Func<TResult> onSlurm, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Kubernetes => onKubernetes(),
            _ when this == Slurm => onSlurm(),
            _ => otherwise(Value)
        };

    public void Match(Action onKubernetes, Action onSlurm, Action<string> otherwise)
    {
        if (this == Kubernetes) onKubernetes();
        else if (this == Slurm) onSlurm();
        else otherwise(Value);
    }
}
