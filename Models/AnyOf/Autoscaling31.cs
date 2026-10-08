using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Autoscaling configuration. Example: {"metric": "QueueBacklogPerWorker", "target": 1.01} to scale based on queue backlog. Omit or set to null to disable autoscaling
/// </summary>
[JsonConverter(typeof(Autoscaling31Converter))]
public record Autoscaling31
{
    private readonly Optional<HttpAutoscalingConfig> _httpAutoscalingConfigValue;

    private readonly Optional<QueueAutoscalingConfig> _queueAutoscalingConfigValue;

    private readonly Optional<CustomMetricAutoscalingConfig> _customMetricAutoscalingConfigValue;

    private Autoscaling31(Optional<HttpAutoscalingConfig> httpAutoscalingConfigValue,
        Optional<QueueAutoscalingConfig> queueAutoscalingConfigValue,
        Optional<CustomMetricAutoscalingConfig> customMetricAutoscalingConfigValue)
    {
        _httpAutoscalingConfigValue = httpAutoscalingConfigValue;
        _queueAutoscalingConfigValue = queueAutoscalingConfigValue;
        _customMetricAutoscalingConfigValue = customMetricAutoscalingConfigValue;
    }

    public static Autoscaling31 HttpAutoscalingConfig(HttpAutoscalingConfig value) =>
        new(Optional<HttpAutoscalingConfig>.Some(value), default, default);

    public static Autoscaling31 QueueAutoscalingConfig(QueueAutoscalingConfig value) =>
        new(default, Optional<QueueAutoscalingConfig>.Some(value), default);

    public static Autoscaling31 CustomMetricAutoscalingConfig(CustomMetricAutoscalingConfig value) =>
        new(default, default, Optional<CustomMetricAutoscalingConfig>.Some(value));

    public bool TryGetHttpAutoscalingConfig(out HttpAutoscalingConfig value) =>
        _httpAutoscalingConfigValue.TryGetValue(out value);

    public bool TryGetQueueAutoscalingConfig(out QueueAutoscalingConfig value) =>
        _queueAutoscalingConfigValue.TryGetValue(out value);

    public bool TryGetCustomMetricAutoscalingConfig(out CustomMetricAutoscalingConfig value) =>
        _customMetricAutoscalingConfigValue.TryGetValue(out value);

    public static implicit operator Autoscaling31(HttpAutoscalingConfig value) => HttpAutoscalingConfig(value);

    public static implicit operator Autoscaling31(QueueAutoscalingConfig value) => QueueAutoscalingConfig(value);

    public static implicit operator Autoscaling31(CustomMetricAutoscalingConfig value) =>
        CustomMetricAutoscalingConfig(value);
}

file sealed class Autoscaling31Converter : JsonConverter<Autoscaling31>
{
    public override Autoscaling31 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<HttpAutoscalingConfig>(root, options, out var httpAutoscalingConfigValue))
        {
            return Autoscaling31.HttpAutoscalingConfig(httpAutoscalingConfigValue);
        }
        if (JsonSerializer.TryDeserialize<QueueAutoscalingConfig>(root, options, out var queueAutoscalingConfigValue))
        {
            return Autoscaling31.QueueAutoscalingConfig(queueAutoscalingConfigValue);
        }
        if (JsonSerializer.TryDeserialize<CustomMetricAutoscalingConfig>(
            root,
            options,
            out var customMetricAutoscalingConfigValue))
        {
            return Autoscaling31.CustomMetricAutoscalingConfig(customMetricAutoscalingConfigValue);
        }
        throw new JsonException(
            $"JSON does not match HttpAutoscalingConfig or QueueAutoscalingConfig or CustomMetricAutoscalingConfig schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Autoscaling31 value, JsonSerializerOptions options)
    {
        if (value.TryGetHttpAutoscalingConfig(out var httpAutoscalingConfigValue))
        {
            JsonSerializer.Serialize(writer, httpAutoscalingConfigValue, options);
        }
        else if (value.TryGetQueueAutoscalingConfig(out var queueAutoscalingConfigValue))
        {
            JsonSerializer.Serialize(writer, queueAutoscalingConfigValue, options);
        }
        else if (value.TryGetCustomMetricAutoscalingConfig(out var customMetricAutoscalingConfigValue))
        {
            JsonSerializer.Serialize(writer, customMetricAutoscalingConfigValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Autoscaling31)} contains no valid value to serialize.");
        }
    }
}
