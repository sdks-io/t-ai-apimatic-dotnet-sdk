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
using TogetherApIs.Requests.RolloutService;

namespace TogetherApIs.Api;

public sealed class RolloutService
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal RolloutService(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Cancel a rollout
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeRollout"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels a running, pausing, paused, system-paused, or stabilizing rollout by freezing the current traffic split into standing weights. Revert is removed and rejected; after canceling, start another canary rollout in either direction or rebalance the traffic split. The response is the accepted rollout snapshot; poll GetRollout until it reaches CANCELED.
    /// </remarks>
    public Task<DeRollout> RolloutServiceCancelRollout(RolloutServiceCancelRolloutRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/rollouts/{id}/cancel"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("id", request.Id),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeRollout>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a rollout
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeRollout"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a rollout in the pending state without shifting traffic. Start the rollout in a separate request after reviewing its strategy and metric gates.
    /// </remarks>
    public Task<DeRollout> RolloutServiceCreateRollout(RolloutServiceCreateRolloutRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/rollouts"),
            [new TemplateParam("projectId", request.ProjectId), new TemplateParam("endpointId", request.EndpointId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeRollout>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete a rollout
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a rollout record. An active rollout must be aborted or completed before it can be deleted.
    /// </remarks>
    public Task<object> RolloutServiceDeleteRollout(RolloutServiceDeleteRolloutRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/rollouts/{id}"),
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
    /// Get a rollout
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeRollout"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a rollout's strategy, lifecycle state, current traffic percentage, step history, and metric-gate results.
    /// </remarks>
    public Task<DeRollout> RolloutServiceGetRollout(RolloutServiceGetRolloutRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/rollouts/{id}"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("id", request.Id),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeRollout>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List endpoint rollouts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeListRolloutsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists rollout histories for an endpoint. Use <c>filter=ROLLOUT_FILTER_ACTIVE</c> to return only the active rollout, if one exists.
    /// </remarks>
    public Task<DeListRolloutsResponse> RolloutServiceListRollouts(RolloutServiceListRolloutsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/rollouts"),
            [new TemplateParam("projectId", request.ProjectId), new TemplateParam("endpointId", request.EndpointId)],
            [new Param("limit", request.Limit), new Param("after", request.After), new Param("filter", request.Filter)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeListRolloutsResponse>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Pause a rollout
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeRollout"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Requests a running or stabilizing rollout to pause and records an optional reason. The response returns the PAUSING snapshot; poll GetRollout until state is PAUSED to confirm the executor has parked.
    /// </remarks>
    public Task<DeRollout> RolloutServicePauseRollout(RolloutServicePauseRolloutRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/rollouts/{id}/pause"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("id", request.Id),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeRollout>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Preview rollout defaults
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeRolloutDefaultsPreview"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the values a create request would pick for any field left unset, plus the capacity context needed to display them, without creating a rollout. Responses are display state only and re-validated authoritatively at create and start; do not copy response values back into a create request.
    /// </remarks>
    public Task<DeRolloutDefaultsPreview> RolloutServicePreviewRolloutDefaults(RolloutServicePreviewRolloutDefaultsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/rollouts/preview-defaults"),
            [new TemplateParam("projectId", request.ProjectId), new TemplateParam("endpointId", request.EndpointId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeRolloutDefaultsPreview>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Promote a rollout
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeRollout"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Completes a running or paused rollout immediately by sending all live traffic to the target deployment.
    /// </remarks>
    public Task<DeRollout> RolloutServicePromoteRollout(RolloutServicePromoteRolloutRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/rollouts/{id}/promote"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("id", request.Id),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeRollout>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Resume a rollout
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeRollout"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Resumes a pausing, paused, or system-paused rollout from its current step and traffic split.
    /// </remarks>
    public Task<DeRollout> RolloutServiceResumeRollout(RolloutServiceResumeRolloutRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/rollouts/{id}/resume"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("id", request.Id),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeRollout>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Start a rollout
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeRollout"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Starts a pending rollout and begins its configured traffic-shifting workflow.
    /// </remarks>
    public Task<DeRollout> RolloutServiceStartRollout(RolloutServiceStartRolloutRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{endpointId}/rollouts/{id}/start"),
            [
                new TemplateParam("projectId", request.ProjectId),
                new TemplateParam("endpointId", request.EndpointId),
                new TemplateParam("id", request.Id),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<DeRollout>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
