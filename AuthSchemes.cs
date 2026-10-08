using TogetherApIs.Core.Authentication;
using TogetherApIs.Core.Authentication.Bearer;

namespace TogetherApIs;

internal sealed class AuthSchemes
{
    public IAuthScheme BearerAuth { get; }

    public AuthSchemes(TogetherApIsClientOptions options)
    {
        BearerAuth = BearerAuthScheme.Create(options.BearerAuth);
    }
}
