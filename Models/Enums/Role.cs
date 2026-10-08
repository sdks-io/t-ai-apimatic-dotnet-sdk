using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Role of this deployment within the A/B experiment.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Role>))]
public sealed record Role : OpenStringEnum<Role>
{
    private Role(string value) : base(value)
    {
    }

    public static readonly Role AbExperimentMemberRoleControl = new("AB_EXPERIMENT_MEMBER_ROLE_CONTROL");

    public static readonly Role AbExperimentMemberRoleVariant = new("AB_EXPERIMENT_MEMBER_ROLE_VARIANT");

    public TResult Match<TResult>(Func<TResult> onAbExperimentMemberRoleControl,
        Func<TResult> onAbExperimentMemberRoleVariant,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AbExperimentMemberRoleControl => onAbExperimentMemberRoleControl(),
            _ when this == AbExperimentMemberRoleVariant => onAbExperimentMemberRoleVariant(),
            _ => otherwise(Value)
        };

    public void Match(Action onAbExperimentMemberRoleControl,
        Action onAbExperimentMemberRoleVariant,
        Action<string> otherwise)
    {
        if (this == AbExperimentMemberRoleControl) onAbExperimentMemberRoleControl();
        else if (this == AbExperimentMemberRoleVariant) onAbExperimentMemberRoleVariant();
        else otherwise(Value);
    }
}
