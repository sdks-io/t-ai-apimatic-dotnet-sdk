using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Whether the model is a full model or an adapter
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ModelType>))]
public sealed record ModelType : OpenStringEnum<ModelType>
{
    private ModelType(string value) : base(value)
    {
    }

    public static readonly ModelType Model = new("model");

    public static readonly ModelType Adapter = new("adapter");

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
