using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Errors;

public sealed class DeleteADeploymentError : ApiError
{
    private readonly Optional<object> _anonymousObjectValue;

    private DeleteADeploymentError(Optional<object> anonymousObjectValue, Optional<RawError> fallback) : base(fallback)
    {
        _anonymousObjectValue = anonymousObjectValue;
    }

    private static DeleteADeploymentError AsAnonymousObject(object value) => new(Optional<object>.Some(value), default);

    private static DeleteADeploymentError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetAnonymousObject(out object value) => _anonymousObjectValue.TryGetValue(out value);

    private static Task<DeleteADeploymentError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            404 or 500 => response.Json<object>().As(AsAnonymousObject),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<DeleteADeploymentError> Response { get; } = new(Create);
}
