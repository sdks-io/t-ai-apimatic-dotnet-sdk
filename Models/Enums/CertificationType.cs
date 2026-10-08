using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Whether the model and config combination passed certification.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CertificationType>))]
public sealed record CertificationType : OpenStringEnum<CertificationType>
{
    private CertificationType(string value) : base(value)
    {
    }

    public static readonly CertificationType CertificationTypeCertified = new("CERTIFICATION_TYPE_CERTIFIED");

    public static readonly CertificationType CertificationTypeUncertified = new("CERTIFICATION_TYPE_UNCERTIFIED");

    public TResult Match<TResult>(Func<TResult> onCertificationTypeCertified,
        Func<TResult> onCertificationTypeUncertified,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CertificationTypeCertified => onCertificationTypeCertified(),
            _ when this == CertificationTypeUncertified => onCertificationTypeUncertified(),
            _ => otherwise(Value)
        };

    public void Match(Action onCertificationTypeCertified,
        Action onCertificationTypeUncertified,
        Action<string> otherwise)
    {
        if (this == CertificationTypeCertified) onCertificationTypeCertified();
        else if (this == CertificationTypeUncertified) onCertificationTypeUncertified();
        else otherwise(Value);
    }
}
