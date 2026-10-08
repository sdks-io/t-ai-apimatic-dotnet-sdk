using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Feature>))]
public sealed record Feature : OpenStringEnum<Feature>
{
    private Feature(string value) : base(value)
    {
    }

    public static readonly Feature FeatureToolCalling = new("FEATURE_TOOL_CALLING");

    public static readonly Feature FeatureStructuredOutput = new("FEATURE_STRUCTURED_OUTPUT");

    public static readonly Feature FeatureReasoning = new("FEATURE_REASONING");

    public TResult Match<TResult>(Func<TResult> onFeatureToolCalling,
        Func<TResult> onFeatureStructuredOutput,
        Func<TResult> onFeatureReasoning,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FeatureToolCalling => onFeatureToolCalling(),
            _ when this == FeatureStructuredOutput => onFeatureStructuredOutput(),
            _ when this == FeatureReasoning => onFeatureReasoning(),
            _ => otherwise(Value)
        };

    public void Match(Action onFeatureToolCalling,
        Action onFeatureStructuredOutput,
        Action onFeatureReasoning,
        Action<string> otherwise)
    {
        if (this == FeatureToolCalling) onFeatureToolCalling();
        else if (this == FeatureStructuredOutput) onFeatureStructuredOutput();
        else if (this == FeatureReasoning) onFeatureReasoning();
        else otherwise(Value);
    }
}
