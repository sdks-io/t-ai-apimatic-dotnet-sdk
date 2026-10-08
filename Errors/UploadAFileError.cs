using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;

namespace TogetherApIs.Errors;

public sealed class UploadAFileError : ApiError
{
    private readonly Optional<ErrorData> _errorDataValue;

    private UploadAFileError(Optional<ErrorData> errorDataValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorDataValue = errorDataValue;
    }

    private static UploadAFileError AsErrorData(ErrorData value) => new(Optional<ErrorData>.Some(value), default);

    private static UploadAFileError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorData(out ErrorData value) => _errorDataValue.TryGetValue(out value);

    private static Task<UploadAFileError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 500 => response.Json<ErrorData>().As(AsErrorData),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<UploadAFileError> Response { get; } = new(Create);
}
