using System.Threading.Tasks;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Models;
using TogetherApIs.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Errors;

public sealed class PreviewTokenizedDataError : ApiError
{
    private readonly Optional<FineTunesPreviewResponse> _fineTunesPreviewResponseValue;

    private readonly Optional<ErrorData> _errorDataValue;

    private readonly Optional<FineTunePreviewMessageError> _fineTunePreviewMessageErrorValue;

    private readonly Optional<FineTunePreviewDetailError> _fineTunePreviewDetailErrorValue;

    private PreviewTokenizedDataError(Optional<FineTunesPreviewResponse> fineTunesPreviewResponseValue,
        Optional<ErrorData> errorDataValue,
        Optional<FineTunePreviewMessageError> fineTunePreviewMessageErrorValue,
        Optional<FineTunePreviewDetailError> fineTunePreviewDetailErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _fineTunesPreviewResponseValue = fineTunesPreviewResponseValue;
        _errorDataValue = errorDataValue;
        _fineTunePreviewMessageErrorValue = fineTunePreviewMessageErrorValue;
        _fineTunePreviewDetailErrorValue = fineTunePreviewDetailErrorValue;
    }

    private static PreviewTokenizedDataError AsFineTunesPreviewResponse(FineTunesPreviewResponse value) =>
        new(Optional<FineTunesPreviewResponse>.Some(value), default, default, default, default);

    private static PreviewTokenizedDataError AsErrorData(ErrorData value) =>
        new(default, Optional<ErrorData>.Some(value), default, default, default);

    private static PreviewTokenizedDataError AsFineTunePreviewMessageError(FineTunePreviewMessageError value) =>
        new(default, default, Optional<FineTunePreviewMessageError>.Some(value), default, default);

    private static PreviewTokenizedDataError AsFineTunePreviewDetailError(FineTunePreviewDetailError value) =>
        new(default, default, default, Optional<FineTunePreviewDetailError>.Some(value), default);

    private static PreviewTokenizedDataError AsFallback(RawError value) =>
        new(default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetFineTunesPreviewResponse(out FineTunesPreviewResponse value) =>
        _fineTunesPreviewResponseValue.TryGetValue(out value);

    public bool TryGetErrorData(out ErrorData value) => _errorDataValue.TryGetValue(out value);

    public bool TryGetFineTunePreviewMessageError(out FineTunePreviewMessageError value) =>
        _fineTunePreviewMessageErrorValue.TryGetValue(out value);

    public bool TryGetFineTunePreviewDetailError(out FineTunePreviewDetailError value) =>
        _fineTunePreviewDetailErrorValue.TryGetValue(out value);

    private static Task<PreviewTokenizedDataError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 => response.Json<FineTunesPreviewResponse>().As(AsFineTunesPreviewResponse),
            401 or 404 => response.Json<ErrorData>().As(AsErrorData),
            500 or 502 => response.Json<FineTunePreviewMessageError>().As(AsFineTunePreviewMessageError),
            503 => response.Json<FineTunePreviewDetailError>().As(AsFineTunePreviewDetailError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<PreviewTokenizedDataError> Response { get; } = new(Create);
}
