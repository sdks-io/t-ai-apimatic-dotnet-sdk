using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Metric must be CustomMetric
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Metric2>))]
public sealed record Metric2 : OpenStringEnum<Metric2>
{
    private Metric2(string value) : base(value)
    {
    }

    public static readonly Metric2 CustomMetric = new("CustomMetric");

    public TResult Match<TResult>(Func<TResult> onCustomMetric, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CustomMetric => onCustomMetric(),
            _ => otherwise(Value)
        };

    public void Match(Action onCustomMetric, Action<string> otherwise)
    {
        if (this == CustomMetric) onCustomMetric();
        else otherwise(Value);
    }
}
