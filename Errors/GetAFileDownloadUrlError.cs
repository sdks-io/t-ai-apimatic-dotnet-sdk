using System.Collections.Generic;
using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Errors;

public sealed class GetAFileDownloadUrlError : ApiError
{
    private readonly Optional<IReadOnlyDictionary<string, string>> _mapOfStringValue;

    private GetAFileDownloadUrlError(Optional<IReadOnlyDictionary<string, string>> mapOfStringValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _mapOfStringValue = mapOfStringValue;
    }

    private static GetAFileDownloadUrlError AsMapOfString(IReadOnlyDictionary<string, string> value) =>
        new(Optional<IReadOnlyDictionary<string, string>>.Some(value), default);

    private static GetAFileDownloadUrlError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetMapOfString(out IReadOnlyDictionary<string, string> value) =>
        _mapOfStringValue.TryGetValue(out value);

    private static Task<GetAFileDownloadUrlError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 404 or 500 => response.Json<IReadOnlyDictionary<string, string>>().As(AsMapOfString),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<GetAFileDownloadUrlError> Response { get; } = new(Create);
}
