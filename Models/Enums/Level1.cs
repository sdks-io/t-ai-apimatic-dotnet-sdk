using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Output only. Severity level.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Level1>))]
public sealed record Level1 : OpenStringEnum<Level1>
{
    private Level1(string value) : base(value)
    {
    }

    public static readonly Level1 LevelDebug = new("LEVEL_DEBUG");

    public static readonly Level1 LevelInfo = new("LEVEL_INFO");

    public static readonly Level1 LevelWarn = new("LEVEL_WARN");

    public static readonly Level1 LevelError = new("LEVEL_ERROR");

    public TResult Match<TResult>(Func<TResult> onLevelDebug,
        Func<TResult> onLevelInfo,
        Func<TResult> onLevelWarn,
        Func<TResult> onLevelError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == LevelDebug => onLevelDebug(),
            _ when this == LevelInfo => onLevelInfo(),
            _ when this == LevelWarn => onLevelWarn(),
            _ when this == LevelError => onLevelError(),
            _ => otherwise(Value)
        };

    public void Match(Action onLevelDebug,
        Action onLevelInfo,
        Action onLevelWarn,
        Action onLevelError,
        Action<string> otherwise)
    {
        if (this == LevelDebug) onLevelDebug();
        else if (this == LevelInfo) onLevelInfo();
        else if (this == LevelWarn) onLevelWarn();
        else if (this == LevelError) onLevelError();
        else otherwise(Value);
    }
}
