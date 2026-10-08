using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Product or serving environment for which the combination was evaluated.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Target>))]
public sealed record Target : OpenStringEnum<Target>
{
    private Target(string value) : base(value)
    {
    }

    public static readonly Target CertificationTargetDeServerless = new("CERTIFICATION_TARGET_DE_SERVERLESS");

    public static readonly Target CertificationTargetMre = new("CERTIFICATION_TARGET_MRE");

    public TResult Match<TResult>(Func<TResult> onCertificationTargetDeServerless,
        Func<TResult> onCertificationTargetMre,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CertificationTargetDeServerless => onCertificationTargetDeServerless(),
            _ when this == CertificationTargetMre => onCertificationTargetMre(),
            _ => otherwise(Value)
        };

    public void Match(Action onCertificationTargetDeServerless,
        Action onCertificationTargetMre,
        Action<string> otherwise)
    {
        if (this == CertificationTargetDeServerless) onCertificationTargetDeServerless();
        else if (this == CertificationTargetMre) onCertificationTargetMre();
        else otherwise(Value);
    }
}
