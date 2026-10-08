using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;

namespace TogetherApIs.Errors;

public sealed class ShadowExperimentServiceCreateShadowExperimentError : ApiError
{
    private readonly Optional<ErrorData> _errorDataValue;

    private ShadowExperimentServiceCreateShadowExperimentError(Optional<ErrorData> errorDataValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorDataValue = errorDataValue;
    }

    private static ShadowExperimentServiceCreateShadowExperimentError AsErrorData(ErrorData value) =>
        new(Optional<ErrorData>.Some(value), default);

    private static ShadowExperimentServiceCreateShadowExperimentError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorData(out ErrorData value) => _errorDataValue.TryGetValue(out value);

    private static Task<ShadowExperimentServiceCreateShadowExperimentError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<ErrorData>().As(AsErrorData),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<ShadowExperimentServiceCreateShadowExperimentError> Response { get; } = new(
        Create);
}
