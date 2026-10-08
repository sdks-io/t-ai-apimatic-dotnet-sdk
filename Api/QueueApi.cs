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
using TogetherApIs.Requests.QueueApi;

namespace TogetherApIs.Api;

public sealed class QueueApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal QueueApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Cancel a queued job
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="QueueCancelResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelQueueJobError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel a pending job. Only jobs in pending status can be canceled.
    /// Running jobs cannot be stopped. Returns the job status after the
    /// attempt. If the job is not pending, returns 409 with the current status
    /// unchanged.
    /// </remarks>
    public Task<QueueCancelResponse> CancelQueueJob(CancelQueueJobRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/queue/cancel"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<QueueCancelResponse>(),
            CancelQueueJobError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Clear a model's pending jobs
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="QueueClearResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="ClearQueueError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel all pending jobs for the given model. Running jobs are left untouched. Returns the number of jobs that were canceled.
    /// </remarks>
    public Task<QueueClearResponse> ClearQueue(ClearQueueRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/queue/clear"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<QueueClearResponse>(),
            ClearQueueError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get job status
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="QueueJobStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetQueueJobStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Poll the current status of a previously submitted job. Provide the request_id and model as query parameters.
    /// </remarks>
    public Task<QueueJobStatusResponse> GetQueueJobStatus(GetQueueJobStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/queue/status"),
            [],
            [new Param("request_id", request.RequestId), new Param("model", request.Model)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<QueueJobStatusResponse>(),
            GetQueueJobStatusError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get queue metrics
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="QueueMetricsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetQueueMetricsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get the current queue statistics for a model, including pending and running job counts.
    /// </remarks>
    public Task<QueueMetricsResponse> GetQueueMetrics(GetQueueMetricsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/queue/metrics"),
            [],
            [new Param("model", request.Model)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<QueueMetricsResponse>(),
            GetQueueMetricsError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Submit a queued job
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="QueueJobResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="SubmitQueueJobError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Submit a new job to the queue for asynchronous processing. Jobs are
    /// processed in strict priority order (higher priority first, FIFO within
    /// the same priority). Returns a request ID that can be used to poll status
    /// or cancel the job.
    /// </remarks>
    public Task<QueueJobResponse> SubmitQueueJob(SubmitQueueJobRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/queue/submit"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<QueueJobResponse>(),
            SubmitQueueJobError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
