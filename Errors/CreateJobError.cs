using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;

namespace TogetherApIs.Errors;

public sealed class CreateJobError : ApiError
{
    private readonly Optional<ErrorData> _errorDataValue;

    private CreateJobError(Optional<ErrorData> errorDataValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorDataValue = errorDataValue;
    }

    private static CreateJobError AsErrorData(ErrorData value) => new(Optional<ErrorData>.Some(value), default);

    private static CreateJobError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorData(out ErrorData value) => _errorDataValue.TryGetValue(out value);

    private static Task<CreateJobError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            503 => response.Json<ErrorData>().As(AsErrorData),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<CreateJobError> Response { get; } = new(Create);
}
