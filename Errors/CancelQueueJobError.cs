using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;

namespace TogetherApIs.Errors;

public sealed class CancelQueueJobError : ApiError
{
    private readonly Optional<QueueError> _queueErrorValue;

    private readonly Optional<QueueCancelResponse> _queueCancelResponseValue;

    private CancelQueueJobError(Optional<QueueError> queueErrorValue,
        Optional<QueueCancelResponse> queueCancelResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _queueErrorValue = queueErrorValue;
        _queueCancelResponseValue = queueCancelResponseValue;
    }

    private static CancelQueueJobError AsQueueError(QueueError value) =>
        new(Optional<QueueError>.Some(value), default, default);

    private static CancelQueueJobError AsQueueCancelResponse(QueueCancelResponse value) =>
        new(default, Optional<QueueCancelResponse>.Some(value), default);

    private static CancelQueueJobError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetQueueError(out QueueError value) => _queueErrorValue.TryGetValue(out value);

    public bool TryGetQueueCancelResponse(out QueueCancelResponse value) =>
        _queueCancelResponseValue.TryGetValue(out value);

    private static Task<CancelQueueJobError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 404 or 500 => response.Json<QueueError>().As(AsQueueError),
            409 => response.Json<QueueCancelResponse>().As(AsQueueCancelResponse),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<CancelQueueJobError> Response { get; } = new(Create);
}
