using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FinetuneEventLevels>))]
public sealed record FinetuneEventLevels : OpenStringEnum<FinetuneEventLevels>
{
    private FinetuneEventLevels(string value) : base(value)
    {
    }

    public static readonly FinetuneEventLevels Info = new("info");

    public static readonly FinetuneEventLevels Warning = new("warning");

    public static readonly FinetuneEventLevels Error = new("error");

    public static readonly FinetuneEventLevels LegacyInfo = new("legacy_info");

    public static readonly FinetuneEventLevels LegacyIwarning = new("legacy_iwarning");

    public static readonly FinetuneEventLevels LegacyIerror = new("legacy_ierror");

    public TResult Match<TResult>(Func<TResult> onInfo,
        Func<TResult> onWarning,
        Func<TResult> onError,
        Func<TResult> onLegacyInfo,
        Func<TResult> onLegacyIwarning,
        Func<TResult> onLegacyIerror,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Info => onInfo(),
            _ when this == Warning => onWarning(),
            _ when this == Error => onError(),
            _ when this == LegacyInfo => onLegacyInfo(),
            _ when this == LegacyIwarning => onLegacyIwarning(),
            _ when this == LegacyIerror => onLegacyIerror(),
            _ => otherwise(Value)
        };

    public void Match(Action onInfo,
        Action onWarning,
        Action onError,
        Action onLegacyInfo,
        Action onLegacyIwarning,
        Action onLegacyIerror,
        Action<string> otherwise)
    {
        if (this == Info) onInfo();
        else if (this == Warning) onWarning();
        else if (this == Error) onError();
        else if (this == LegacyInfo) onLegacyInfo();
        else if (this == LegacyIwarning) onLegacyIwarning();
        else if (this == LegacyIerror) onLegacyIerror();
        else otherwise(Value);
    }
}
