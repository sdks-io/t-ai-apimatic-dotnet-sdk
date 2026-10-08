using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The type of the file such as <c>jsonl</c>, <c>csv</c>, or <c>parquet</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FileType2>))]
public sealed record FileType2 : OpenStringEnum<FileType2>
{
    private FileType2(string value) : base(value)
    {
    }

    public static readonly FileType2 Csv = new("csv");

    public static readonly FileType2 Jsonl = new("jsonl");

    public static readonly FileType2 Parquet = new("parquet");

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
