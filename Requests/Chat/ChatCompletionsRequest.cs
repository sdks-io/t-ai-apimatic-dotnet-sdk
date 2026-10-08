using TogetherApIs.Models;

namespace TogetherApIs.Requests.Chat;

/// <summary>
/// The inputs of the ChatCompletions operation.
/// </summary>
public sealed record ChatCompletionsRequest
{
    public ChatCompletionRequest? Body { get; init; }
}
