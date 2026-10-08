using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Metric gate evaluated during a rollout.
/// </summary>
[JsonConverter(typeof(DeMetricRule2Converter))]
public record DeMetricRule2
{
    private readonly Optional<DeMetricRule> _deMetricRuleValue;

    private readonly Optional<DeMetricRule1> _deMetricRule1Value;

    private DeMetricRule2(Optional<DeMetricRule> deMetricRuleValue, Optional<DeMetricRule1> deMetricRule1Value)
    {
        _deMetricRuleValue = deMetricRuleValue;
        _deMetricRule1Value = deMetricRule1Value;
    }

    public static DeMetricRule2 DeMetricRule(DeMetricRule value) => new(Optional<DeMetricRule>.Some(value), default);

    public static DeMetricRule2 DeMetricRule1(DeMetricRule1 value) => new(default, Optional<DeMetricRule1>.Some(value));

    public bool TryGetDeMetricRule(out DeMetricRule value) => _deMetricRuleValue.TryGetValue(out value);

    public bool TryGetDeMetricRule1(out DeMetricRule1 value) => _deMetricRule1Value.TryGetValue(out value);

    public static implicit operator DeMetricRule2(DeMetricRule value) => DeMetricRule(value);

    public static implicit operator DeMetricRule2(DeMetricRule1 value) => DeMetricRule1(value);
}

file sealed class DeMetricRule2Converter : JsonConverter<DeMetricRule2>
{
    public override DeMetricRule2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<DeMetricRule>(root, options, out var deMetricRuleValue))
        {
            return DeMetricRule2.DeMetricRule(deMetricRuleValue);
        }
        if (JsonSerializer.TryDeserialize<DeMetricRule1>(root, options, out var deMetricRule1Value))
        {
            return DeMetricRule2.DeMetricRule1(deMetricRule1Value);
        }
        throw new JsonException($"JSON does not match DeMetricRule or DeMetricRule1 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DeMetricRule2 value, JsonSerializerOptions options)
    {
        if (value.TryGetDeMetricRule(out var deMetricRuleValue))
        {
            JsonSerializer.Serialize(writer, deMetricRuleValue, options);
        }
        else if (value.TryGetDeMetricRule1(out var deMetricRule1Value))
        {
            JsonSerializer.Serialize(writer, deMetricRule1Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(DeMetricRule2)} contains no valid value to serialize.");
        }
    }
}
