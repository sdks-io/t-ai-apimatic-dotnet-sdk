using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Model5>))]
public sealed record Model5 : OpenStringEnum<Model5>
{
    private Model5(string value) : base(value)
    {
    }

    public static readonly Model5 WhereIsAiUaeLargeV1 = new("WhereIsAI/UAE-Large-V1");

    public static readonly Model5 BaaiBgeLargeEnV15 = new("BAAI/bge-large-en-v1.5");

    public static readonly Model5 BaaiBgeBaseEnV15 = new("BAAI/bge-base-en-v1.5");

    public static readonly Model5 TogethercomputerM2Bert80M8KRetrieval = new(
        "togethercomputer/m2-bert-80M-8k-retrieval");

    public TResult Match<TResult>(Func<TResult> onWhereIsAiUaeLargeV1,
        Func<TResult> onBaaiBgeLargeEnV15,
        Func<TResult> onBaaiBgeBaseEnV15,
        Func<TResult> onTogethercomputerM2Bert80M8KRetrieval,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == WhereIsAiUaeLargeV1 => onWhereIsAiUaeLargeV1(),
            _ when this == BaaiBgeLargeEnV15 => onBaaiBgeLargeEnV15(),
            _ when this == BaaiBgeBaseEnV15 => onBaaiBgeBaseEnV15(),
            _ when this == TogethercomputerM2Bert80M8KRetrieval => onTogethercomputerM2Bert80M8KRetrieval(),
            _ => otherwise(Value)
        };

    public void Match(Action onWhereIsAiUaeLargeV1,
        Action onBaaiBgeLargeEnV15,
        Action onBaaiBgeBaseEnV15,
        Action onTogethercomputerM2Bert80M8KRetrieval,
        Action<string> otherwise)
    {
        if (this == WhereIsAiUaeLargeV1) onWhereIsAiUaeLargeV1();
        else if (this == BaaiBgeLargeEnV15) onBaaiBgeLargeEnV15();
        else if (this == BaaiBgeBaseEnV15) onBaaiBgeBaseEnV15();
        else if (this == TogethercomputerM2Bert80M8KRetrieval) onTogethercomputerM2Bert80M8KRetrieval();
        else otherwise(Value);
    }
}
