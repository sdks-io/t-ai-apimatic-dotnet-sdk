using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The type of the file
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FileType>))]
public sealed record FileType : OpenStringEnum<FileType>
{
    private FileType(string value) : base(value)
    {
    }

    public static readonly FileType Csv = new("csv");

    public static readonly FileType Jsonl = new("jsonl");

    public static readonly FileType Parquet = new("parquet");

    public TResult Match<TResult>(Func<TResult> onCsv,
        Func<TResult> onJsonl,
        Func<TResult> onParquet,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Csv => onCsv(),
            _ when this == Jsonl => onJsonl(),
            _ when this == Parquet => onParquet(),
            _ => otherwise(Value)
        };

    public void Match(Action onCsv, Action onJsonl, Action onParquet, Action<string> otherwise)
    {
        if (this == Csv) onCsv();
        else if (this == Jsonl) onJsonl();
        else if (this == Parquet) onParquet();
        else otherwise(Value);
    }
}
