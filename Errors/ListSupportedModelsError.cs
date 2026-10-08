using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;

namespace TogetherApIs.Errors;

public sealed class ListSupportedModelsError : ApiError
{
    private readonly Optional<ErrorData> _errorDataValue;

    private ListSupportedModelsError(Optional<ErrorData> errorDataValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorDataValue = errorDataValue;
    }

    private static ListSupportedModelsError AsErrorData(ErrorData value) =>
        new(Optional<ErrorData>.Some(value), default);

    private static ListSupportedModelsError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorData(out ErrorData value) => _errorDataValue.TryGetValue(out value);

    private static Task<ListSupportedModelsError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            429 => response.Json<ErrorData>().As(AsErrorData),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<ListSupportedModelsError> Response { get; } = new(Create);
}
