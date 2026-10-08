using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type8>))]
public sealed record Type8 : OpenStringEnum<Type8>
{
    private Type8(string value) : base(value)
    {
    }

    public static readonly Type8 DisplayData = new("display_data");

    public static readonly Type8 ExecuteResult = new("execute_result");

    public TResult Match<TResult>(Func<TResult> onDisplayData,
        Func<TResult> onExecuteResult,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DisplayData => onDisplayData(),
            _ when this == ExecuteResult => onExecuteResult(),
            _ => otherwise(Value)
        };

    public void Match(Action onDisplayData, Action onExecuteResult, Action<string> otherwise)
    {
        if (this == DisplayData) onDisplayData();
        else if (this == ExecuteResult) onExecuteResult();
        else otherwise(Value);
    }
}
