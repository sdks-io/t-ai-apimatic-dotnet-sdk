using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Errors;

public sealed class CreateANewDeploymentError : ApiError
{
    private readonly Optional<object> _anonymousObjectValue;

    private CreateANewDeploymentError(Optional<object> anonymousObjectValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _anonymousObjectValue = anonymousObjectValue;
    }

    private static CreateANewDeploymentError AsAnonymousObject(object value) =>
        new(Optional<object>.Some(value), default);

    private static CreateANewDeploymentError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetAnonymousObject(out object value) => _anonymousObjectValue.TryGetValue(out value);

    private static Task<CreateANewDeploymentError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 500 => response.Json<object>().As(AsAnonymousObject),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<CreateANewDeploymentError> Response { get; } = new(Create);
}
