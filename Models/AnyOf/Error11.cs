using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(Error11Converter))]
public record Error11
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<object> _anonymousObjectValue;

    private Error11(Optional<string> stringValue, Optional<object> anonymousObjectValue)
    {
        _stringValue = stringValue;
        _anonymousObjectValue = anonymousObjectValue;
    }

    public static Error11 String(string value) => new(Optional<string>.Some(value), default);

    public static Error11 AnonymousObject(object value) => new(default, Optional<object>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetAnonymousObject(out object value) => _anonymousObjectValue.TryGetValue(out value);

    public static implicit operator Error11(string value) => String(value);
}

file sealed class Error11Converter : JsonConverter<Error11>
{
    public override Error11 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return Error11.String(value);
        }
        if (JsonSerializer.TryDeserialize<object>(root, options, out var anonymousObjectValue))
        {
            return Error11.AnonymousObject(anonymousObjectValue);
        }
        throw new JsonException($"JSON does not match string or object schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Error11 value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetAnonymousObject(out var anonymousObjectValue))
        {
            JsonSerializer.Serialize(writer, anonymousObjectValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Error11)} contains no valid value to serialize.");
        }
    }
}
