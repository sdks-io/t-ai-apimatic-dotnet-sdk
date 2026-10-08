using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Whether the value is exact or a lower bound.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Relation>))]
public sealed record Relation : OpenStringEnum<Relation>
{
    private Relation(string value) : base(value)
    {
    }

    public static readonly Relation RelationEq = new("RELATION_EQ");

    public static readonly Relation RelationGte = new("RELATION_GTE");

    public TResult Match<TResult>(Func<TResult> onRelationEq,
        Func<TResult> onRelationGte,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == RelationEq => onRelationEq(),
            _ when this == RelationGte => onRelationGte(),
            _ => otherwise(Value)
        };

    public void Match(Action onRelationEq, Action onRelationGte, Action<string> otherwise)
    {
        if (this == RelationEq) onRelationEq();
        else if (this == RelationGte) onRelationGte();
        else otherwise(Value);
    }
}
