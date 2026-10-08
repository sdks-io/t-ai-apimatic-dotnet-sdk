using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;

namespace TogetherApIs.Errors;

public sealed class ShadowExperimentServiceCreateTargetError : ApiError
{
    private readonly Optional<ErrorData> _errorDataValue;

    private ShadowExperimentServiceCreateTargetError(Optional<ErrorData> errorDataValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorDataValue = errorDataValue;
    }

    private static ShadowExperimentServiceCreateTargetError AsErrorData(ErrorData value) =>
        new(Optional<ErrorData>.Some(value), default);

    private static ShadowExperimentServiceCreateTargetError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorData(out ErrorData value) => _errorDataValue.TryGetValue(out value);

    private static Task<ShadowExperimentServiceCreateTargetError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<ErrorData>().As(AsErrorData),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<ShadowExperimentServiceCreateTargetError> Response { get; } = new(Create);
}
