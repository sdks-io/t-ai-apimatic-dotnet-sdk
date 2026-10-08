using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Metric must be QueueBacklogPerWorker
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Metric1>))]
public sealed record Metric1 : OpenStringEnum<Metric1>
{
    private Metric1(string value) : base(value)
    {
    }

    public static readonly Metric1 QueueBacklogPerWorker = new("QueueBacklogPerWorker");

    public TResult Match<TResult>(Func<TResult> onQueueBacklogPerWorker, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == QueueBacklogPerWorker => onQueueBacklogPerWorker(),
            _ => otherwise(Value)
        };

    public void Match(Action onQueueBacklogPerWorker, Action<string> otherwise)
    {
        if (this == QueueBacklogPerWorker) onQueueBacklogPerWorker();
        else otherwise(Value);
    }
}
