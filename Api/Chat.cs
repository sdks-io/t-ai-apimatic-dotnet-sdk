using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TogetherApIs.Core;
using TogetherApIs.Core.Exceptions;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Request;
using TogetherApIs.Core.Response;
using TogetherApIs.Errors;
using TogetherApIs.Models;
using TogetherApIs.Requests.Chat;

namespace TogetherApIs.Api;

public sealed class Chat
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Chat(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create chat completion
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatCompletionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ChatCompletionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Generate a model response for a given chat conversation. Supports single queries and multi-turn conversations with system, user, and assistant messages.
    /// </remarks>
    public Task<ChatCompletionResponse> ChatCompletions(ChatCompletionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chat/completions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ChatCompletionResponse>(),
            ChatCompletionsError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
