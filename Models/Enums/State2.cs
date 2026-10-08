using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Current adapter load state in this cluster.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<State2>))]
public sealed record State2 : OpenStringEnum<State2>
{
    private State2(string value) : base(value)
    {
    }

    public static readonly State2 AdapterLoadStatePending = new("ADAPTER_LOAD_STATE_PENDING");

    public static readonly State2 AdapterLoadStateLoading = new("ADAPTER_LOAD_STATE_LOADING");

    public static readonly State2 AdapterLoadStateReady = new("ADAPTER_LOAD_STATE_READY");

    public static readonly State2 AdapterLoadStateRemoving = new("ADAPTER_LOAD_STATE_REMOVING");

    public static readonly State2 AdapterLoadStateFailed = new("ADAPTER_LOAD_STATE_FAILED");

    public TResult Match<TResult>(Func<TResult> onAdapterLoadStatePending,
        Func<TResult> onAdapterLoadStateLoading,
        Func<TResult> onAdapterLoadStateReady,
        Func<TResult> onAdapterLoadStateRemoving,
        Func<TResult> onAdapterLoadStateFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AdapterLoadStatePending => onAdapterLoadStatePending(),
            _ when this == AdapterLoadStateLoading => onAdapterLoadStateLoading(),
            _ when this == AdapterLoadStateReady => onAdapterLoadStateReady(),
            _ when this == AdapterLoadStateRemoving => onAdapterLoadStateRemoving(),
            _ when this == AdapterLoadStateFailed => onAdapterLoadStateFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onAdapterLoadStatePending,
        Action onAdapterLoadStateLoading,
        Action onAdapterLoadStateReady,
        Action onAdapterLoadStateRemoving,
        Action onAdapterLoadStateFailed,
        Action<string> otherwise)
    {
        if (this == AdapterLoadStatePending) onAdapterLoadStatePending();
        else if (this == AdapterLoadStateLoading) onAdapterLoadStateLoading();
        else if (this == AdapterLoadStateReady) onAdapterLoadStateReady();
        else if (this == AdapterLoadStateRemoving) onAdapterLoadStateRemoving();
        else if (this == AdapterLoadStateFailed) onAdapterLoadStateFailed();
        else otherwise(Value);
    }
}
