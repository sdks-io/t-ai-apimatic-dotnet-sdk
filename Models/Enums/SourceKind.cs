using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Output only. Whether this row describes the endpoint or one of its deployments.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SourceKind>))]
public sealed record SourceKind : OpenStringEnum<SourceKind>
{
    private SourceKind(string value) : base(value)
    {
    }

    public static readonly SourceKind SourceKindEndpoint = new("SOURCE_KIND_ENDPOINT");

    public static readonly SourceKind SourceKindDeployment = new("SOURCE_KIND_DEPLOYMENT");

    public TResult Match<TResult>(Func<TResult> onSourceKindEndpoint,
        Func<TResult> onSourceKindDeployment,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SourceKindEndpoint => onSourceKindEndpoint(),
            _ when this == SourceKindDeployment => onSourceKindDeployment(),
            _ => otherwise(Value)
        };

    public void Match(Action onSourceKindEndpoint, Action onSourceKindDeployment, Action<string> otherwise)
    {
        if (this == SourceKindEndpoint) onSourceKindEndpoint();
        else if (this == SourceKindDeployment) onSourceKindDeployment();
        else otherwise(Value);
    }
}
