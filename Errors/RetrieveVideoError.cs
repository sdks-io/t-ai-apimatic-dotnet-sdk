using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Errors;

public sealed class RetrieveVideoError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private RetrieveVideoError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static RetrieveVideoError AsNoContent(RawError value) => new(Optional<RawError>.Some(value), default);

    private static RetrieveVideoError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    private static Task<RetrieveVideoError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 404 => response.RawBody().As(AsNoContent),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<RetrieveVideoError> Response { get; } = new(Create);
}
