using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(ChatCompletionMessageParamConverter))]
public record ChatCompletionMessageParam
{
    private readonly Optional<ChatCompletionSystemMessageParam> _chatCompletionSystemMessageParamValue;

    private readonly Optional<ChatCompletionUserMessageParam> _chatCompletionUserMessageParamValue;

    private readonly Optional<ChatCompletionAssistantMessageParam> _chatCompletionAssistantMessageParamValue;

    private readonly Optional<ChatCompletionToolMessageParam> _chatCompletionToolMessageParamValue;

    private readonly Optional<ChatCompletionFunctionMessageParam> _chatCompletionFunctionMessageParamValue;

    private ChatCompletionMessageParam(Optional<ChatCompletionSystemMessageParam> chatCompletionSystemMessageParamValue,
        Optional<ChatCompletionUserMessageParam> chatCompletionUserMessageParamValue,
        Optional<ChatCompletionAssistantMessageParam> chatCompletionAssistantMessageParamValue,
        Optional<ChatCompletionToolMessageParam> chatCompletionToolMessageParamValue,
        Optional<ChatCompletionFunctionMessageParam> chatCompletionFunctionMessageParamValue)
    {
        _chatCompletionSystemMessageParamValue = chatCompletionSystemMessageParamValue;
        _chatCompletionUserMessageParamValue = chatCompletionUserMessageParamValue;
        _chatCompletionAssistantMessageParamValue = chatCompletionAssistantMessageParamValue;
        _chatCompletionToolMessageParamValue = chatCompletionToolMessageParamValue;
        _chatCompletionFunctionMessageParamValue = chatCompletionFunctionMessageParamValue;
    }

    public static ChatCompletionMessageParam ChatCompletionSystemMessageParam(ChatCompletionSystemMessageParam value) =>
        new(Optional<ChatCompletionSystemMessageParam>.Some(value), default, default, default, default);

    public static ChatCompletionMessageParam ChatCompletionUserMessageParam(ChatCompletionUserMessageParam value) =>
        new(default, Optional<ChatCompletionUserMessageParam>.Some(value), default, default, default);

    public static ChatCompletionMessageParam ChatCompletionAssistantMessageParam(ChatCompletionAssistantMessageParam value) =>
        new(default, default, Optional<ChatCompletionAssistantMessageParam>.Some(value), default, default);

    public static ChatCompletionMessageParam ChatCompletionToolMessageParam(ChatCompletionToolMessageParam value) =>
        new(default, default, default, Optional<ChatCompletionToolMessageParam>.Some(value), default);

    public static ChatCompletionMessageParam ChatCompletionFunctionMessageParam(ChatCompletionFunctionMessageParam value) =>
        new(default, default, default, default, Optional<ChatCompletionFunctionMessageParam>.Some(value));

    public bool TryGetChatCompletionSystemMessageParam(out ChatCompletionSystemMessageParam value) =>
        _chatCompletionSystemMessageParamValue.TryGetValue(out value);

    public bool TryGetChatCompletionUserMessageParam(out ChatCompletionUserMessageParam value) =>
        _chatCompletionUserMessageParamValue.TryGetValue(out value);

    public bool TryGetChatCompletionAssistantMessageParam(out ChatCompletionAssistantMessageParam value) =>
        _chatCompletionAssistantMessageParamValue.TryGetValue(out value);

    public bool TryGetChatCompletionToolMessageParam(out ChatCompletionToolMessageParam value) =>
        _chatCompletionToolMessageParamValue.TryGetValue(out value);

    public bool TryGetChatCompletionFunctionMessageParam(out ChatCompletionFunctionMessageParam value) =>
        _chatCompletionFunctionMessageParamValue.TryGetValue(out value);

    public static implicit operator ChatCompletionMessageParam(ChatCompletionSystemMessageParam value) =>
        ChatCompletionSystemMessageParam(value);

    public static implicit operator ChatCompletionMessageParam(ChatCompletionUserMessageParam value) =>
        ChatCompletionUserMessageParam(value);

    public static implicit operator ChatCompletionMessageParam(ChatCompletionAssistantMessageParam value) =>
        ChatCompletionAssistantMessageParam(value);

    public static implicit operator ChatCompletionMessageParam(ChatCompletionToolMessageParam value) =>
        ChatCompletionToolMessageParam(value);

    public static implicit operator ChatCompletionMessageParam(ChatCompletionFunctionMessageParam value) =>
        ChatCompletionFunctionMessageParam(value);
}

file sealed class ChatCompletionMessageParamConverter : JsonConverter<ChatCompletionMessageParam>
{
    public override ChatCompletionMessageParam Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ChatCompletionSystemMessageParam>(
            root,
            options,
            out var chatCompletionSystemMessageParamValue))
        {
            return ChatCompletionMessageParam.ChatCompletionSystemMessageParam(chatCompletionSystemMessageParamValue);
        }
        if (JsonSerializer.TryDeserialize<ChatCompletionUserMessageParam>(
            root,
            options,
            out var chatCompletionUserMessageParamValue))
        {
            return ChatCompletionMessageParam.ChatCompletionUserMessageParam(chatCompletionUserMessageParamValue);
        }
        if (JsonSerializer.TryDeserialize<ChatCompletionAssistantMessageParam>(
            root,
            options,
            out var chatCompletionAssistantMessageParamValue))
        {
            return ChatCompletionMessageParam.ChatCompletionAssistantMessageParam(
                chatCompletionAssistantMessageParamValue);
        }
        if (JsonSerializer.TryDeserialize<ChatCompletionToolMessageParam>(
            root,
            options,
            out var chatCompletionToolMessageParamValue))
        {
            return ChatCompletionMessageParam.ChatCompletionToolMessageParam(chatCompletionToolMessageParamValue);
        }
        if (JsonSerializer.TryDeserialize<ChatCompletionFunctionMessageParam>(
            root,
            options,
            out var chatCompletionFunctionMessageParamValue))
        {
            return ChatCompletionMessageParam.ChatCompletionFunctionMessageParam(
                chatCompletionFunctionMessageParamValue);
        }
        throw new JsonException(
            $"JSON does not match ChatCompletionSystemMessageParam or ChatCompletionUserMessageParam or ChatCompletionAssistantMessageParam or ChatCompletionToolMessageParam or ChatCompletionFunctionMessageParam schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ChatCompletionMessageParam value, JsonSerializerOptions options)
    {
        if (value.TryGetChatCompletionSystemMessageParam(out var chatCompletionSystemMessageParamValue))
        {
            JsonSerializer.Serialize(writer, chatCompletionSystemMessageParamValue, options);
        }
        else if (value.TryGetChatCompletionUserMessageParam(out var chatCompletionUserMessageParamValue))
        {
            JsonSerializer.Serialize(writer, chatCompletionUserMessageParamValue, options);
        }
        else if (value.TryGetChatCompletionAssistantMessageParam(out var chatCompletionAssistantMessageParamValue))
        {
            JsonSerializer.Serialize(writer, chatCompletionAssistantMessageParamValue, options);
        }
        else if (value.TryGetChatCompletionToolMessageParam(out var chatCompletionToolMessageParamValue))
        {
            JsonSerializer.Serialize(writer, chatCompletionToolMessageParamValue, options);
        }
        else if (value.TryGetChatCompletionFunctionMessageParam(out var chatCompletionFunctionMessageParamValue))
        {
            JsonSerializer.Serialize(writer, chatCompletionFunctionMessageParamValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ChatCompletionMessageParam)} contains no valid value to serialize.");
        }
    }
}
