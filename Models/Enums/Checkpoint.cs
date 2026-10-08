using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Canonical artifact selector for checkpoint download requests.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Checkpoint>))]
public sealed record Checkpoint : OpenStringEnum<Checkpoint>
{
    private Checkpoint(string value) : base(value)
    {
    }

    public static readonly Checkpoint Model = new("model");

    public static readonly Checkpoint Adapter = new("adapter");

    public TResult Match<TResult>(Func<TResult> onModel, Func<TResult> onAdapter, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Model => onModel(),
            _ when this == Adapter => onAdapter(),
            _ => otherwise(Value)
        };

    public void Match(Action onModel, Action onAdapter, Action<string> otherwise)
    {
        if (this == Model) onModel();
        else if (this == Adapter) onAdapter();
        else otherwise(Value);
    }
}
