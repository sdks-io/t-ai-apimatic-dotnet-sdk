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
using TogetherApIs.Requests.RemediationService;

namespace TogetherApIs.Api;

public sealed class RemediationService
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal RemediationService(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Approves a pending remediation.
    /// <para>
    /// Only remediations with state PENDING_APPROVAL can be approved.
    /// </para>
    /// <para>
    /// On APPROVE: state changes to PENDING and the remediation process begins.
    /// The reviewed_by, review_time, and review_comment fields are populated
    /// on the remediation after approval.
    /// </para>
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Remediation"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<Remediation> RemediationServiceApproveRemediation(RemediationServiceApproveRemediationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default(
                "/compute/clusters/{cluster_id}/instances/{instance_id}/remediations/{remediation_id}/approve"),
            [
                new TemplateParam("cluster_id", request.ClusterId),
                new TemplateParam("instance_id", request.InstanceId),
                new TemplateParam("remediation_id", request.RemediationId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<Remediation>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cancels a pending remediation.
    /// <para>
    /// Only remediations in PENDING_APPROVAL or PENDING state can be cancelled.
    /// </para>
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Remediation"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<Remediation> RemediationServiceCancelRemediation(RemediationServiceCancelRemediationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default(
                "/compute/clusters/{cluster_id}/instances/{instance_id}/remediations/{remediation_id}/cancel"),
            [
                new TemplateParam("cluster_id", request.ClusterId),
                new TemplateParam("instance_id", request.InstanceId),
                new TemplateParam("remediation_id", request.RemediationId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<Remediation>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Creates a new remediation for an instance.
    /// <para>
    /// Remediations created via the API goes directly to PENDING state.
    /// </para>
    /// <para>
    /// Our system may trigger automated remediations that require approval. These remediations are created with PENDING_APPROVAL state.
    /// The user must call /approve to start the actual remediation process.
    /// These operations can also be rejected by calling /reject.
    /// </para>
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Remediation"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<Remediation> RemediationServiceCreateRemediation(RemediationServiceCreateRemediationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/compute/clusters/{cluster_id}/instances/{instance_id}/remediations"),
            [new TemplateParam("cluster_id", request.ClusterId), new TemplateParam("instance_id", request.InstanceId)],
            [new Param("remediation_id", request.RemediationId)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<Remediation>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Retrieve the status of a specific remdiation on a specific instance in a specific cluster.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Remediation"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<Remediation> RemediationServiceGetRemediation(RemediationServiceGetRemediationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/compute/clusters/{cluster_id}/instances/{instance_id}/remediations/{remediation_id}"),
            [
                new TemplateParam("cluster_id", request.ClusterId),
                new TemplateParam("instance_id", request.InstanceId),
                new TemplateParam("remediation_id", request.RemediationId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Remediation>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List remediations
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListRemediationsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists remediations for an instance or cluster.
    /// </remarks>
    public Task<ListRemediationsResponse> RemediationServiceListRemediations(RemediationServiceListRemediationsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/compute/clusters/{cluster_id}/instances/{instance_id}/remediations"),
            [new TemplateParam("cluster_id", request.ClusterId), new TemplateParam("instance_id", request.InstanceId)],
            [
                new Param("page_size", request.PageSize),
                new Param("page_token", request.PageToken),
                new Param("state", request.State),
                new Param("order_by", request.OrderBy),
                new Param("trigger", request.Trigger),
                new Param("mode", request.Mode),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListRemediationsResponse>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Rejects a pending remediation.
    /// <para>
    /// Only remediations with state PENDING_APPROVAL can be rejected.
    /// </para>
    /// <para>
    /// On REJECT: state changes to CANCELLED.
    /// The reviewed_by, review_time, and review_comment fields are populated
    /// on the remediation after rejection.
    /// </para>
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Remediation"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<Remediation> RemediationServiceRejectRemediation(RemediationServiceRejectRemediationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default(
                "/compute/clusters/{cluster_id}/instances/{instance_id}/remediations/{remediation_id}/reject"),
            [
                new TemplateParam("cluster_id", request.ClusterId),
                new TemplateParam("instance_id", request.InstanceId),
                new TemplateParam("remediation_id", request.RemediationId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<Remediation>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
