using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Product>))]
public sealed record Product : OpenStringEnum<Product>
{
    private Product(string value) : base(value)
    {
    }

    public static readonly Product ProductServerless = new("PRODUCT_SERVERLESS");

    public static readonly Product ProductDedicated = new("PRODUCT_DEDICATED");

    public static readonly Product ProductFineTuning = new("PRODUCT_FINE_TUNING");

    public static readonly Product ProductReserved = new("PRODUCT_RESERVED");

    public TResult Match<TResult>(Func<TResult> onProductServerless,
        Func<TResult> onProductDedicated,
        Func<TResult> onProductFineTuning,
        Func<TResult> onProductReserved,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ProductServerless => onProductServerless(),
            _ when this == ProductDedicated => onProductDedicated(),
            _ when this == ProductFineTuning => onProductFineTuning(),
            _ when this == ProductReserved => onProductReserved(),
            _ => otherwise(Value)
        };

    public void Match(Action onProductServerless,
        Action onProductDedicated,
        Action onProductFineTuning,
        Action onProductReserved,
        Action<string> otherwise)
    {
        if (this == ProductServerless) onProductServerless();
        else if (this == ProductDedicated) onProductDedicated();
        else if (this == ProductFineTuning) onProductFineTuning();
        else if (this == ProductReserved) onProductReserved();
        else otherwise(Value);
    }
}
