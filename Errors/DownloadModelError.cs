using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Errors;

public sealed class DownloadModelError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private DownloadModelError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static DownloadModelError AsNoContent(RawError value) => new(Optional<RawError>.Some(value), default);

    private static DownloadModelError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    private static Task<DownloadModelError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 404 => response.RawBody().As(AsNoContent),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<DownloadModelError> Response { get; } = new(Create);
}
