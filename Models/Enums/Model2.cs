using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Model2>))]
public sealed record Model2 : OpenStringEnum<Model2>
{
    private Model2(string value) : base(value)
    {
    }

    public static readonly Model2 CartesiaSonic = new("cartesia/sonic");

    public static readonly Model2 HexgradKokoro82M = new("hexgrad/Kokoro-82M");

    public static readonly Model2 CanopylabsOrpheus3B01Ft = new("canopylabs/orpheus-3b-0.1-ft");

    public TResult Match<TResult>(Func<TResult> onCartesiaSonic,
        Func<TResult> onHexgradKokoro82M,
        Func<TResult> onCanopylabsOrpheus3B01Ft,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CartesiaSonic => onCartesiaSonic(),
            _ when this == HexgradKokoro82M => onHexgradKokoro82M(),
            _ when this == CanopylabsOrpheus3B01Ft => onCanopylabsOrpheus3B01Ft(),
            _ => otherwise(Value)
        };

    public void Match(Action onCartesiaSonic,
        Action onHexgradKokoro82M,
        Action onCanopylabsOrpheus3B01Ft,
        Action<string> otherwise)
    {
        if (this == CartesiaSonic) onCartesiaSonic();
        else if (this == HexgradKokoro82M) onHexgradKokoro82M();
        else if (this == CanopylabsOrpheus3B01Ft) onCanopylabsOrpheus3B01Ft();
        else otherwise(Value);
    }
}
