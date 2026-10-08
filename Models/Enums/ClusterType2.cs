using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Type of cluster to update.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ClusterType2>))]
public sealed record ClusterType2 : OpenStringEnum<ClusterType2>
{
    private ClusterType2(string value) : base(value)
    {
    }

    public static readonly ClusterType2 Kubernetes = new("KUBERNETES");

    public static readonly ClusterType2 Slurm = new("SLURM");

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
