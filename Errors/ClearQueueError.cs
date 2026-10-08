using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;

namespace TogetherApIs.Errors;

public sealed class ClearQueueError : ApiError
{
    private readonly Optional<QueueError> _queueErrorValue;

    private ClearQueueError(Optional<QueueError> queueErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _queueErrorValue = queueErrorValue;
    }

    private static ClearQueueError AsQueueError(QueueError value) => new(Optional<QueueError>.Some(value), default);

    private static ClearQueueError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetQueueError(out QueueError value) => _queueErrorValue.TryGetValue(out value);

    private static Task<ClearQueueError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 500 => response.Json<QueueError>().As(AsQueueError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<ClearQueueError> Response { get; } = new(Create);
}
