using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Type is the content type (currently only "files" is supported which allows preloading files uploaded via Files API into the volume)
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type16>))]
public sealed record Type16 : OpenStringEnum<Type16>
{
    private Type16(string value) : base(value)
    {
    }

    public static readonly Type16 Files = new("files");

    public TResult Match<TResult>(Func<TResult> onFiles, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Files => onFiles(),
            _ => otherwise(Value)
        };

    public void Match(Action onFiles, Action<string> otherwise)
    {
        if (this == Files) onFiles();
        else otherwise(Value);
    }
}
