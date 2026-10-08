using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(ChatCompletionUserMessageContentMultimodal2Converter))]
public record ChatCompletionUserMessageContentMultimodal2
{
    private readonly Optional<ChatCompletionUserMessageContentMultimodal> _chatCompletionUserMessageContentMultimodalValue;

    private readonly Optional<ChatCompletionUserMessageContentMultimodal1> _chatCompletionUserMessageContentMultimodal1Value;

    private readonly Optional<Video> _videoValue;

    private readonly Optional<Audio> _audioValue;

    private readonly Optional<InputAudio> _inputAudioValue;

    private ChatCompletionUserMessageContentMultimodal2(Optional<ChatCompletionUserMessageContentMultimodal> chatCompletionUserMessageContentMultimodalValue,
        Optional<ChatCompletionUserMessageContentMultimodal1> chatCompletionUserMessageContentMultimodal1Value,
        Optional<Video> videoValue,
        Optional<Audio> audioValue,
        Optional<InputAudio> inputAudioValue)
    {
        _chatCompletionUserMessageContentMultimodalValue = chatCompletionUserMessageContentMultimodalValue;
        _chatCompletionUserMessageContentMultimodal1Value = chatCompletionUserMessageContentMultimodal1Value;
        _videoValue = videoValue;
        _audioValue = audioValue;
        _inputAudioValue = inputAudioValue;
    }

    public static ChatCompletionUserMessageContentMultimodal2 ChatCompletionUserMessageContentMultimodal(ChatCompletionUserMessageContentMultimodal value) =>
        new(Optional<ChatCompletionUserMessageContentMultimodal>.Some(value), default, default, default, default);

    public static ChatCompletionUserMessageContentMultimodal2 ChatCompletionUserMessageContentMultimodal1(ChatCompletionUserMessageContentMultimodal1 value) =>
        new(default, Optional<ChatCompletionUserMessageContentMultimodal1>.Some(value), default, default, default);

    public static ChatCompletionUserMessageContentMultimodal2 Video(Video value) =>
        new(default, default, Optional<Video>.Some(value), default, default);

    public static ChatCompletionUserMessageContentMultimodal2 Audio(Audio value) =>
        new(default, default, default, Optional<Audio>.Some(value), default);

    public static ChatCompletionUserMessageContentMultimodal2 InputAudio(InputAudio value) =>
        new(default, default, default, default, Optional<InputAudio>.Some(value));

    public bool TryGetChatCompletionUserMessageContentMultimodal(out ChatCompletionUserMessageContentMultimodal value) =>
        _chatCompletionUserMessageContentMultimodalValue.TryGetValue(out value);

    public bool TryGetChatCompletionUserMessageContentMultimodal1(out ChatCompletionUserMessageContentMultimodal1 value) =>
        _chatCompletionUserMessageContentMultimodal1Value.TryGetValue(out value);

    public bool TryGetVideo(out Video value) => _videoValue.TryGetValue(out value);

    public bool TryGetAudio(out Audio value) => _audioValue.TryGetValue(out value);

    public bool TryGetInputAudio(out InputAudio value) => _inputAudioValue.TryGetValue(out value);

    public static implicit operator ChatCompletionUserMessageContentMultimodal2(ChatCompletionUserMessageContentMultimodal value) =>
        ChatCompletionUserMessageContentMultimodal(value);

    public static implicit operator ChatCompletionUserMessageContentMultimodal2(ChatCompletionUserMessageContentMultimodal1 value) =>
        ChatCompletionUserMessageContentMultimodal1(value);

    public static implicit operator ChatCompletionUserMessageContentMultimodal2(Video value) => Video(value);

    public static implicit operator ChatCompletionUserMessageContentMultimodal2(Audio value) => Audio(value);

    public static implicit operator ChatCompletionUserMessageContentMultimodal2(InputAudio value) => InputAudio(value);
}

file sealed class ChatCompletionUserMessageContentMultimodal2Converter : JsonConverter<ChatCompletionUserMessageContentMultimodal2>
{
    public override ChatCompletionUserMessageContentMultimodal2 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ChatCompletionUserMessageContentMultimodal>(
            root,
            options,
            out var chatCompletionUserMessageContentMultimodalValue))
        {
            return ChatCompletionUserMessageContentMultimodal2.ChatCompletionUserMessageContentMultimodal(
                chatCompletionUserMessageContentMultimodalValue);
        }
        if (JsonSerializer.TryDeserialize<ChatCompletionUserMessageContentMultimodal1>(
            root,
            options,
            out var chatCompletionUserMessageContentMultimodal1Value))
        {
            return ChatCompletionUserMessageContentMultimodal2.ChatCompletionUserMessageContentMultimodal1(
                chatCompletionUserMessageContentMultimodal1Value);
        }
        if (JsonSerializer.TryDeserialize<Video>(root, options, out var videoValue))
        {
            return ChatCompletionUserMessageContentMultimodal2.Video(videoValue);
        }
        if (JsonSerializer.TryDeserialize<Audio>(root, options, out var audioValue))
        {
            return ChatCompletionUserMessageContentMultimodal2.Audio(audioValue);
        }
        if (JsonSerializer.TryDeserialize<InputAudio>(root, options, out var inputAudioValue))
        {
            return ChatCompletionUserMessageContentMultimodal2.InputAudio(inputAudioValue);
        }
        throw new JsonException(
            $"JSON does not match ChatCompletionUserMessageContentMultimodal or ChatCompletionUserMessageContentMultimodal1 or Video or Audio or InputAudio schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ChatCompletionUserMessageContentMultimodal2 value,
        JsonSerializerOptions options)
    {
        if (value.TryGetChatCompletionUserMessageContentMultimodal(
            out var chatCompletionUserMessageContentMultimodalValue))
        {
            JsonSerializer.Serialize(writer, chatCompletionUserMessageContentMultimodalValue, options);
        }
        else if (value.TryGetChatCompletionUserMessageContentMultimodal1(
            out var chatCompletionUserMessageContentMultimodal1Value))
        {
            JsonSerializer.Serialize(writer, chatCompletionUserMessageContentMultimodal1Value, options);
        }
        else if (value.TryGetVideo(out var videoValue))
        {
            JsonSerializer.Serialize(writer, videoValue, options);
        }
        else if (value.TryGetAudio(out var audioValue))
        {
            JsonSerializer.Serialize(writer, audioValue, options);
        }
        else if (value.TryGetInputAudio(out var inputAudioValue))
        {
            JsonSerializer.Serialize(writer, inputAudioValue, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(ChatCompletionUserMessageContentMultimodal2)} contains no valid value to serialize.");
        }
    }
}
