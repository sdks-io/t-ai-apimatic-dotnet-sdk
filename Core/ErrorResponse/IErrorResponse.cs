using System.Threading;
using System.Threading.Tasks;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Core.ErrorResponse;

internal interface IErrorResponse<TError>
{
    Task<TError> Map(ResponseContext context, CancellationToken cancellationToken);
}