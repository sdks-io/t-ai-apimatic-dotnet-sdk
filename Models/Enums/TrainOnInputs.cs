using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TrainOnInputs>))]
public sealed record TrainOnInputs : OpenStringEnum<TrainOnInputs>
{
    private TrainOnInputs(string value) : base(value)
    {
    }

    public static readonly TrainOnInputs Auto = new("auto");

    public TResult Match<TResult>(Func<TResult> onAuto, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Auto => onAuto(),
            _ => otherwise(Value)
        };

    public void Match(Action onAuto, Action<string> otherwise)
    {
        if (this == Auto) onAuto();
        else otherwise(Value);
    }
}
