using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FunctionCall3>))]
public sealed record FunctionCall3 : OpenStringEnum<FunctionCall3>
{
    private FunctionCall3(string value) : base(value)
    {
    }

    public static readonly FunctionCall3 None = new("none");

    public static readonly FunctionCall3 Auto = new("auto");

    public TResult Match<TResult>(Func<TResult> onNone, Func<TResult> onAuto, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == None => onNone(),
            _ when this == Auto => onAuto(),
            _ => otherwise(Value)
        };

    public void Match(Action onNone, Action onAuto, Action<string> otherwise)
    {
        if (this == None) onNone();
        else if (this == Auto) onAuto();
        else otherwise(Value);
    }
}
