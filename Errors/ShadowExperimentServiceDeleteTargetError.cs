using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;

namespace TogetherApIs.Errors;

public sealed class ShadowExperimentServiceDeleteTargetError : ApiError
{
    private readonly Optional<ErrorData> _errorDataValue;

    private ShadowExperimentServiceDeleteTargetError(Optional<ErrorData> errorDataValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorDataValue = errorDataValue;
    }

    private static ShadowExperimentServiceDeleteTargetError AsErrorData(ErrorData value) =>
        new(Optional<ErrorData>.Some(value), default);

    private static ShadowExperimentServiceDeleteTargetError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetErrorData(out ErrorData value) => _errorDataValue.TryGetValue(out value);

    private static Task<ShadowExperimentServiceDeleteTargetError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<ErrorData>().As(AsErrorData),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<ShadowExperimentServiceDeleteTargetError> Response { get; } = new(Create);
}
