using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Source of the judge model inference: - <c>serverless</c>: Together's shared serverless inference API. Default concurrency: 25 workers. - <c>dedicated</c>: A Together dedicated deployment endpoint. Default concurrency: 5 workers
///   (minimum enforced even if num_workers is set lower).
/// - <c>external</c>: An external inference API (e.g. OpenAI, Anthropic, Google, OpenRouter).
///   Requires <c>external_api_token</c> and <c>external_base_url</c>. Default concurrency: 2 workers
///   for first-party APIs, 20 for proxy/aggregator endpoints.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ModelSource>))]
public sealed record ModelSource : OpenStringEnum<ModelSource>
{
    private ModelSource(string value) : base(value)
    {
    }

    public static readonly ModelSource Serverless = new("serverless");

    public static readonly ModelSource Dedicated = new("dedicated");

    public static readonly ModelSource External = new("external");

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
