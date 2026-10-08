using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Status of the execution. Currently only supports success.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status6>))]
public sealed record Status6 : OpenStringEnum<Status6>
{
    private Status6(string value) : base(value)
    {
    }

    public static readonly Status6 Success = new("success");

    public TResult Match<TResult>(Func<TResult> onSuccess, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Success => onSuccess(),
            _ => otherwise(Value)
        };

    public void Match(Action onSuccess, Action<string> otherwise)
    {
        if (this == Success) onSuccess();
        else otherwise(Value);
    }
}
