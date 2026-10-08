using TogetherApIs.Models;

namespace TogetherApIs.Requests.CodeInterpreter;

/// <summary>
/// The inputs of the TciExecute operation.
/// </summary>
public sealed record TciExecuteRequest
{
    /// <summary>
    /// Execute Request
    /// </summary>
    public ExecuteRequest? Body { get; init; }
}
