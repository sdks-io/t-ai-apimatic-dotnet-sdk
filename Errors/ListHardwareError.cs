using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;

namespace TogetherApIs.Errors;

public sealed class ListHardwareError : ApiError
{
    private readonly Optional<ErrorData> _errorDataValue;

    private ListHardwareError(Optional<ErrorData> errorDataValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorDataValue = errorDataValue;
    }

    private static ListHardwareError AsErrorData(ErrorData value) => new(Optional<ErrorData>.Some(value), default);

    private static ListHardwareError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorData(out ErrorData value) => _errorDataValue.TryGetValue(out value);

    private static Task<ListHardwareError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            403 or 500 => response.Json<ErrorData>().As(AsErrorData),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<ListHardwareError> Response { get; } = new(Create);
}
