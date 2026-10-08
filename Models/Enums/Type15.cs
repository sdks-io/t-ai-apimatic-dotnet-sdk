using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The type of evaluation
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type15>))]
public sealed record Type15 : OpenStringEnum<Type15>
{
    private Type15(string value) : base(value)
    {
    }

    public static readonly Type15 Classify = new("classify");

    public static readonly Type15 Score = new("score");

    public static readonly Type15 Compare = new("compare");

    public TResult Match<TResult>(Func<TResult> onClassify,
        Func<TResult> onScore,
        Func<TResult> onCompare,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Classify => onClassify(),
            _ when this == Score => onScore(),
            _ when this == Compare => onCompare(),
            _ => otherwise(Value)
        };

    public void Match(Action onClassify, Action onScore, Action onCompare, Action<string> otherwise)
    {
        if (this == Classify) onClassify();
        else if (this == Score) onScore();
        else if (this == Compare) onCompare();
        else otherwise(Value);
    }
}
