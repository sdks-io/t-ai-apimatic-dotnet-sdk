using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(FunctionCall32Converter))]
public record FunctionCall32
{
    private readonly Optional<FunctionCall3> _functionCall3Value;

    private readonly Optional<FunctionCall31> _functionCall31Value;

    private FunctionCall32(Optional<FunctionCall3> functionCall3Value, Optional<FunctionCall31> functionCall31Value)
    {
        _functionCall3Value = functionCall3Value;
        _functionCall31Value = functionCall31Value;
    }

    public static FunctionCall32 FunctionCall3(FunctionCall3 value) =>
        new(Optional<FunctionCall3>.Some(value), default);

    public static FunctionCall32 FunctionCall31(FunctionCall31 value) =>
        new(default, Optional<FunctionCall31>.Some(value));

    public bool TryGetFunctionCall3(out FunctionCall3 value) => _functionCall3Value.TryGetValue(out value);

    public bool TryGetFunctionCall31(out FunctionCall31 value) => _functionCall31Value.TryGetValue(out value);

    public static implicit operator FunctionCall32(FunctionCall3 value) => FunctionCall3(value);

    public static implicit operator FunctionCall32(FunctionCall31 value) => FunctionCall31(value);
}

file sealed class FunctionCall32Converter : JsonConverter<FunctionCall32>
{
    public override FunctionCall32 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<FunctionCall3>(root, options, out var functionCall3Value))
        {
            return FunctionCall32.FunctionCall3(functionCall3Value);
        }
        if (JsonSerializer.TryDeserialize<FunctionCall31>(root, options, out var functionCall31Value))
        {
            return FunctionCall32.FunctionCall31(functionCall31Value);
        }
        throw new JsonException($"JSON does not match FunctionCall3 or FunctionCall31 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, FunctionCall32 value, JsonSerializerOptions options)
    {
        if (value.TryGetFunctionCall3(out var functionCall3Value))
        {
            JsonSerializer.Serialize(writer, functionCall3Value, options);
        }
        else if (value.TryGetFunctionCall31(out var functionCall31Value))
        {
            JsonSerializer.Serialize(writer, functionCall31Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(FunctionCall32)} contains no valid value to serialize.");
        }
    }
}
