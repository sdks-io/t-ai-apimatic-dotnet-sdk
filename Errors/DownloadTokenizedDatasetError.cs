using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;

namespace TogetherApIs.Errors;

public sealed class DownloadTokenizedDatasetError : ApiError
{
    private readonly Optional<ErrorData> _errorDataValue;

    private DownloadTokenizedDatasetError(Optional<ErrorData> errorDataValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorDataValue = errorDataValue;
    }

    private static DownloadTokenizedDatasetError AsErrorData(ErrorData value) =>
        new(Optional<ErrorData>.Some(value), default);

    private static DownloadTokenizedDatasetError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorData(out ErrorData value) => _errorDataValue.TryGetValue(out value);

    private static Task<DownloadTokenizedDatasetError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            404 => response.Json<ErrorData>().As(AsErrorData),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<DownloadTokenizedDatasetError> Response { get; } = new(Create);
}
