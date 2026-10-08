using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record AudioSpeechRequest
{
    /// <summary>
    /// The name of the model to query.&lt;br&gt; &lt;br&gt; <see href="https://docs.together.ai/docs/serverless-models#audio-models">See all of Together AI's chat models</see> The current supported tts models are: - cartesia/sonic - hexgrad/Kokoro-82M - canopylabs/orpheus-3b-0.1-ft
    /// </summary>
    [JsonPropertyName("model")]
    public required Model21 Model { get; init; }

    /// <summary>
    /// Input text to generate the audio for
    /// </summary>
    [JsonPropertyName("input")]
    public required string Input { get; init; }

    /// <summary>
    /// The voice to use for generating the audio. The voices supported are different for each model. For eg - for canopylabs/orpheus-3b-0.1-ft, one of the voices supported is tara, for hexgrad/Kokoro-82M, one of the voices supported is af_alloy and for cartesia/sonic, one of the voices supported is "friendly sidekick". &lt;br&gt; &lt;br&gt; You can view the voices supported for each model using the /v1/voices endpoint sending the model name as the query parameter. <see href="https://docs.together.ai/docs/text-to-speech#supported-voices">View all supported voices here</see>. &lt;br&gt; &lt;br&gt; <c>hexgrad/Kokoro-82M</c> additionally supports voice mixing, where two or more voices are combined into a single blended voice by joining their names with <c>+</c> (e.g. <c>af_bella+af_heart</c>). Optional per-voice weights can be provided in parentheses (e.g. <c>af_bella(2)+af_heart(1)</c>). Other models require a single voice name.
    /// </summary>
    [JsonPropertyName("voice")]
    public required string Voice { get; init; }

    /// <summary>
    /// The format of audio output. Supported formats are mp3, wav, raw if streaming is false. If streaming is true, the only supported format is raw.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response_format")]
    public ResponseFormat? ResponseFormat { get; init; } = ResponseFormat.Wav;

    /// <summary>
    /// Language or locale of input text. Accepts ISO 639-1 language codes (e.g., <c>en</c>, <c>fr</c>, <c>es</c>, <c>zh</c>) as well as locale codes for region-specific variants. Locale codes must be lowercase (e.g., <c>zh-hk</c> for Cantonese).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language")]
    public string? Language { get; init; } = "en";

    /// <summary>
    /// Audio encoding of response. Only applicable when response_format is raw or pcm. Cartesia models respect this parameter and support all values. Orpheus, Kokoro, and Minimax models always return pcm_s16le regardless of this setting.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response_encoding")]
    public ResponseEncoding? ResponseEncoding { get; init; } = ResponseEncoding.PcmF32Le;

    /// <summary>
    /// Sampling rate in Hz for the output audio. Cartesia and Minimax models respect this parameter. Orpheus and Kokoro models always output at 24000 Hz regardless of this setting.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sample_rate")]
    public int? SampleRate { get; init; } = 44100;

    /// <summary>
    /// Bitrate of the MP3 audio output in bits per second. Only applicable when response_format is mp3. Higher values produce better audio quality at larger file sizes. Default is 128000. Currently supported on Cartesia models.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bit_rate")]
    public BitRate? BitRate { get; init; } = BitRate.Value128000;

    /// <summary>
    /// If true, output is streamed for several characters at a time instead of waiting for the full response. The stream terminates with <c>data: [DONE]</c>. If false, return the encoded audio as octet stream
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stream")]
    public bool? Stream { get; init; } = false;

    /// <summary>
    /// Additional model-specific parameters that fine-tune speech generation behavior.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extra_params")]
    public ExtraParams? ExtraParams { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
