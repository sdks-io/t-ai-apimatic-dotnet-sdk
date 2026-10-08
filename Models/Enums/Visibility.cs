using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Who can discover the endpoint. <c>VISIBILITY_PRIVATE</c> restricts it to the project; <c>VISIBILITY_INTERNAL</c> shares it with the organization.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Visibility>))]
public sealed record Visibility : OpenStringEnum<Visibility>
{
    private Visibility(string value) : base(value)
    {
    }

    public static readonly Visibility VisibilityPrivate = new("VISIBILITY_PRIVATE");

    public static readonly Visibility VisibilityInternal = new("VISIBILITY_INTERNAL");

    public TResult Match<TResult>(Func<TResult> onVisibilityPrivate,
        Func<TResult> onVisibilityInternal,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == VisibilityPrivate => onVisibilityPrivate(),
            _ when this == VisibilityInternal => onVisibilityInternal(),
            _ => otherwise(Value)
        };

    public void Match(Action onVisibilityPrivate, Action onVisibilityInternal, Action<string> otherwise)
    {
        if (this == VisibilityPrivate) onVisibilityPrivate();
        else if (this == VisibilityInternal) onVisibilityInternal();
        else otherwise(Value);
    }
}
