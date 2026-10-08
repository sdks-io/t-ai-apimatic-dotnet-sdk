using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(Error2Converter))]
public record Error2
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<object> _anonymousObjectValue;

    private Error2(Optional<string> stringValue, Optional<object> anonymousObjectValue)
    {
        _stringValue = stringValue;
        _anonymousObjectValue = anonymousObjectValue;
    }

    public static Error2 String(string value) => new(Optional<string>.Some(value), default);

    public static Error2 AnonymousObject(object value) => new(default, Optional<object>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetAnonymousObject(out object value) => _anonymousObjectValue.TryGetValue(out value);

    public static implicit operator Error2(string value) => String(value);
}

file sealed class Error2Converter : JsonConverter<Error2>
{
    public override Error2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return Error2.String(value);
        }
        if (JsonSerializer.TryDeserialize<object>(root, options, out var anonymousObjectValue))
        {
            return Error2.AnonymousObject(anonymousObjectValue);
        }
        throw new JsonException($"JSON does not match string or object schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Error2 value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(Error2)} contains no valid value to serialize.");
        }
    }
}
