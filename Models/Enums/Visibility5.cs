using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Model visibility. Private means it is scoped to the project. Internal means it is scoped to the organization.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Visibility5>))]
public sealed record Visibility5 : OpenStringEnum<Visibility5>
{
    private Visibility5(string value) : base(value)
    {
    }

    public static readonly Visibility5 VisibilityPrivate = new("VISIBILITY_PRIVATE");

    public static readonly Visibility5 VisibilityInternal = new("VISIBILITY_INTERNAL");

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
