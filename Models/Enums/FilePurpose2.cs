using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The purpose of the file as it was uploaded.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FilePurpose2>))]
public sealed record FilePurpose2 : OpenStringEnum<FilePurpose2>
{
    private FilePurpose2(string value) : base(value)
    {
    }

    public static readonly FilePurpose2 FineTune = new("fine-tune");

    public static readonly FilePurpose2 Eval = new("eval");

    public static readonly FilePurpose2 BatchApi = new("batch-api");

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
