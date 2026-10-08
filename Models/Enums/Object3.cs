using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The object type, which is always <c>deployment</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Object3>))]
public sealed record Object3 : OpenStringEnum<Object3>
{
    private Object3(string value) : base(value)
    {
    }

    public static readonly Object3 Deployment = new("deployment");

    public TResult Match<TResult>(Func<TResult> onDeployment, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Deployment => onDeployment(),
            _ => otherwise(Value)
        };

    public void Match(Action onDeployment, Action<string> otherwise)
    {
        if (this == Deployment) onDeployment();
        else otherwise(Value);
    }
}
