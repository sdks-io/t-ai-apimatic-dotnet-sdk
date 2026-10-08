using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TogetherApIs.Core;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Exceptions;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Request;
using TogetherApIs.Core.Response;
using TogetherApIs.Models;
using TogetherApIs.Requests.EndpointService;

namespace TogetherApIs.Api;

public sealed class EndpointService
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal EndpointService(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create an endpoint
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeEndpoint"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a stable, inference-addressable endpoint. Add one or more deployments and configure its traffic split before sending inference requests to the endpoint name.
    /// </remarks>
    public Task<DeEndpoint> EndpointServiceCreateEndpoint(EndpointServiceCreateEndpointRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints"),
            [new TemplateParam("projectId", request.ProjectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeEndpoint>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete an endpoint
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Permanently deletes an endpoint. Delete its deployments first; use <c>etag</c> to reject the request if the endpoint changed after it was read.
    /// </remarks>
    public Task<object> EndpointServiceDeleteEndpoint(EndpointServiceDeleteEndpointRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{id}"),
            [new TemplateParam("projectId", request.ProjectId), new TemplateParam("id", request.Id)],
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
    /// Get an endpoint
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeEndpoint"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves an endpoint and lightweight summaries of the deployments attached to it.
    /// </remarks>
    public Task<DeEndpoint> EndpointServiceGetEndpoint(EndpointServiceGetEndpointRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{id}"),
            [new TemplateParam("projectId", request.ProjectId), new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeEndpoint>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get endpoint analytics
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeAnalyticsData"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns aggregated request, token, latency, throughput, error, and resource-utilization metrics for an endpoint over a time range. Optionally includes time-series buckets and a per-deployment breakdown.
    /// </remarks>
    public Task<DeAnalyticsData> EndpointServiceGetEndpointAnalytics(EndpointServiceGetEndpointAnalyticsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{id}/analytics"),
            [new TemplateParam("projectId", request.ProjectId), new TemplateParam("id", request.Id)],
            [
                new Param("deploymentId", request.DeploymentId),
                new Param("startTime", request.StartTime?.ToIso8601()),
                new Param("endTime", request.EndTime?.ToIso8601()),
                new Param("includeTimeSeries", request.IncludeTimeSeries),
                new Param("granularity", request.Granularity),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeAnalyticsData>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List endpoint events
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeListEndpointEventsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists an endpoint's audit and lifecycle events newest first. The feed combines endpoint changes with provisioning, scaling, readiness, rollout, and other events from deployments under the endpoint.
    /// </remarks>
    public Task<DeListEndpointEventsResponse> EndpointServiceListEndpointEvents(EndpointServiceListEndpointEventsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{id}/events"),
            [new TemplateParam("projectId", request.ProjectId), new TemplateParam("id", request.Id)],
            [
                new Param("limit", request.Limit),
                new Param("after", request.After),
                new Param("types", request.Types),
                new Param("minLevel", request.MinLevel),
                new Param("since", request.Since?.ToIso8601()),
                new Param("until", request.Until?.ToIso8601()),
                new Param("deploymentIds", request.DeploymentIds),
                new Param("sourceKinds", request.SourceKinds),
                new Param("subjectId", request.SubjectId),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeListEndpointEventsResponse>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List endpoints
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeListEndpointsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the dedicated inference endpoints owned by the specified project.
    /// </remarks>
    public Task<DeListEndpointsResponse> EndpointServiceListEndpoints(EndpointServiceListEndpointsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints"),
            [new TemplateParam("projectId", request.ProjectId)],
            [
                new Param("limit", request.Limit),
                new Param("after", request.After),
                new Param("orderBy", request.OrderBy),
                new Param("filter", request.Filter),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeListEndpointsResponse>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List organization endpoints
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeListEndpointsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists endpoints shared with every project in the specified organization. Project-private and public endpoints are not included.
    /// </remarks>
    public Task<DeListEndpointsResponse> EndpointServiceListOrganizationEndpoints(EndpointServiceListOrganizationEndpointsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/organizations/{organizationId}/endpoints"),
            [new TemplateParam("organizationId", request.OrganizationId)],
            [
                new Param("limit", request.Limit),
                new Param("after", request.After),
                new Param("orderBy", request.OrderBy),
                new Param("filter", request.Filter),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeListEndpointsResponse>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List public endpoints
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeListPublicEndpointsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists endpoints that are publicly visible across Together projects.
    /// </remarks>
    public Task<DeListPublicEndpointsResponse> EndpointServiceListPublicEndpoints(EndpointServiceListPublicEndpointsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/public/endpoints"),
            [],
            [
                new Param("limit", request.Limit),
                new Param("after", request.After),
                new Param("orderBy", request.OrderBy),
                new Param("filter", request.Filter),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DeListPublicEndpointsResponse>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update an endpoint
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeEndpoint"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates mutable endpoint fields such as its endpoint string, visibility, or deployment traffic split. Use <c>updateMask</c> to select fields explicitly and <c>etag</c> in the request body for optimistic concurrency.
    /// </remarks>
    public Task<DeEndpoint> EndpointServiceUpdateEndpoint(EndpointServiceUpdateEndpointRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/projects/{projectId}/endpoints/{id}"),
            [new TemplateParam("projectId", request.ProjectId), new TemplateParam("id", request.Id)],
            [new Param("updateMask", request.UpdateMask)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeEndpoint>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
