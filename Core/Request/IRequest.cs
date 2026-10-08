using System.Net.Http;

namespace TogetherApIs.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}