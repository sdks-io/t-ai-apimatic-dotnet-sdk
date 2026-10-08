using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;

namespace TogetherApIs.Errors;

public sealed class AudioTranscriptionsError : ApiError
{
    private readonly Optional<ErrorData> _errorDataValue;

    private readonly Optional<RawError> _noContentValue;

    private AudioTranscriptionsError(Optional<ErrorData> errorDataValue,
        Optional<RawError> noContentValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorDataValue = errorDataValue;
        _noContentValue = noContentValue;
    }

    private static AudioTranscriptionsError AsErrorData(ErrorData value) =>
        new(Optional<ErrorData>.Some(value), default, default);

    private static AudioTranscriptionsError AsNoContent(RawError value) =>
        new(default, Optional<RawError>.Some(value), default);

    private static AudioTranscriptionsError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetErrorData(out ErrorData value) => _errorDataValue.TryGetValue(out value);

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    private static Task<AudioTranscriptionsError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 429 => response.Json<ErrorData>().As(AsErrorData),
            413 => response.RawBody().As(AsNoContent),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<AudioTranscriptionsError> Response { get; } = new(Create);
}
