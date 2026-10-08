namespace TogetherApIs.Requests.InstanceTypeService;

/// <summary>
/// The inputs of the InstanceTypeServiceGetInferenceInstanceType operation.
/// </summary>
public sealed record InstanceTypeServiceGetInferenceInstanceTypeRequest
{
    public required string Id { get; init; }
}
