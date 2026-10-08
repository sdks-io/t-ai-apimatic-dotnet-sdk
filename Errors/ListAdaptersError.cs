using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;

namespace TogetherApIs.Errors;

public sealed class ListAdaptersError : ApiError
{
    private readonly Optional<ErrorData> _errorDataValue;

    private ListAdaptersError(Optional<ErrorData> errorDataValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorDataValue = errorDataValue;
    }

    private static ListAdaptersError AsErrorData(ErrorData value) => new(Optional<ErrorData>.Some(value), default);

    private static ListAdaptersError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorData(out ErrorData value) => _errorDataValue.TryGetValue(out value);

    private static Task<ListAdaptersError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            404 => response.Json<ErrorData>().As(AsErrorData),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<ListAdaptersError> Response { get; } = new(Create);
}
