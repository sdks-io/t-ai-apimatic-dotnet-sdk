using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Lifecycle status of a model resource
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RlModelResourcesStatus>))]
public sealed record RlModelResourcesStatus : OpenStringEnum<RlModelResourcesStatus>
{
    private RlModelResourcesStatus(string value) : base(value)
    {
    }

    public static readonly RlModelResourcesStatus ModelResourcesStatusPending = new("MODEL_RESOURCES_STATUS_PENDING");

    public static readonly RlModelResourcesStatus ModelResourcesStatusCreating = new("MODEL_RESOURCES_STATUS_CREATING");

    public static readonly RlModelResourcesStatus ModelResourcesStatusReady = new("MODEL_RESOURCES_STATUS_READY");

    public static readonly RlModelResourcesStatus ModelResourcesStatusError = new("MODEL_RESOURCES_STATUS_ERROR");

    public static readonly RlModelResourcesStatus ModelResourcesStatusStopped = new("MODEL_RESOURCES_STATUS_STOPPED");

    public static readonly RlModelResourcesStatus ModelResourcesStatusStopping = new("MODEL_RESOURCES_STATUS_STOPPING");

    public TResult Match<TResult>(Func<TResult> onModelResourcesStatusPending,
        Func<TResult> onModelResourcesStatusCreating,
        Func<TResult> onModelResourcesStatusReady,
        Func<TResult> onModelResourcesStatusError,
        Func<TResult> onModelResourcesStatusStopped,
        Func<TResult> onModelResourcesStatusStopping,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ModelResourcesStatusPending => onModelResourcesStatusPending(),
            _ when this == ModelResourcesStatusCreating => onModelResourcesStatusCreating(),
            _ when this == ModelResourcesStatusReady => onModelResourcesStatusReady(),
            _ when this == ModelResourcesStatusError => onModelResourcesStatusError(),
            _ when this == ModelResourcesStatusStopped => onModelResourcesStatusStopped(),
            _ when this == ModelResourcesStatusStopping => onModelResourcesStatusStopping(),
            _ => otherwise(Value)
        };

    public void Match(Action onModelResourcesStatusPending,
        Action onModelResourcesStatusCreating,
        Action onModelResourcesStatusReady,
        Action onModelResourcesStatusError,
        Action onModelResourcesStatusStopped,
        Action onModelResourcesStatusStopping,
        Action<string> otherwise)
    {
        if (this == ModelResourcesStatusPending) onModelResourcesStatusPending();
        else if (this == ModelResourcesStatusCreating) onModelResourcesStatusCreating();
        else if (this == ModelResourcesStatusReady) onModelResourcesStatusReady();
        else if (this == ModelResourcesStatusError) onModelResourcesStatusError();
        else if (this == ModelResourcesStatusStopped) onModelResourcesStatusStopped();
        else if (this == ModelResourcesStatusStopping) onModelResourcesStatusStopping();
        else otherwise(Value);
    }
}
