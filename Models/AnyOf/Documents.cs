using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// List of documents, which can be either strings or objects.
/// </summary>
[JsonConverter(typeof(DocumentsConverter))]
public record Documents
{
    private readonly Optional<IReadOnlyList<object>> _listOfAnonymousObjectValue;

    private readonly Optional<IReadOnlyList<string>> _listOfStringValue;

    private Documents(Optional<IReadOnlyList<object>> listOfAnonymousObjectValue,
        Optional<IReadOnlyList<string>> listOfStringValue)
    {
        _listOfAnonymousObjectValue = listOfAnonymousObjectValue;
        _listOfStringValue = listOfStringValue;
    }

    public static Documents ListOfAnonymousObject(IReadOnlyList<object> value) =>
        new(Optional<IReadOnlyList<object>>.Some(value), default);

    public static Documents ListOfString(IReadOnlyList<string> value) =>
        new(default, Optional<IReadOnlyList<string>>.Some(value));

    public bool TryGetListOfAnonymousObject(out IReadOnlyList<object> value) =>
        _listOfAnonymousObjectValue.TryGetValue(out value);

    public bool TryGetListOfString(out IReadOnlyList<string> value) => _listOfStringValue.TryGetValue(out value);
}

file sealed class DocumentsConverter : JsonConverter<Documents>
{
    public override Documents Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<IReadOnlyList<object>>(root, options, out var listOfAnonymousObjectValue))
        {
            return Documents.ListOfAnonymousObject(listOfAnonymousObjectValue);
        }
        if (JsonSerializer.TryDeserialize<IReadOnlyList<string>>(root, options, out var listOfStringValue))
        {
            return Documents.ListOfString(listOfStringValue);
        }
        throw new JsonException(
            $"JSON does not match IReadOnlyList<object> or IReadOnlyList<string> schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Documents value, JsonSerializerOptions options)
    {
        if (value.TryGetListOfAnonymousObject(out var listOfAnonymousObjectValue))
        {
            JsonSerializer.Serialize(writer, listOfAnonymousObjectValue, options);
        }
        else if (value.TryGetListOfString(out var listOfStringValue))
        {
            JsonSerializer.Serialize(writer, listOfStringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Documents)} contains no valid value to serialize.");
        }
    }
}
