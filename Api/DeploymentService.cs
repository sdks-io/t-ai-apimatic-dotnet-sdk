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
using TogetherApIs.Models;
using TogetherApIs.Requests.DeploymentService;

namespace TogetherApIs.Api;

public sealed class DeploymentService
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DeploymentService(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a deployment adapter
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeAdapterEntry"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Attaches a LoRA adapter to a deployment. If the deployment is at adapter capacity, force can evict the oldest adapter.
    /// </remarks>
    public Task<DeAdapterEntry> DeploymentServiceAddAdapter(DeploymentServiceAddAdapterRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/deployments/{deploymentId}/adapters"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("deploymentId", request.DeploymentId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeAdapterEntry>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a deployment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeDeployment"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a model deployment under an endpoint. The deployment provisions asynchronously; monitor its status before routing live traffic to it.
    /// </remarks>
    public Task<DeDeployment> DeploymentServiceCreateDeployment(DeploymentServiceCreateDeploymentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/deployments"),
            [new TemplateParam("projectId", request.ProjectId), new TemplateParam("endpointId", request.EndpointId)],
            [new Param("validateOnly", request.ValidateOnly)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeDeployment>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete a deployment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Permanently deletes a deployment from its endpoint. Remove the deployment from live traffic first; use <c>etag</c> to reject the request if it changed after it was read.
    /// </remarks>
    public Task<object> DeploymentServiceDeleteDeployment(DeploymentServiceDeleteDeploymentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/deployments/{id}"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("id", request.Id),
            ],
            [new Param("etag", request.Etag)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a deployment adapter
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeAdapterEntry"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Gets an attached adapter and its per-cluster load state.
    /// </remarks>
    public Task<DeAdapterEntry> DeploymentServiceGetAdapter(DeploymentServiceGetAdapterRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/deployments/{deploymentId}/adapters/{id}"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("deploymentId", request.DeploymentId),
                new TemplateParam("id", request.Id),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeAdapterEntry>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a deployment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeDeployment"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a deployment's desired configuration, placement, runtime information, and current provisioning status.
    /// </remarks>
    public Task<DeDeployment> DeploymentServiceGetDeployment(DeploymentServiceGetDeploymentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/deployments/{id}"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("id", request.Id),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeDeployment>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List deployment adapters
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeListAdaptersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists LoRA adapters attached to a deployment with per-cluster load state.
    /// </remarks>
    public Task<DeListAdaptersResponse> DeploymentServiceListAdapters(DeploymentServiceListAdaptersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/deployments/{deploymentId}/adapters"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("deploymentId", request.DeploymentId),
            ],
            [new Param("limit", request.Limit), new Param("after", request.After)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeListAdaptersResponse>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List deployments
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeListDeploymentsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the deployments attached to an endpoint, including their model, configuration, scaling settings, placement, and current status.
    /// </remarks>
    public Task<DeListDeploymentsResponse> DeploymentServiceListDeployments(DeploymentServiceListDeploymentsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/deployments"),
            [new TemplateParam("projectId", request.ProjectId), new TemplateParam("endpointId", request.EndpointId)],
            [
                new Param("limit", request.Limit),
                new Param("after", request.After),
                new Param("orderBy", request.OrderBy),
                new Param("filter", request.Filter),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeListDeploymentsResponse>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Remove a deployment adapter
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Detaches an adapter from a deployment using its row-level etag for optimistic concurrency.
    /// </remarks>
    public Task<object> DeploymentServiceRemoveAdapter(DeploymentServiceRemoveAdapterRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/deployments/{deploymentId}/adapters/{id}"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("deploymentId", request.DeploymentId),
                new TemplateParam("id", request.Id),
            ],
            [new Param("etag", request.Etag)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a deployment adapter
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeAdapterEntry"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the pinned revision of an attached adapter using its row-level etag for optimistic concurrency.
    /// </remarks>
    public Task<DeAdapterEntry> DeploymentServiceUpdateAdapter(DeploymentServiceUpdateAdapterRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/deployments/{deploymentId}/adapters/{id}"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("deploymentId", request.DeploymentId),
                new TemplateParam("id", request.Id),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeAdapterEntry>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a deployment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeDeployment"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates mutable deployment fields such as its model, configuration, autoscaling bounds, or LoRA support. Changes that affect serving may trigger asynchronous reprovisioning.
    /// </remarks>
    public Task<DeDeployment> DeploymentServiceUpdateDeployment(DeploymentServiceUpdateDeploymentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/deployments/{id}"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("id", request.Id),
            ],
            [new Param("updateMask", request.UpdateMask)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeDeployment>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
