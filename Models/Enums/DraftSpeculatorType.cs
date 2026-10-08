using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Draft-model speculator family for draft speculative decoding.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DraftSpeculatorType>))]
public sealed record DraftSpeculatorType : OpenStringEnum<DraftSpeculatorType>
{
    private DraftSpeculatorType(string value) : base(value)
    {
    }

    public static readonly DraftSpeculatorType DraftSpeculatorTypeEagle = new("DRAFT_SPECULATOR_TYPE_EAGLE");

    public static readonly DraftSpeculatorType DraftSpeculatorTypePhoenix = new("DRAFT_SPECULATOR_TYPE_PHOENIX");

    public TResult Match<TResult>(Func<TResult> onDraftSpeculatorTypeEagle,
        Func<TResult> onDraftSpeculatorTypePhoenix,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DraftSpeculatorTypeEagle => onDraftSpeculatorTypeEagle(),
            _ when this == DraftSpeculatorTypePhoenix => onDraftSpeculatorTypePhoenix(),
            _ => otherwise(Value)
        };

    public void Match(Action onDraftSpeculatorTypeEagle, Action onDraftSpeculatorTypePhoenix, Action<string> otherwise)
    {
        if (this == DraftSpeculatorTypeEagle) onDraftSpeculatorTypeEagle();
        else if (this == DraftSpeculatorTypePhoenix) onDraftSpeculatorTypePhoenix();
        else otherwise(Value);
    }
}
