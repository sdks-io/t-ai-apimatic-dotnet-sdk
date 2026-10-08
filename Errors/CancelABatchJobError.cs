using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;

namespace TogetherApIs.Errors;

public sealed class CancelABatchJobError : ApiError
{
    private readonly Optional<BatchErrorResponse> _batchErrorResponseValue;

    private CancelABatchJobError(Optional<BatchErrorResponse> batchErrorResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _batchErrorResponseValue = batchErrorResponseValue;
    }

    private static CancelABatchJobError AsBatchErrorResponse(BatchErrorResponse value) =>
        new(Optional<BatchErrorResponse>.Some(value), default);

    private static CancelABatchJobError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetBatchErrorResponse(out BatchErrorResponse value) =>
        _batchErrorResponseValue.TryGetValue(out value);

    private static Task<CancelABatchJobError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 500 => response.Json<BatchErrorResponse>().As(AsBatchErrorResponse),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<CancelABatchJobError> Response { get; } = new(Create);
}
