using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;

namespace TogetherApIs.Errors;

public sealed class ModelsError : ApiError
{
    private readonly Optional<ErrorData> _errorDataValue;

    private ModelsError(Optional<ErrorData> errorDataValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorDataValue = errorDataValue;
    }

    private static ModelsError AsErrorData(ErrorData value) => new(Optional<ErrorData>.Some(value), default);

    private static ModelsError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorData(out ErrorData value) => _errorDataValue.TryGetValue(out value);

    private static Task<ModelsError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 404 or 429 or 504 => response.Json<ErrorData>().As(AsErrorData),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<ModelsError> Response { get; } = new(Create);
}
