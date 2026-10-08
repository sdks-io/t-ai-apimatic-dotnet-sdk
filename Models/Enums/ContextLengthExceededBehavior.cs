using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Defines the behavior of the API when max_tokens exceed the maximum context length of the model. When set to 'error', the API returns 400 with an appropriate error message. When set to 'truncate', overrides max_tokens with the maximum context length of the model.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ContextLengthExceededBehavior>))]
public sealed record ContextLengthExceededBehavior : OpenStringEnum<ContextLengthExceededBehavior>
{
    private ContextLengthExceededBehavior(string value) : base(value)
    {
    }

    public static readonly ContextLengthExceededBehavior Truncate = new("truncate");

    public static readonly ContextLengthExceededBehavior Error = new("error");

    public TResult Match<TResult>(Func<TResult> onTruncate, Func<TResult> onError, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Truncate => onTruncate(),
            _ when this == Error => onError(),
            _ => otherwise(Value)
        };

    public void Match(Action onTruncate, Action onError, Action<string> otherwise)
    {
        if (this == Truncate) onTruncate();
        else if (this == Error) onError();
        else otherwise(Value);
    }
}
