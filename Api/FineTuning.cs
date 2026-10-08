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
using TogetherApIs.Errors;
using TogetherApIs.Models;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Requests.FineTuning;

namespace TogetherApIs.Api;

public sealed class FineTuning
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal FineTuning(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Cancel job
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FinetuneResponseTruncated"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CancelJobError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel a currently running fine-tuning job. Returns a FinetuneResponseTruncated object.
    /// </remarks>
    public Task<FinetuneResponseTruncated> CancelJob(CancelJobRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fine-tunes/{id}/cancel"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<FinetuneResponseTruncated>(),
            CancelJobError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create job
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FinetuneResponseTruncated"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="CreateJobError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a fine-tuning job with the provided model and training data.
    /// </remarks>
    public Task<FinetuneResponseTruncated> CreateJob(CreateJobRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fine-tunes"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<FinetuneResponseTruncated>(),
            CreateJobError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete a fine-tune job
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FinetuneDeleteResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteAFineTuneJobError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a fine-tuning job.
    /// </remarks>
    public Task<FinetuneDeleteResponse> DeleteAFineTuneJob(DeleteAFineTuneJobRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fine-tunes/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("force", request.Force)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<FinetuneDeleteResponse>(),
            DeleteAFineTuneJobError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Download model
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BinaryContent"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DownloadModelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Receive a compressed fine-tuned model or checkpoint.
    /// </remarks>
    public Task<BinaryContent> DownloadModel(DownloadModelRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/finetune/download"),
            [],
            [
                new Param("ft_id", request.FtId),
                new Param("checkpoint_step", request.CheckpointStep),
                new Param("checkpoint", request.Checkpoint),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            BinaryResponse.Instance,
            DownloadModelError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Download tokenized dataset
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FineTuneTokenizedDatasetRetrieveResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DownloadTokenizedDatasetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get a presigned URL for the tokenized dataset archive generated for a fine-tune job.
    /// </remarks>
    public Task<FineTuneTokenizedDatasetRetrieveResponse> DownloadTokenizedDataset(DownloadTokenizedDatasetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fine-tunes/{id}/download-tokenized-dataset"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FineTuneTokenizedDatasetRetrieveResponse>(),
            DownloadTokenizedDatasetError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Estimate price
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FineTunesEstimatePriceResponse2"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="EstimatePriceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Estimate the price of a fine-tuning job.
    /// </remarks>
    public Task<FineTunesEstimatePriceResponse2> EstimatePrice(EstimatePriceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fine-tunes/estimate-price"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<FineTunesEstimatePriceResponse2>(),
            EstimatePriceError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List checkpoints
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FinetuneListCheckpoints"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List the checkpoints for a single fine-tuning job.
    /// </remarks>
    public Task<FinetuneListCheckpoints> GetFineTunesByIdByCheckpoints(GetFineTunesByIdByCheckpointsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fine-tunes/{id}/checkpoints"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FinetuneListCheckpoints>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List supported models
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FineTunesModelsSupportedResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List models supported for fine-tuning.
    /// </remarks>
    public Task<FineTunesModelsSupportedResponse> GetFineTunesModelsSupported(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fine-tunes/models/supported"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FineTunesModelsSupportedResponse>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get metrics
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FineTunesMetricsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMetricsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves recorded training metrics for a fine-tuning job in chronological order. All query parameters are optional: omit them to retrieve all metrics.
    /// </remarks>
    public Task<FineTunesMetricsResponse> GetMetrics(GetMetricsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fine-tunes/{id}/metrics"),
            [new TemplateParam("id", request.Id)],
            [
                new Param("global_step_from", request.GlobalStepFrom),
                new Param("global_step_to", request.GlobalStepTo),
                new Param("logged_at_from", request.LoggedAtFrom?.ToIso8601()),
                new Param("logged_at_to", request.LoggedAtTo?.ToIso8601()),
                new Param("resolution", request.Resolution),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FineTunesMetricsResponse>(),
            GetMetricsError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get model limits
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FineTuneModelLimits"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetModelLimitsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get model limits for a specific fine-tuning model.
    /// </remarks>
    public Task<FineTuneModelLimits> GetModelLimits(GetModelLimitsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fine-tunes/models/limits"),
            [],
            [new Param("model_name", request.ModelName)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FineTuneModelLimits>(),
            GetModelLimitsError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List all jobs
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FinetuneTruncatedList"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List the metadata for all fine-tuning jobs. Returns a list of FinetuneResponseTruncated objects.
    /// </remarks>
    public Task<FinetuneTruncatedList> ListAllJobs(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fine-tunes"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FinetuneTruncatedList>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List job
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FinetuneResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List the metadata for a single fine-tuning job.
    /// </remarks>
    public Task<FinetuneResponse> ListJob(ListJobRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fine-tunes/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FinetuneResponse>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List job events
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FinetuneListEvents"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List the events for a single fine-tuning job.
    /// </remarks>
    public Task<FinetuneListEvents> ListJobEvents(ListJobEventsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fine-tunes/{id}/events"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FinetuneListEvents>(),
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Preview tokenized data
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FineTunePreviewResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PreviewTokenizedDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Preview how sampled rows from a fine-tuning training file will be tokenized before packing.
    /// </remarks>
    public Task<FineTunePreviewResponse> PreviewTokenizedData(PreviewTokenizedDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fine-tunes/preview"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<FineTunePreviewResponse>(),
            PreviewTokenizedDataError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
