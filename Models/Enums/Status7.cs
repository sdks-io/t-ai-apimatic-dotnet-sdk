using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Initial status of the job
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status7>))]
public sealed record Status7 : OpenStringEnum<Status7>
{
    private Status7(string value) : base(value)
    {
    }

    public static readonly Status7 Pending = new("pending");

    public TResult Match<TResult>(Func<TResult> onPending, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending, Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else otherwise(Value);
    }
}
