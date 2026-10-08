using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// The content of the message, which can either be a simple string or a structured format.
/// </summary>
[JsonConverter(typeof(ChatCompletionUserMessageContentConverter))]
public record ChatCompletionUserMessageContent
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<IReadOnlyList<ChatCompletionUserMessageContentMultimodal2>> _listOfChatCompletionUserMessageContentMultimodal2Value;

    private ChatCompletionUserMessageContent(Optional<string> stringValue,
        Optional<IReadOnlyList<ChatCompletionUserMessageContentMultimodal2>> listOfChatCompletionUserMessageContentMultimodal2Value)
    {
        _stringValue = stringValue;
        _listOfChatCompletionUserMessageContentMultimodal2Value =
            listOfChatCompletionUserMessageContentMultimodal2Value;
    }

    public static ChatCompletionUserMessageContent String(string value) => new(Optional<string>.Some(value), default);

    public static ChatCompletionUserMessageContent ListOfChatCompletionUserMessageContentMultimodal2(IReadOnlyList<ChatCompletionUserMessageContentMultimodal2> value) =>
        new(default, Optional<IReadOnlyList<ChatCompletionUserMessageContentMultimodal2>>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetListOfChatCompletionUserMessageContentMultimodal2(out IReadOnlyList<ChatCompletionUserMessageContentMultimodal2> value) =>
        _listOfChatCompletionUserMessageContentMultimodal2Value.TryGetValue(out value);

    public static implicit operator ChatCompletionUserMessageContent(string value) => String(value);
}

file sealed class ChatCompletionUserMessageContentConverter : JsonConverter<ChatCompletionUserMessageContent>
{
    public override ChatCompletionUserMessageContent Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ChatCompletionUserMessageContent.String(value);
        }
        if (JsonSerializer.TryDeserialize<IReadOnlyList<ChatCompletionUserMessageContentMultimodal2>>(
            root,
            options,
            out var listOfChatCompletionUserMessageContentMultimodal2Value))
        {
            return ChatCompletionUserMessageContent.ListOfChatCompletionUserMessageContentMultimodal2(
                listOfChatCompletionUserMessageContentMultimodal2Value);
        }
        throw new JsonException(
            $"JSON does not match string or IReadOnlyList<ChatCompletionUserMessageContentMultimodal2> schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ChatCompletionUserMessageContent value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetListOfChatCompletionUserMessageContentMultimodal2(
            out var listOfChatCompletionUserMessageContentMultimodal2Value))
        {
            JsonSerializer.Serialize(writer, listOfChatCompletionUserMessageContentMultimodal2Value, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(ChatCompletionUserMessageContent)} contains no valid value to serialize.");
        }
    }
}
