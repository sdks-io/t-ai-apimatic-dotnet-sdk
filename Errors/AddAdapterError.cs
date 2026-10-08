using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;

namespace TogetherApIs.Errors;

public sealed class AddAdapterError : ApiError
{
    private readonly Optional<ErrorData> _errorDataValue;

    private AddAdapterError(Optional<ErrorData> errorDataValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorDataValue = errorDataValue;
    }

    private static AddAdapterError AsErrorData(ErrorData value) => new(Optional<ErrorData>.Some(value), default);

    private static AddAdapterError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorData(out ErrorData value) => _errorDataValue.TryGetValue(out value);

    private static Task<AddAdapterError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 403 or 404 => response.Json<ErrorData>().As(AsErrorData),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<AddAdapterError> Response { get; } = new(Create);
}
