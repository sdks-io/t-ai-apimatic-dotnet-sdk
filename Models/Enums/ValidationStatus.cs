using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Current validation status for the revision.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ValidationStatus>))]
public sealed record ValidationStatus : OpenStringEnum<ValidationStatus>
{
    private ValidationStatus(string value) : base(value)
    {
    }

    public static readonly ValidationStatus RevisionValidationStatusPending = new("REVISION_VALIDATION_STATUS_PENDING");

    public static readonly ValidationStatus RevisionValidationStatusSuccess = new("REVISION_VALIDATION_STATUS_SUCCESS");

    public static readonly ValidationStatus RevisionValidationStatusFailed = new("REVISION_VALIDATION_STATUS_FAILED");

    public static readonly ValidationStatus RevisionValidationStatusError = new("REVISION_VALIDATION_STATUS_ERROR");

    public TResult Match<TResult>(Func<TResult> onRevisionValidationStatusPending,
        Func<TResult> onRevisionValidationStatusSuccess,
        Func<TResult> onRevisionValidationStatusFailed,
        Func<TResult> onRevisionValidationStatusError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == RevisionValidationStatusPending => onRevisionValidationStatusPending(),
            _ when this == RevisionValidationStatusSuccess => onRevisionValidationStatusSuccess(),
            _ when this == RevisionValidationStatusFailed => onRevisionValidationStatusFailed(),
            _ when this == RevisionValidationStatusError => onRevisionValidationStatusError(),
            _ => otherwise(Value)
        };

    public void Match(Action onRevisionValidationStatusPending,
        Action onRevisionValidationStatusSuccess,
        Action onRevisionValidationStatusFailed,
        Action onRevisionValidationStatusError,
        Action<string> otherwise)
    {
        if (this == RevisionValidationStatusPending) onRevisionValidationStatusPending();
        else if (this == RevisionValidationStatusSuccess) onRevisionValidationStatusSuccess();
        else if (this == RevisionValidationStatusFailed) onRevisionValidationStatusFailed();
        else if (this == RevisionValidationStatusError) onRevisionValidationStatusError();
        else otherwise(Value);
    }
}
