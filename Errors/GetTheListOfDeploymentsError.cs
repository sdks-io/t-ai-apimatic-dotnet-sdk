using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Errors;

public sealed class GetTheListOfDeploymentsError : ApiError
{
    private readonly Optional<object> _anonymousObjectValue;

    private GetTheListOfDeploymentsError(Optional<object> anonymousObjectValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _anonymousObjectValue = anonymousObjectValue;
    }

    private static GetTheListOfDeploymentsError AsAnonymousObject(object value) =>
        new(Optional<object>.Some(value), default);

    private static GetTheListOfDeploymentsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetAnonymousObject(out object value) => _anonymousObjectValue.TryGetValue(out value);

    private static Task<GetTheListOfDeploymentsError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            500 => response.Json<object>().As(AsAnonymousObject),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetTheListOfDeploymentsError> Response { get; } = new(Create);
}
