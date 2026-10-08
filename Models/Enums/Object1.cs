using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The object type, which is always <c>completion.chunk</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Object1>))]
public sealed record Object1 : OpenStringEnum<Object1>
{
    private Object1(string value) : base(value)
    {
    }

    public static readonly Object1 CompletionChunk = new("completion.chunk");

    public TResult Match<TResult>(Func<TResult> onCompletionChunk, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CompletionChunk => onCompletionChunk(),
            _ => otherwise(Value)
        };

    public void Match(Action onCompletionChunk, Action<string> otherwise)
    {
        if (this == CompletionChunk) onCompletionChunk();
        else otherwise(Value);
    }
}
