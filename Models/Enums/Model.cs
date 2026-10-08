using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Model>))]
public sealed record Model : OpenStringEnum<Model>
{
    private Model(string value) : base(value)
    {
    }

    public static readonly Model SalesforceLlamaRankV1 = new("Salesforce/Llama-Rank-v1");

    public TResult Match<TResult>(Func<TResult> onSalesforceLlamaRankV1, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SalesforceLlamaRankV1 => onSalesforceLlamaRankV1(),
            _ => otherwise(Value)
        };

    public void Match(Action onSalesforceLlamaRankV1, Action<string> otherwise)
    {
        if (this == SalesforceLlamaRankV1) onSalesforceLlamaRankV1();
        else otherwise(Value);
    }
}
