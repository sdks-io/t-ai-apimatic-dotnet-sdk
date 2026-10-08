using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Category that classifies why the rollout stopped.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Category>))]
public sealed record Category : OpenStringEnum<Category>
{
    private Category(string value) : base(value)
    {
    }

    public static readonly Category RolloutFailureCategoryMetricRegression = new(
        "ROLLOUT_FAILURE_CATEGORY_METRIC_REGRESSION");

    public static readonly Category RolloutFailureCategoryMetricsUnavailable = new(
        "ROLLOUT_FAILURE_CATEGORY_METRICS_UNAVAILABLE");

    public static readonly Category RolloutFailureCategoryTargetNotReady = new(
        "ROLLOUT_FAILURE_CATEGORY_TARGET_NOT_READY");

    public static readonly Category RolloutFailureCategorySourceNotDrained = new(
        "ROLLOUT_FAILURE_CATEGORY_SOURCE_NOT_DRAINED");

    public static readonly Category RolloutFailureCategoryHealthRegression = new(
        "ROLLOUT_FAILURE_CATEGORY_HEALTH_REGRESSION");

    public static readonly Category RolloutFailureCategoryCapacityExhausted = new(
        "ROLLOUT_FAILURE_CATEGORY_CAPACITY_EXHAUSTED");

    public static readonly Category RolloutFailureCategoryRoutingError = new("ROLLOUT_FAILURE_CATEGORY_ROUTING_ERROR");

    public static readonly Category RolloutFailureCategoryDependencyOutage = new(
        "ROLLOUT_FAILURE_CATEGORY_DEPENDENCY_OUTAGE");

    public static readonly Category RolloutFailureCategoryAbortedByOperator = new(
        "ROLLOUT_FAILURE_CATEGORY_ABORTED_BY_OPERATOR");

    public static readonly Category RolloutFailureCategoryInternal = new("ROLLOUT_FAILURE_CATEGORY_INTERNAL");

    public static readonly Category RolloutFailureCategoryPolicyInfeasible = new(
        "ROLLOUT_FAILURE_CATEGORY_POLICY_INFEASIBLE");

    public static readonly Category RolloutFailureCategoryUnderServed = new("ROLLOUT_FAILURE_CATEGORY_UNDER_SERVED");

    public static readonly Category RolloutFailureCategoryEntitlementLapsed = new(
        "ROLLOUT_FAILURE_CATEGORY_ENTITLEMENT_LAPSED");

    public TResult Match<TResult>(Func<TResult> onRolloutFailureCategoryMetricRegression,
        Func<TResult> onRolloutFailureCategoryMetricsUnavailable,
        Func<TResult> onRolloutFailureCategoryTargetNotReady,
        Func<TResult> onRolloutFailureCategorySourceNotDrained,
        Func<TResult> onRolloutFailureCategoryHealthRegression,
        Func<TResult> onRolloutFailureCategoryCapacityExhausted,
        Func<TResult> onRolloutFailureCategoryRoutingError,
        Func<TResult> onRolloutFailureCategoryDependencyOutage,
        Func<TResult> onRolloutFailureCategoryAbortedByOperator,
        Func<TResult> onRolloutFailureCategoryInternal,
        Func<TResult> onRolloutFailureCategoryPolicyInfeasible,
        Func<TResult> onRolloutFailureCategoryUnderServed,
        Func<TResult> onRolloutFailureCategoryEntitlementLapsed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == RolloutFailureCategoryMetricRegression => onRolloutFailureCategoryMetricRegression(),
            _ when this == RolloutFailureCategoryMetricsUnavailable => onRolloutFailureCategoryMetricsUnavailable(),
            _ when this == RolloutFailureCategoryTargetNotReady => onRolloutFailureCategoryTargetNotReady(),
            _ when this == RolloutFailureCategorySourceNotDrained => onRolloutFailureCategorySourceNotDrained(),
            _ when this == RolloutFailureCategoryHealthRegression => onRolloutFailureCategoryHealthRegression(),
            _ when this == RolloutFailureCategoryCapacityExhausted => onRolloutFailureCategoryCapacityExhausted(),
            _ when this == RolloutFailureCategoryRoutingError => onRolloutFailureCategoryRoutingError(),
            _ when this == RolloutFailureCategoryDependencyOutage => onRolloutFailureCategoryDependencyOutage(),
            _ when this == RolloutFailureCategoryAbortedByOperator => onRolloutFailureCategoryAbortedByOperator(),
            _ when this == RolloutFailureCategoryInternal => onRolloutFailureCategoryInternal(),
            _ when this == RolloutFailureCategoryPolicyInfeasible => onRolloutFailureCategoryPolicyInfeasible(),
            _ when this == RolloutFailureCategoryUnderServed => onRolloutFailureCategoryUnderServed(),
            _ when this == RolloutFailureCategoryEntitlementLapsed => onRolloutFailureCategoryEntitlementLapsed(),
            _ => otherwise(Value)
        };

    public void Match(Action onRolloutFailureCategoryMetricRegression,
        Action onRolloutFailureCategoryMetricsUnavailable,
        Action onRolloutFailureCategoryTargetNotReady,
        Action onRolloutFailureCategorySourceNotDrained,
        Action onRolloutFailureCategoryHealthRegression,
        Action onRolloutFailureCategoryCapacityExhausted,
        Action onRolloutFailureCategoryRoutingError,
        Action onRolloutFailureCategoryDependencyOutage,
        Action onRolloutFailureCategoryAbortedByOperator,
        Action onRolloutFailureCategoryInternal,
        Action onRolloutFailureCategoryPolicyInfeasible,
        Action onRolloutFailureCategoryUnderServed,
        Action onRolloutFailureCategoryEntitlementLapsed,
        Action<string> otherwise)
    {
        if (this == RolloutFailureCategoryMetricRegression) onRolloutFailureCategoryMetricRegression();
        else if (this == RolloutFailureCategoryMetricsUnavailable) onRolloutFailureCategoryMetricsUnavailable();
        else if (this == RolloutFailureCategoryTargetNotReady) onRolloutFailureCategoryTargetNotReady();
        else if (this == RolloutFailureCategorySourceNotDrained) onRolloutFailureCategorySourceNotDrained();
        else if (this == RolloutFailureCategoryHealthRegression) onRolloutFailureCategoryHealthRegression();
        else if (this == RolloutFailureCategoryCapacityExhausted) onRolloutFailureCategoryCapacityExhausted();
        else if (this == RolloutFailureCategoryRoutingError) onRolloutFailureCategoryRoutingError();
        else if (this == RolloutFailureCategoryDependencyOutage) onRolloutFailureCategoryDependencyOutage();
        else if (this == RolloutFailureCategoryAbortedByOperator) onRolloutFailureCategoryAbortedByOperator();
        else if (this == RolloutFailureCategoryInternal) onRolloutFailureCategoryInternal();
        else if (this == RolloutFailureCategoryPolicyInfeasible) onRolloutFailureCategoryPolicyInfeasible();
        else if (this == RolloutFailureCategoryUnderServed) onRolloutFailureCategoryUnderServed();
        else if (this == RolloutFailureCategoryEntitlementLapsed) onRolloutFailureCategoryEntitlementLapsed();
        else otherwise(Value);
    }
}
