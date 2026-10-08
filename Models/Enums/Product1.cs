using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Filter models by product surface.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Product1>))]
public sealed record Product1 : OpenStringEnum<Product1>
{
    private Product1(string value) : base(value)
    {
    }

    public static readonly Product1 ProductServerless = new("PRODUCT_SERVERLESS");

    public static readonly Product1 ProductDedicated = new("PRODUCT_DEDICATED");

    public static readonly Product1 ProductFineTuning = new("PRODUCT_FINE_TUNING");

    public TResult Match<TResult>(Func<TResult> onProductServerless,
        Func<TResult> onProductDedicated,
        Func<TResult> onProductFineTuning,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ProductServerless => onProductServerless(),
            _ when this == ProductDedicated => onProductDedicated(),
            _ when this == ProductFineTuning => onProductFineTuning(),
            _ => otherwise(Value)
        };

    public void Match(Action onProductServerless,
        Action onProductDedicated,
        Action onProductFineTuning,
        Action<string> otherwise)
    {
        if (this == ProductServerless) onProductServerless();
        else if (this == ProductDedicated) onProductDedicated();
        else if (this == ProductFineTuning) onProductFineTuning();
        else otherwise(Value);
    }
}
