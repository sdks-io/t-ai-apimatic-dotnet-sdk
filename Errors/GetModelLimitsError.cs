using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;

namespace TogetherApIs.Errors;

public sealed class GetModelLimitsError : ApiError
{
    private readonly Optional<FineTunesModelsLimits404Error1> _fineTunesModelsLimits404Error1Value;

    private GetModelLimitsError(Optional<FineTunesModelsLimits404Error1> fineTunesModelsLimits404Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _fineTunesModelsLimits404Error1Value = fineTunesModelsLimits404Error1Value;
    }

    private static GetModelLimitsError AsFineTunesModelsLimits404Error1(FineTunesModelsLimits404Error1 value) =>
        new(Optional<FineTunesModelsLimits404Error1>.Some(value), default);

    private static GetModelLimitsError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetFineTunesModelsLimits404Error1(out FineTunesModelsLimits404Error1 value) =>
        _fineTunesModelsLimits404Error1Value.TryGetValue(out value);

    private static Task<GetModelLimitsError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            404 => response.Json<FineTunesModelsLimits404Error1>().As(AsFineTunesModelsLimits404Error1),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetModelLimitsError> Response { get; } = new(Create);
}
