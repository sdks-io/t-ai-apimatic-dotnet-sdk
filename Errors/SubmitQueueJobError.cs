using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;

namespace TogetherApIs.Errors;

public sealed class SubmitQueueJobError : ApiError
{
    private readonly Optional<QueueError> _queueErrorValue;

    private SubmitQueueJobError(Optional<QueueError> queueErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _queueErrorValue = queueErrorValue;
    }

    private static SubmitQueueJobError AsQueueError(QueueError value) => new(Optional<QueueError>.Some(value), default);

    private static SubmitQueueJobError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetQueueError(out QueueError value) => _queueErrorValue.TryGetValue(out value);

    private static Task<SubmitQueueJobError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 500 => response.Json<QueueError>().As(AsQueueError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<SubmitQueueJobError> Response { get; } = new(Create);
}
