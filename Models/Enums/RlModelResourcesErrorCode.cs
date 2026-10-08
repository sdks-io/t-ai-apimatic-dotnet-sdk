using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Finite machine-readable model resource lifecycle error code
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RlModelResourcesErrorCode>))]
public sealed record RlModelResourcesErrorCode : OpenStringEnum<RlModelResourcesErrorCode>
{
    private RlModelResourcesErrorCode(string value) : base(value)
    {
    }

    public static readonly RlModelResourcesErrorCode ModelResourcesErrorCodeCapacityWaitTimeout = new(
        "MODEL_RESOURCES_ERROR_CODE_CAPACITY_WAIT_TIMEOUT");

    public static readonly RlModelResourcesErrorCode ModelResourcesErrorCodeProvisioningFailed = new(
        "MODEL_RESOURCES_ERROR_CODE_PROVISIONING_FAILED");

    public static readonly RlModelResourcesErrorCode ModelResourcesErrorCodeResourceUnavailable = new(
        "MODEL_RESOURCES_ERROR_CODE_RESOURCE_UNAVAILABLE");

    public TResult Match<TResult>(Func<TResult> onModelResourcesErrorCodeCapacityWaitTimeout,
        Func<TResult> onModelResourcesErrorCodeProvisioningFailed,
        Func<TResult> onModelResourcesErrorCodeResourceUnavailable,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ModelResourcesErrorCodeCapacityWaitTimeout => onModelResourcesErrorCodeCapacityWaitTimeout(),
            _ when this == ModelResourcesErrorCodeProvisioningFailed => onModelResourcesErrorCodeProvisioningFailed(),
            _ when this == ModelResourcesErrorCodeResourceUnavailable => onModelResourcesErrorCodeResourceUnavailable(),
            _ => otherwise(Value)
        };

    public void Match(Action onModelResourcesErrorCodeCapacityWaitTimeout,
        Action onModelResourcesErrorCodeProvisioningFailed,
        Action onModelResourcesErrorCodeResourceUnavailable,
        Action<string> otherwise)
    {
        if (this == ModelResourcesErrorCodeCapacityWaitTimeout) onModelResourcesErrorCodeCapacityWaitTimeout();
        else if (this == ModelResourcesErrorCodeProvisioningFailed) onModelResourcesErrorCodeProvisioningFailed();
        else if (this == ModelResourcesErrorCodeResourceUnavailable) onModelResourcesErrorCodeResourceUnavailable();
        else otherwise(Value);
    }
}
