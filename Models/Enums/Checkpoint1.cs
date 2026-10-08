using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Specifies checkpoint type to download - <c>merged</c> vs <c>adapter</c>. This field is required if the checkpoint_step is not set.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Checkpoint1>))]
public sealed record Checkpoint1 : OpenStringEnum<Checkpoint1>
{
    private Checkpoint1(string value) : base(value)
    {
    }

    public static readonly Checkpoint1 Merged = new("merged");

    public static readonly Checkpoint1 Adapter = new("adapter");

    public static readonly Checkpoint1 ModelOutputPath = new("model_output_path");

    public TResult Match<TResult>(Func<TResult> onMerged,
        Func<TResult> onAdapter,
        Func<TResult> onModelOutputPath,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Merged => onMerged(),
            _ when this == Adapter => onAdapter(),
            _ when this == ModelOutputPath => onModelOutputPath(),
            _ => otherwise(Value)
        };

    public void Match(Action onMerged, Action onAdapter, Action onModelOutputPath, Action<string> otherwise)
    {
        if (this == Merged) onMerged();
        else if (this == Adapter) onAdapter();
        else if (this == ModelOutputPath) onModelOutputPath();
        else otherwise(Value);
    }
}
