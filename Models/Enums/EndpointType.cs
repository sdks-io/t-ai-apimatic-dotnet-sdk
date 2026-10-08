using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Serving class of the endpoint. Reserved endpoints use reserved capacity.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EndpointType>))]
public sealed record EndpointType : OpenStringEnum<EndpointType>
{
    private EndpointType(string value) : base(value)
    {
    }

    public static readonly EndpointType EndpointTypeDedicated = new("ENDPOINT_TYPE_DEDICATED");

    public static readonly EndpointType EndpointTypeServerless = new("ENDPOINT_TYPE_SERVERLESS");

    public static readonly EndpointType EndpointTypeReserved = new("ENDPOINT_TYPE_RESERVED");

    public TResult Match<TResult>(Func<TResult> onEndpointTypeDedicated,
        Func<TResult> onEndpointTypeServerless,
        Func<TResult> onEndpointTypeReserved,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == EndpointTypeDedicated => onEndpointTypeDedicated(),
            _ when this == EndpointTypeServerless => onEndpointTypeServerless(),
            _ when this == EndpointTypeReserved => onEndpointTypeReserved(),
            _ => otherwise(Value)
        };

    public void Match(Action onEndpointTypeDedicated,
        Action onEndpointTypeServerless,
        Action onEndpointTypeReserved,
        Action<string> otherwise)
    {
        if (this == EndpointTypeDedicated) onEndpointTypeDedicated();
        else if (this == EndpointTypeServerless) onEndpointTypeServerless();
        else if (this == EndpointTypeReserved) onEndpointTypeReserved();
        else otherwise(Value);
    }
}
