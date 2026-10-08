using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Speculative decoding mechanism for speculator weights.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SpeculatorMechanism>))]
public sealed record SpeculatorMechanism : OpenStringEnum<SpeculatorMechanism>
{
    private SpeculatorMechanism(string value) : base(value)
    {
    }

    public static readonly SpeculatorMechanism SpeculatorMechanismDraft = new("SPECULATOR_MECHANISM_DRAFT");

    public static readonly SpeculatorMechanism SpeculatorMechanismLookahead = new("SPECULATOR_MECHANISM_LOOKAHEAD");

    public static readonly SpeculatorMechanism SpeculatorMechanismMtp = new("SPECULATOR_MECHANISM_MTP");

    public TResult Match<TResult>(Func<TResult> onSpeculatorMechanismDraft,
        Func<TResult> onSpeculatorMechanismLookahead,
        Func<TResult> onSpeculatorMechanismMtp,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SpeculatorMechanismDraft => onSpeculatorMechanismDraft(),
            _ when this == SpeculatorMechanismLookahead => onSpeculatorMechanismLookahead(),
            _ when this == SpeculatorMechanismMtp => onSpeculatorMechanismMtp(),
            _ => otherwise(Value)
        };

    public void Match(Action onSpeculatorMechanismDraft,
        Action onSpeculatorMechanismLookahead,
        Action onSpeculatorMechanismMtp,
        Action<string> otherwise)
    {
        if (this == SpeculatorMechanismDraft) onSpeculatorMechanismDraft();
        else if (this == SpeculatorMechanismLookahead) onSpeculatorMechanismLookahead();
        else if (this == SpeculatorMechanismMtp) onSpeculatorMechanismMtp();
        else otherwise(Value);
    }
}
