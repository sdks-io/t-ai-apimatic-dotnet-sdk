using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Status12>))]
public sealed record Status12 : OpenStringEnum<Status12>
{
    private Status12(string value) : base(value)
    {
    }

    public static readonly Status12 ModelResourcesStatusPending = new("MODEL_RESOURCES_STATUS_PENDING");

    public static readonly Status12 ModelResourcesStatusCreating = new("MODEL_RESOURCES_STATUS_CREATING");

    public static readonly Status12 ModelResourcesStatusReady = new("MODEL_RESOURCES_STATUS_READY");

    public static readonly Status12 ModelResourcesStatusError = new("MODEL_RESOURCES_STATUS_ERROR");

    public static readonly Status12 ModelResourcesStatusStopped = new("MODEL_RESOURCES_STATUS_STOPPED");

    public static readonly Status12 ModelResourcesStatusStopping = new("MODEL_RESOURCES_STATUS_STOPPING");

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
