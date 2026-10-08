using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TogetherApIs.Core;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Exceptions;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Request;
using TogetherApIs.Core.Response;
using TogetherApIs.Errors;
using TogetherApIs.Models;
using TogetherApIs.Requests.Endpoints;

namespace TogetherApIs.Api;

public sealed class Endpoints
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Endpoints(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a LoRA adapter to an endpoint
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EndpointsAdaptersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AddAdapterError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds a LoRA adapter model to a dedicated endpoint. After this call,
    /// inference requests to the adapter model name will be routed to the
    /// specified endpoint. The endpoint must have LoRA enabled, and the
    /// adapter's base model must be compatible with the endpoint's model.
    /// The endpoint name prefix in model_id must match the resolved endpoint.
    /// </remarks>
    public Task<EndpointsAdaptersResponse> AddAdapter(AddAdapterRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/endpoints/{endpointId}/adapters"),
            [new TemplateParam("endpointId", request.EndpointId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<EndpointsAdaptersResponse>(),
            AddAdapterError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List all available availability zones
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListAvailibilityZonesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all available availability zones.
    /// </remarks>
    public Task<ListAvailibilityZonesResponse> AvailabilityZones(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/clusters/availability-zones"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListAvailibilityZonesResponse>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a dedicated endpoint
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DedicatedEndpoint"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateEndpointError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new dedicated endpoint for serving models. The endpoint starts automatically after creation. You can deploy any supported model on hardware configurations that meet the model's requirements.
    /// </remarks>
    public Task<DedicatedEndpoint> CreateEndpoint(CreateEndpointOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/endpoints"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DedicatedEndpoint>(),
            CreateEndpointError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete endpoint
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteEndpointError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Permanently deletes an endpoint. This action cannot be undone.
    /// </remarks>
    public Task DeleteEndpoint(DeleteEndpointRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/endpoints/{endpointId}"),
            [new TemplateParam("endpointId", request.EndpointId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteEndpointError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get endpoint by ID
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DedicatedEndpoint"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEndpointError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves details about a specific endpoint, including its current state, configuration, and scaling settings.
    /// </remarks>
    public Task<DedicatedEndpoint> GetEndpoint(GetEndpointRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/endpoints/{endpointId}"),
            [new TemplateParam("endpointId", request.EndpointId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DedicatedEndpoint>(),
            GetEndpointError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List adapters on an endpoint
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EndpointsAdaptersResponse1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListAdaptersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns all LoRA adapters bound to the specified dedicated endpoint.
    /// </remarks>
    public Task<EndpointsAdaptersResponse1> ListAdapters(ListAdaptersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/endpoints/{endpointId}/adapters"),
            [new TemplateParam("endpointId", request.EndpointId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EndpointsAdaptersResponse1>(),
            ListAdaptersError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List all endpoints
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EndpointsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ListEndpointsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all endpoints associated with your account. You can filter the results by type (dedicated or serverless).
    /// </remarks>
    public Task<EndpointsResponse> ListEndpoints(ListEndpointsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/endpoints"),
            [],
            [
                new Param("type", request.Type),
                new Param("usage_type", request.UsageType),
                new Param("mine", request.Mine),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EndpointsResponse>(),
            ListEndpointsError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Remove a LoRA adapter from an endpoint
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EndpointsAdaptersResponse2"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RemoveAdapterError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes the routing rule that binds an adapter to an endpoint.
    /// The adapter must be currently bound to this specific endpoint.
    /// </remarks>
    public Task<EndpointsAdaptersResponse2> RemoveAdapter(RemoveAdapterRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/endpoints/{endpointId}/adapters"),
            [new TemplateParam("endpointId", request.EndpointId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<EndpointsAdaptersResponse2>(),
            RemoveAdapterError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update endpoint, this can also be used to start or stop a dedicated endpoint
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DedicatedEndpoint"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateEndpointError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates an existing endpoint's configuration. You can modify the display name, autoscaling settings, or change the endpoint's state (start/stop).
    /// </remarks>
    public Task<DedicatedEndpoint> UpdateEndpoint(UpdateEndpointRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/endpoints/{endpointId}"),
            [new TemplateParam("endpointId", request.EndpointId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DedicatedEndpoint>(),
            UpdateEndpointError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
