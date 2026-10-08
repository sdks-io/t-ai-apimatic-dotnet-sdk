using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Errors;

public sealed class CreateANewSecretError : ApiError
{
    private readonly Optional<object> _anonymousObjectValue;

    private CreateANewSecretError(Optional<object> anonymousObjectValue, Optional<RawError> fallback) : base(fallback)
    {
        _anonymousObjectValue = anonymousObjectValue;
    }

    private static CreateANewSecretError AsAnonymousObject(object value) => new(Optional<object>.Some(value), default);

    private static CreateANewSecretError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetAnonymousObject(out object value) => _anonymousObjectValue.TryGetValue(out value);

    private static Task<CreateANewSecretError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 500 => response.Json<object>().As(AsAnonymousObject),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<CreateANewSecretError> Response { get; } = new(Create);
}
