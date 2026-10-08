using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Errors;

public sealed class GetMetricsError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetMetricsError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetMetricsError AsNoContent(RawError value) => new(Optional<RawError>.Some(value), default);

    private static GetMetricsError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    private static Task<GetMetricsError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 404 or 500 => response.RawBody().As(AsNoContent),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetMetricsError> Response { get; } = new(Create);
}
