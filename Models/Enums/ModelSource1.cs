using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Source of the model inference: - <c>serverless</c>: Together's shared serverless inference API. Default concurrency: 25 workers. - <c>dedicated</c>: A Together dedicated deployment endpoint. Default concurrency: 5 workers
///   (minimum enforced even if num_workers is set lower). Authentication uses the requesting
///   user's Together API token automatically.
/// - <c>external</c>: An external inference API (e.g. OpenAI, Anthropic, Google, OpenRouter).
///   Requires <c>external_api_token</c> and <c>external_base_url</c>. Default concurrency: 2 workers
///   for first-party APIs (OpenAI, Anthropic, Google), 20 for proxy/aggregator endpoints.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ModelSource1>))]
public sealed record ModelSource1 : OpenStringEnum<ModelSource1>
{
    private ModelSource1(string value) : base(value)
    {
    }

    public static readonly ModelSource1 Serverless = new("serverless");

    public static readonly ModelSource1 Dedicated = new("dedicated");

    public static readonly ModelSource1 External = new("external");

    public TResult Match<TResult>(Func<TResult> onServerless,
        Func<TResult> onDedicated,
        Func<TResult> onExternal,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Serverless => onServerless(),
            _ when this == Dedicated => onDedicated(),
            _ when this == External => onExternal(),
            _ => otherwise(Value)
        };

    public void Match(Action onServerless, Action onDedicated, Action onExternal, Action<string> otherwise)
    {
        if (this == Serverless) onServerless();
        else if (this == Dedicated) onDedicated();
        else if (this == External) onExternal();
        else otherwise(Value);
    }
}
