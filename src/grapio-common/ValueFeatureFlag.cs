namespace grapio_common;

/// <summary>
/// Represents a <see cref="OpenFeature.Model.Value"/> feature flag.
/// </summary>
public class ValueFeatureFlag: FeatureFlagBase<object>
{
    /// <inheritdoc />
    public ValueFeatureFlag()
    {
    }
    
    /// <inheritdoc />
    public ValueFeatureFlag(string flagKey, object value) : base(flagKey, value)
    {
    }
}
