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
using TogetherApIs.Requests.Embeddings;

namespace TogetherApIs.Api;

public sealed class Embeddings
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Embeddings(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create embedding
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EmbeddingsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="EmbeddingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Generate vector embeddings for one or more text inputs. Returns numerical arrays representing semantic meaning, useful for search, classification, and retrieval.
    /// </remarks>
    public Task<EmbeddingsResponse> EmbeddingsInvoke(EmbeddingsOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/embeddings"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<EmbeddingsResponse>(),
            EmbeddingsError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
