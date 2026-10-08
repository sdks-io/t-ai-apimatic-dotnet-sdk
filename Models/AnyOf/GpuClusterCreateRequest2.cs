using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// GPU Cluster create request
/// </summary>
[JsonConverter(typeof(GpuClusterCreateRequest2Converter))]
public record GpuClusterCreateRequest2
{
    private readonly Optional<GpuClusterCreateRequest> _gpuClusterCreateRequestValue;

    private readonly Optional<GpuClusterCreateRequest1> _gpuClusterCreateRequest1Value;

    private GpuClusterCreateRequest2(Optional<GpuClusterCreateRequest> gpuClusterCreateRequestValue,
        Optional<GpuClusterCreateRequest1> gpuClusterCreateRequest1Value)
    {
        _gpuClusterCreateRequestValue = gpuClusterCreateRequestValue;
        _gpuClusterCreateRequest1Value = gpuClusterCreateRequest1Value;
    }

    public static GpuClusterCreateRequest2 GpuClusterCreateRequest(GpuClusterCreateRequest value) =>
        new(Optional<GpuClusterCreateRequest>.Some(value), default);

    public static GpuClusterCreateRequest2 GpuClusterCreateRequest1(GpuClusterCreateRequest1 value) =>
        new(default, Optional<GpuClusterCreateRequest1>.Some(value));

    public bool TryGetGpuClusterCreateRequest(out GpuClusterCreateRequest value) =>
        _gpuClusterCreateRequestValue.TryGetValue(out value);

    public bool TryGetGpuClusterCreateRequest1(out GpuClusterCreateRequest1 value) =>
        _gpuClusterCreateRequest1Value.TryGetValue(out value);

    public static implicit operator GpuClusterCreateRequest2(GpuClusterCreateRequest value) =>
        GpuClusterCreateRequest(value);

    public static implicit operator GpuClusterCreateRequest2(GpuClusterCreateRequest1 value) =>
        GpuClusterCreateRequest1(value);
}

file sealed class GpuClusterCreateRequest2Converter : JsonConverter<GpuClusterCreateRequest2>
{
    public override GpuClusterCreateRequest2 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<GpuClusterCreateRequest>(root, options, out var gpuClusterCreateRequestValue))
        {
            return GpuClusterCreateRequest2.GpuClusterCreateRequest(gpuClusterCreateRequestValue);
        }
        if (JsonSerializer.TryDeserialize<GpuClusterCreateRequest1>(
            root,
            options,
            out var gpuClusterCreateRequest1Value))
        {
            return GpuClusterCreateRequest2.GpuClusterCreateRequest1(gpuClusterCreateRequest1Value);
        }
        throw new JsonException(
            $"JSON does not match GpuClusterCreateRequest or GpuClusterCreateRequest1 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, GpuClusterCreateRequest2 value, JsonSerializerOptions options)
    {
        if (value.TryGetGpuClusterCreateRequest(out var gpuClusterCreateRequestValue))
        {
            JsonSerializer.Serialize(writer, gpuClusterCreateRequestValue, options);
        }
        else if (value.TryGetGpuClusterCreateRequest1(out var gpuClusterCreateRequest1Value))
        {
            JsonSerializer.Serialize(writer, gpuClusterCreateRequest1Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(GpuClusterCreateRequest2)} contains no valid value to serialize.");
        }
    }
}
