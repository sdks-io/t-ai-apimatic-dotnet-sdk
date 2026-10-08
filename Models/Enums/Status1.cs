using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Catalog recommendation status for the model.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status1>))]
public sealed record Status1 : OpenStringEnum<Status1>
{
    private Status1(string value) : base(value)
    {
    }

    public static readonly Status1 SupportedModelStatusRecommended = new("SUPPORTED_MODEL_STATUS_RECOMMENDED");

    public static readonly Status1 SupportedModelStatusSupported = new("SUPPORTED_MODEL_STATUS_SUPPORTED");

    public static readonly Status1 SupportedModelStatusDeprecated = new("SUPPORTED_MODEL_STATUS_DEPRECATED");

    public static readonly Status1 SupportedModelStatusHidden = new("SUPPORTED_MODEL_STATUS_HIDDEN");

    public TResult Match<TResult>(Func<TResult> onSupportedModelStatusRecommended,
        Func<TResult> onSupportedModelStatusSupported,
        Func<TResult> onSupportedModelStatusDeprecated,
        Func<TResult> onSupportedModelStatusHidden,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SupportedModelStatusRecommended => onSupportedModelStatusRecommended(),
            _ when this == SupportedModelStatusSupported => onSupportedModelStatusSupported(),
            _ when this == SupportedModelStatusDeprecated => onSupportedModelStatusDeprecated(),
            _ when this == SupportedModelStatusHidden => onSupportedModelStatusHidden(),
            _ => otherwise(Value)
        };

    public void Match(Action onSupportedModelStatusRecommended,
        Action onSupportedModelStatusSupported,
        Action onSupportedModelStatusDeprecated,
        Action onSupportedModelStatusHidden,
        Action<string> otherwise)
    {
        if (this == SupportedModelStatusRecommended) onSupportedModelStatusRecommended();
        else if (this == SupportedModelStatusSupported) onSupportedModelStatusSupported();
        else if (this == SupportedModelStatusDeprecated) onSupportedModelStatusDeprecated();
        else if (this == SupportedModelStatusHidden) onSupportedModelStatusHidden();
        else otherwise(Value);
    }
}
