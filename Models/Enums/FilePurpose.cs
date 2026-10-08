using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The purpose of the file
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FilePurpose>))]
public sealed record FilePurpose : OpenStringEnum<FilePurpose>
{
    private FilePurpose(string value) : base(value)
    {
    }

    public static readonly FilePurpose FineTune = new("fine-tune");

    public static readonly FilePurpose Eval = new("eval");

    public static readonly FilePurpose BatchApi = new("batch-api");

    public TResult Match<TResult>(Func<TResult> onFineTune,
        Func<TResult> onEval,
        Func<TResult> onBatchApi,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FineTune => onFineTune(),
            _ when this == Eval => onEval(),
            _ when this == BatchApi => onBatchApi(),
            _ => otherwise(Value)
        };

    public void Match(Action onFineTune, Action onEval, Action onBatchApi, Action<string> otherwise)
    {
        if (this == FineTune) onFineTune();
        else if (this == Eval) onEval();
        else if (this == BatchApi) onBatchApi();
        else otherwise(Value);
    }
}
