using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;

namespace TogetherApIs.Errors;

public sealed class EstimatePriceError : ApiError
{
    private readonly Optional<ErrorData> _errorDataValue;

    private EstimatePriceError(Optional<ErrorData> errorDataValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorDataValue = errorDataValue;
    }

    private static EstimatePriceError AsErrorData(ErrorData value) => new(Optional<ErrorData>.Some(value), default);

    private static EstimatePriceError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorData(out ErrorData value) => _errorDataValue.TryGetValue(out value);

    private static Task<EstimatePriceError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            500 => response.Json<ErrorData>().As(AsErrorData),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<EstimatePriceError> Response { get; } = new(Create);
}
