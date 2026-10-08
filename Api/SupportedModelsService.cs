using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TogetherApIs.Core;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Exceptions;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Request;
using TogetherApIs.Core.Response;
using TogetherApIs.Models;
using TogetherApIs.Requests.SupportedModelsService;

namespace TogetherApIs.Api;

public sealed class SupportedModelsService
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SupportedModelsService(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a supported model
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeSupportedModel"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a Together-hosted base model and the certified model, configuration, hardware, and performance profiles available for deployment.
    /// </remarks>
    public Task<DeSupportedModel> SupportedModelsServiceGetSupportedModel(SupportedModelsServiceGetSupportedModelRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/supported-models/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeSupportedModel>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List supported models
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeListSupportedModelsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists Together-hosted base models that can be deployed for dedicated inference, together with their capabilities and certified deployment profiles.
    /// </remarks>
    public Task<DeListSupportedModelsResponse> SupportedModelsServiceListSupportedModels(SupportedModelsServiceListSupportedModelsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/supported-models"),
            [],
            [
                new Param("modality", request.Modality),
                new Param("product", request.Product),
                new Param("search", request.Search),
                new Param("limit", request.Limit),
                new Param("after", request.After),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeListSupportedModelsResponse>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
