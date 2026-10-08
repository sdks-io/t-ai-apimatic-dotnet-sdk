using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Model6>))]
public sealed record Model6 : OpenStringEnum<Model6>
{
    private Model6(string value) : base(value)
    {
    }

    public static readonly Model6 BlackForestLabsFlux1SchnellFree = new("black-forest-labs/FLUX.1-schnell-Free");

    public static readonly Model6 BlackForestLabsFlux1Schnell = new("black-forest-labs/FLUX.1-schnell");

    public static readonly Model6 BlackForestLabsFlux11Pro = new("black-forest-labs/FLUX.1.1-pro");

    public TResult Match<TResult>(Func<TResult> onBlackForestLabsFlux1SchnellFree,
        Func<TResult> onBlackForestLabsFlux1Schnell,
        Func<TResult> onBlackForestLabsFlux11Pro,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BlackForestLabsFlux1SchnellFree => onBlackForestLabsFlux1SchnellFree(),
            _ when this == BlackForestLabsFlux1Schnell => onBlackForestLabsFlux1Schnell(),
            _ when this == BlackForestLabsFlux11Pro => onBlackForestLabsFlux11Pro(),
            _ => otherwise(Value)
        };

    public void Match(Action onBlackForestLabsFlux1SchnellFree,
        Action onBlackForestLabsFlux1Schnell,
        Action onBlackForestLabsFlux11Pro,
        Action<string> otherwise)
    {
        if (this == BlackForestLabsFlux1SchnellFree) onBlackForestLabsFlux1SchnellFree();
        else if (this == BlackForestLabsFlux1Schnell) onBlackForestLabsFlux1Schnell();
        else if (this == BlackForestLabsFlux11Pro) onBlackForestLabsFlux11Pro();
        else otherwise(Value);
    }
}
