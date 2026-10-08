using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Required direction that indicates whether higher or lower metric values are worse.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Direction1>))]
public sealed record Direction1 : OpenStringEnum<Direction1>
{
    private Direction1(string value) : base(value)
    {
    }

    public static readonly Direction1 RegressionDirectionHigherIsWorse = new("REGRESSION_DIRECTION_HIGHER_IS_WORSE");

    public static readonly Direction1 RegressionDirectionLowerIsWorse = new("REGRESSION_DIRECTION_LOWER_IS_WORSE");

    public TResult Match<TResult>(Func<TResult> onRegressionDirectionHigherIsWorse,
        Func<TResult> onRegressionDirectionLowerIsWorse,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == RegressionDirectionHigherIsWorse => onRegressionDirectionHigherIsWorse(),
            _ when this == RegressionDirectionLowerIsWorse => onRegressionDirectionLowerIsWorse(),
            _ => otherwise(Value)
        };

    public void Match(Action onRegressionDirectionHigherIsWorse,
        Action onRegressionDirectionLowerIsWorse,
        Action<string> otherwise)
    {
        if (this == RegressionDirectionHigherIsWorse) onRegressionDirectionHigherIsWorse();
        else if (this == RegressionDirectionLowerIsWorse) onRegressionDirectionLowerIsWorse();
        else otherwise(Value);
    }
}
