using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(InputConverter))]
public record Input
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<IReadOnlyList<string>> _listOfStringValue;

    private Input(Optional<string> stringValue, Optional<IReadOnlyList<string>> listOfStringValue)
    {
        _stringValue = stringValue;
        _listOfStringValue = listOfStringValue;
    }

    public static Input String(string value) => new(Optional<string>.Some(value), default);

    public static Input ListOfString(IReadOnlyList<string> value) =>
        new(default, Optional<IReadOnlyList<string>>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetListOfString(out IReadOnlyList<string> value) => _listOfStringValue.TryGetValue(out value);

    public static implicit operator Input(string value) => String(value);
}

file sealed class InputConverter : JsonConverter<Input>
{
    public override Input Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return Input.String(value);
        }
        if (JsonSerializer.TryDeserialize<IReadOnlyList<string>>(root, options, out var listOfStringValue))
        {
            return Input.ListOfString(listOfStringValue);
        }
        throw new JsonException($"JSON does not match string or IReadOnlyList<string> schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Input value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetListOfString(out var listOfStringValue))
        {
            JsonSerializer.Serialize(writer, listOfStringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Input)} contains no valid value to serialize.");
        }
    }
}
