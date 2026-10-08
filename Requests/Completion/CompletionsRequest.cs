using TogetherApIs.Models;

namespace TogetherApIs.Requests.Completion;

/// <summary>
/// The inputs of the Completions operation.
/// </summary>
public sealed record CompletionsRequest
{
    public CompletionRequest? Body { get; init; }
}
